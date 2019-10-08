using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;
using AntiMunchLite.Dialogs;

namespace AntiMunchLite.Controls
{
  public partial class CombatantControl : UserControl
  {
    private Core.Core _Core;
    public Combatant Combatant { get; private set; }
    private readonly ControlsCache<EffectControl> _EffectsControlsCache;
    private readonly ControlsCache<AbilityControl> _AbilitiesControlsCache;
    
    private readonly int _DefaultHeight;
    private readonly float _DefaultEffectsHeight, _DefaultCommentHeight, _DefaultAbilitiesHeight;
    private readonly float _MinCommentHeight;

    public bool Inited { get; private set; }
    public bool IsCurrent { get; private set; }
    private Color _BackColor;

    public ShiftInitiativeMode ShiftMode { get; private set; } = ShiftInitiativeMode.None;

    #region Events

    public event Action InitiativeChange;
    private void _OnInitiativeChange() => InitiativeChange?.Invoke();

    public event Action ManualResize;
    private void _OnManualResize() => ManualResize?.Invoke();

    public event Action<IEnumerable<Combatant>> Damage;
    private void _OnDamage(IEnumerable<Combatant> combatants) => Damage?.Invoke(combatants);
    
    public event Action<IEnumerable<Combatant>> EffectAdd;
    private void _OnEffectAdd(IEnumerable<Combatant> combatants) => EffectAdd?.Invoke(combatants);

    public event Action<IEnumerable<Combatant>> AbilityAdd;
    private void _OnAbilityAdd(IEnumerable<Combatant> combatants) => AbilityAdd?.Invoke(combatants);

    public event Action<Combatant> NeedDeleteCombatant;
    private void _OnNeedDeleteCombatant(Combatant combatant) => NeedDeleteCombatant?.Invoke(combatant);

    public event Action ShiftStart;
    private void _OnShiftStart() => ShiftStart?.Invoke();

    public event Action ShiftEnd;
    private void _OnShiftEnd() => ShiftEnd?.Invoke();

    #endregion

    public CombatantControl()
    {
      InitializeComponent();

      _EffectsControlsCache = new ControlsCache<EffectControl>(EffectsFlow.Controls, _CreateEffectControl);
      _AbilitiesControlsCache = new ControlsCache<AbilityControl>(AbilitiesFlow.Controls, _CreateAbilityControl);

      _DefaultHeight = Height;
      _DefaultEffectsHeight = TableLayoutPanel.RowStyles[1].Height;
      _DefaultCommentHeight = TableLayoutPanel.RowStyles[2].Height;
      _DefaultAbilitiesHeight = TableLayoutPanel.RowStyles[3].Height;
      _MinCommentHeight = Comment.Height;

      ControlsUtils.SubscribeOnChildDragOver(this, (s, e) => OnDragOver(e));
    }

    #region Initialize

    public void Initialize(Core.Core core, Combatant combatant, bool isCurrent, bool forceInitiativeInit)
    {
      _Core = core;

      Inited = false;

      if (Combatant != combatant)
        _InitializeCombatant(combatant);
      else if (forceInitiativeInit)
        _InitializeInitiative();

      Inited = true;

      _InitializeCurrentStatus(isCurrent);
      _InitializeSubBoxesVisibility();

      RefreshEffects();
      RefreshAbilities();
      _RefreshShiftInitiativeImage();
      RefreshHeight();
    }

    private void _InitializeCombatant(Combatant combatant)
    {
      Combatant = combatant;
      CombatantName.Text = combatant.Name;
      Comment.Text = combatant.Comment;
      CurrentHp.Value = combatant.CurrentHp;
      MaxHp.Value = combatant.MaxHp;
      _InitializeInitiative();
      _RefreshHpStatus();
    }

    private void _InitializeInitiative()
    {
      Initiative.Value = Combatant.Initiative;
      SubInitiative.Value = Combatant.SubInitiative;
    }

    private void _InitializeCurrentStatus(bool isCurrent)
    {
      IsCurrent = isCurrent;

      ArrowPB.Visible = IsCurrent;
      _ResetBackColor();
    }

    private void _ResetBackColor()
    {
      _BackColor = ColorUtils.GetBackColor(IsCurrent);

      CombatantName.BackColor = BackColor = _BackColor;
      foreach (var effectControl in _EffectsControlsCache)
        effectControl.SetTextBackColor(_BackColor);
      foreach (var abilityControl in _AbilitiesControlsCache)
        abilityControl.SetTextBackColor(_BackColor);
    }

    public void MarkInitiativeCollision(bool collision)
    {
      SubInitiative.BackColor =
      Initiative.BackColor = collision ? ColorUtils.Red : _BackColor;
    }

    private void _InitializeSubBoxesVisibility()
    {
      ShowEffectsCB.Checked = Combatant.ShowEffects;
      ShowCommentCB.Checked = Combatant.ShowComment;
      ShowAbilitiesCB.Checked = Combatant.ShowAbilities;
    }

    #endregion

    #region Events

    private void Initiative_ValueChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.Initiative = (int)Initiative.Value;
      _OnInitiativeChange();
    }

    private void SubInitiative_ValueChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.SubInitiative = (int)SubInitiative.Value;
      _OnInitiativeChange();
    }

    private void CombatantName_TextChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.Name = CombatantName.Text;
    }

    private void Comment_TextChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.Comment = Comment.Text;

      if (RefreshHeight())
        _OnManualResize();
    }

    private bool _IgnoreHpValueChange;
    private void CurrentHp_ValueChanged(object sender, EventArgs e)
    {
      if (!Inited || _IgnoreHpValueChange) return;

      Combatant.CurrentHp = (int)CurrentHp.Value;

      if (Combatant.CurrentHp > 0 && Combatant.MaxHp == 0)
        MaxHp.Value = Combatant.CurrentHp;
      else
        _RefreshHpStatus();
    }

    private void MaxHp_ValueChanged(object sender, EventArgs e)
    {
      if (!Inited || _IgnoreHpValueChange) return;

      Combatant.MaxHp = (int)MaxHp.Value;
      _RefreshHpStatus();
    }

    private void DmgBtn_Click(object sender, EventArgs e)
    {
      if (!Inited) return;

      _OnDamage(DmgDialog.MakeDamage(_Core, Combatant, false, Parent));
    }

    private void HealBtn_Click(object sender, EventArgs e)
    {
      if (!Inited) return;

      _OnDamage(DmgDialog.MakeDamage(_Core, Combatant, true, Parent));
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      if (!Inited) return;

      if (DialogResult.Yes != MessageBox.Show($"Confirm Deletion of [{CombatantName.Text}]", @"Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

      _OnNeedDeleteCombatant(Combatant);
    }

    private void ShowEffectsCB_CheckedChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.ShowEffects = ShowEffectsCB.Checked;
      if (RefreshHeight())
        _OnManualResize();
    }

    private void ShowCommentCB_CheckedChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.ShowComment = ShowCommentCB.Checked;
      if (RefreshHeight())
        _OnManualResize();
    }

    private void ShowAbilitiesCB_CheckedChanged(object sender, EventArgs e)
    {
      if (!Inited) return;

      Combatant.ShowAbilities = ShowAbilitiesCB.Checked;
      if (RefreshHeight())
        _OnManualResize();
    }

    private void AddEffectBtn_Click(object sender, EventArgs e)
    {
      if (!Inited) return;

      _OnEffectAdd(EffectDialog.CreateEffect(_Core, Combatant, Parent));
    }

    private void AddAbilityBtn_Click(object sender, EventArgs e)
    {
      if (!Inited) return;

      _OnAbilityAdd(AbilityDialog.CreateAbility(_Core, Combatant, Parent));
    }

    #endregion

    public void RefreshHp()
    {
      try
      {
        _IgnoreHpValueChange = true;

        CurrentHp.Value = Combatant.CurrentHp;
        MaxHp.Value = Combatant.MaxHp;
        _RefreshHpStatus();
      }
      finally
      {
        _IgnoreHpValueChange = false;
      }
    }

    private void _RefreshHpStatus()
    {
      StatusLbl.Text = Combatant.HpStatus.ToString();
      StatusLbl.ForeColor =
      CurrentHp.ForeColor =
      MaxHp.ForeColor = Combatant.HpStatus.ToColor();
    }

    #region Effects

    public void RefreshEffects()
    {
      EffectsFlow.SuspendLayout();

      _EffectsControlsCache.AbjustSize(Combatant.Effects.Count);

      var effects = Combatant.Effects.OrderBy(e => e.Type).ToList();
      for (var i = 0; i < effects.Count; ++i)
        _EffectsControlsCache[i].Initialize(effects[i], BackColor);

      RefreshHeight();
      EffectsFlow.ResumeLayout();
    }

    private EffectControl _CreateEffectControl()
    {
      var newControl = new EffectControl();
      newControl.NeedDeleteEffect += _DeleteEffect;
      newControl.DragOver += (s, e) => OnDragOver(e);

      return newControl;
    }

    private void _DeleteEffect(Effect effect)
    {
      Combatant.Effects.Remove(effect);

      RefreshEffects();
    }

    #endregion

    #region Abilities

    public void RefreshAbilities()
    {
      AbilitiesFlow.SuspendLayout();

      _AbilitiesControlsCache.AbjustSize(Combatant.Abilities.Count);

      var abilities = Combatant.Abilities.ToList();
      for (var i = 0; i < abilities.Count; ++i)
        _AbilitiesControlsCache[i].Initialize(abilities[i], BackColor);

      RefreshHeight();
      AbilitiesFlow.ResumeLayout();
    }

    private AbilityControl _CreateAbilityControl()
    {
      var newControl = new AbilityControl();
      newControl.NeedDeleteAbility += _DeleteAbility;
      newControl.DragOver += (s, e) => OnDragOver(e);

      return newControl;
    }

    private void _DeleteAbility(Ability ability)
    {
      Combatant.Abilities.Remove(ability);

      RefreshAbilities();
    }

    #endregion

    public bool RefreshHeight()
    {
      if (!Inited) return false;

      var effectsDelta = GetFlowDelta(EffectsFlow, Combatant.ShowEffects, _DefaultEffectsHeight);
      var commentDelta = GetCommentDelta(Comment, Combatant.ShowComment, _MinCommentHeight, _DefaultCommentHeight);
      var abilitiesDelta = GetFlowDelta(AbilitiesFlow, Combatant.ShowAbilities, _DefaultAbilitiesHeight);
      
      TableLayoutPanel.RowStyles[1].Height = _DefaultEffectsHeight + effectsDelta;
      TableLayoutPanel.RowStyles[2].Height = _DefaultCommentHeight + commentDelta;
      TableLayoutPanel.RowStyles[3].Height = _DefaultAbilitiesHeight + abilitiesDelta;

      Comment.Visible = Combatant.ShowComment;//Because TextBox ignore zero height of it table cell

      var newHeight = (int) (_DefaultHeight + effectsDelta + commentDelta + abilitiesDelta);
      if (Height != newHeight)
      {
        Height = newHeight;
        return true;
      }
      return false;

      float GetFlowDelta(FlowLayoutPanel flow, bool showFlag, float totalBoxHeight)
      {
        if (!showFlag) return -totalBoxHeight;

        var prSize = flow.PreferredSize;
        var heightMult = (int) ((double) prSize.Width / flow.Width) + 1;
        return heightMult > 1
          ? flow.GetPreferredSize(new Size(flow.Width, prSize.Height * heightMult)).Height - prSize.Height
          : 0;
      }

      float GetCommentDelta(TextBox textBox, bool showFlag, float min, float totalBoxHeight)
      {
        if (!showFlag) return -totalBoxHeight;

        var prSize = textBox.GetPreferredSize(new Size(textBox.Width, 0));
        return prSize.Height <= min
          ? 0
          : prSize.Height - min;
      }
    }

    #region Shift Initiative

    private void DragPB_MouseDown(object sender, MouseEventArgs e)
    {
      if (ShiftMode != ShiftInitiativeMode.None) return;

      ShiftMode = ShiftInitiativeMode.ShiftFrom;
      _OnShiftStart();

      DragPB.DoDragDrop(CombatantName.Text, DragDropEffects.Copy);

      _OnShiftEnd();
    }

    private void CombatantControl_DragOver(object sender, DragEventArgs e)
    {
      if(ShiftMode == ShiftInitiativeMode.None ||
         ShiftMode == ShiftInitiativeMode.ShiftFrom) return;

      e.Effect = DragDropEffects.Copy;

      ShiftMode = PointToClient(new Point(e.X, e.Y)).Y < Height / 2
        ? ShiftInitiativeMode.ShiftToBefore
        : ShiftInitiativeMode.ShiftToAfter;

      _RefreshShiftInitiativeImage();
    }

    private void CombatantControl_DragLeave(object sender, EventArgs e)
    {
      if(ShiftMode == ShiftInitiativeMode.None) return;

      if (ShiftMode != ShiftInitiativeMode.ShiftFrom)
        ShiftMode = ShiftInitiativeMode.NoShift;

      _RefreshShiftInitiativeImage();
    }

    public void OnShiftStart()
    {
      if (ShiftMode != ShiftInitiativeMode.ShiftFrom)
        ShiftMode = ShiftInitiativeMode.NoShift;

      _RefreshShiftInitiativeImage();
    }

    public void OnShiftEnd(bool canceled)
    {
      ShiftMode = ShiftInitiativeMode.None;

      if(canceled)
        _RefreshShiftInitiativeImage();
    }

    private void _RefreshShiftInitiativeImage()
    {
      switch (ShiftMode)
      {
        case ShiftInitiativeMode.None:
          DragPB.Image = Properties.Resources.Move;
          break;
        case ShiftInitiativeMode.NoShift:
          DragPB.Image = null;
          break;
        case ShiftInitiativeMode.ShiftFrom:
          DragPB.Image = Properties.Resources.From;
          break;
        case ShiftInitiativeMode.ShiftToBefore:
          DragPB.Image = Properties.Resources.Up;
          break;
        case ShiftInitiativeMode.ShiftToAfter:
          DragPB.Image = Properties.Resources.Down;
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    public enum ShiftInitiativeMode
    {
      None,
      NoShift,
      ShiftFrom,
      ShiftToBefore,
      ShiftToAfter,
    }

    #endregion

    public void ShowDamageDialog()
    {
      DmgBtn.PerformClick();
    }

    public void ShowHealDialog()
    {
      HealBtn.PerformClick();
    }

    public void ShowAddEffectDialog()
    {
      if (!ShowEffectsCB.Checked)
        ShowEffectsCB.Checked = true;

      AddEffectBtn.PerformClick();
    }
  }

  public static class HpStatusExtensions
  {
    public static Color ToColor(this HpStatus status)
    {
      switch (status)
      {
        case HpStatus.Uninjured:
        case HpStatus.Light:
          return Color.DarkGreen;
        case HpStatus.Medium:
          return Color.DarkOrange;
        case HpStatus.Heavy:
        case HpStatus.Critical:
          return Color.Red;
        case HpStatus.BellowZero:
          return Color.Purple;
        default:
          return Color.Black;
      }
    }
  }
}
