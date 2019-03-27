using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class CombatantControl : UserControl
  {
    private Core.Core _Core;
    private readonly Action _OnInitiativeChange, _OnShiftStart, _OnShiftEnd;
    private readonly Action<IEnumerable<Combatant>> _OnEffectAdd, _OnAbilityAdd, _OnDamage;
    private readonly Action<Combatant> _DeleteDelegate;
    private readonly Action _OnManualResize;
    private readonly ControlsCache<EffectControl> _EffectsControlsCache;
    private readonly ControlsCache<AbilityControl> _AbilitiesControlsCache;

    private bool _Inited;
    private readonly int _DefaultHeight;
    private readonly float _DefaultEffectsHeight, _DefaultCommentHeight, _DefaultAbilitiesHeight;
    public Combatant Combatant { get; private set; }
    public bool IsCurrent { get; private set; }

    public ShiftInitiativeMode ShiftMode { get; private set; } = ShiftInitiativeMode.None;


    public CombatantControl()
    {
      InitializeComponent();

      _DefaultHeight = Height;
      _DefaultEffectsHeight = TableLayoutPanel.RowStyles[1].Height;
      _DefaultCommentHeight = TableLayoutPanel.RowStyles[2].Height;
      _DefaultAbilitiesHeight = TableLayoutPanel.RowStyles[3].Height;
    }

    public CombatantControl(Core.Core core,
                            Action onInitiativeChangeDelegate,
                            Action<IEnumerable<Combatant>> onEffectAdd,
                            Action<IEnumerable<Combatant>> onAbilityAdd,
                            Action<IEnumerable<Combatant>> onDamage,
                            Action<Combatant> deleteDelegate,
                            Action onShiftStart,
                            Action onShiftEnd,
                            Action onManualResize)
      : this()
    {
      _Core = core;
      _OnInitiativeChange = onInitiativeChangeDelegate;
      _OnEffectAdd = onEffectAdd;
      _OnAbilityAdd = onAbilityAdd;
      _OnDamage = onDamage;
      _DeleteDelegate = deleteDelegate;
      _OnShiftStart = onShiftStart;
      _OnShiftEnd = onShiftEnd;
      _OnManualResize = onManualResize;

      _EffectsControlsCache = new ControlsCache<EffectControl>(EffectsFlow.Controls, _CreateEffectControl);
      _AbilitiesControlsCache = new ControlsCache<AbilityControl>(AbilitiesFlow.Controls, _CreateAbilityControl);
    }

    public void ResetCore(Core.Core core)
    {
      _Core = core;
    }

    #region Initialize

    public void Initialize(Combatant combatant, bool isCurrent, bool forceInitiativeInit)
    {
      _Inited = false;

      if (Combatant != combatant)
        _InitializeCombatant(combatant);
      else if (forceInitiativeInit)
        _InitializeInitiative(combatant);

      _Inited = true;

      _SetIsCurrent(isCurrent);
      RefreshEffects();
      RefreshAbilities();
      _RefreshShiftInitiativeImage();
      _InitSubBoxesVisibility();
    }

    private void _InitializeCombatant(Combatant combatant)
    {
      Combatant = combatant;
      _InitializeInitiative(combatant);
      CombatantName.Text = combatant.Name;
      Comment.Text = combatant.Comment;
      CurrentHp.Value = combatant.CurrentHp;
      MaxHp.Value = combatant.MaxHp;
      _RefreshHpStatus();
    }

    private void _InitializeInitiative(Combatant combatant)
    {
      Initiative.Value = combatant.Initiative;
      SubInitiative.Value = combatant.SubInitiative;
    }

    private void _SetIsCurrent(bool isCurrent)
    {
      IsCurrent = isCurrent;

      var backColor = IsCurrent ? ColorUtils.Green : ColorUtils.Yellow;
      CombatantName.BackColor = BackColor = backColor;
      foreach (var effectControl in _EffectsControlsCache)
        effectControl.SetTextBackColor(backColor);
      foreach (var abilityControl in _AbilitiesControlsCache)
        abilityControl.SetTextBackColor(backColor);

      ArrowPB.Visible = IsCurrent;
    }

    public void MarkInitiativeCollision(bool collision)
    {
      SubInitiative.BackColor =
      Initiative.BackColor = collision
                                ? ColorUtils.Red
                                : IsCurrent
                                    ? ColorUtils.Green
                                    : ColorUtils.Yellow;
    }

    private void _InitSubBoxesVisibility()
    {
      ShowEffectsCB.Checked = Combatant.ShowEffects;
      ShowCommentCB.Checked = Combatant.ShowComment;
      ShowAbilitiesCB.Checked = Combatant.ShowAbilities;

      RefreshSize();
    }

    #endregion

    #region Events

    private void Initiative_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.Initiative = (int)Initiative.Value;
      _OnInitiativeChange();
    }

    private void SubInitiative_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.SubInitiative = (int)SubInitiative.Value;
      _OnInitiativeChange();
    }

    private void CombatantName_TextChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.Name = CombatantName.Text;
    }

    private void Comment_TextChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.Comment = Comment.Text;
    }

    private bool _IgnoreHpValueChange;
    private void CurrentHp_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited || _IgnoreHpValueChange) return;

      Combatant.CurrentHp = (int)CurrentHp.Value;

      if (Combatant.CurrentHp > 0 && Combatant.MaxHp == 0)
        MaxHp.Value = Combatant.CurrentHp;
      else
        _RefreshHpStatus();
    }

    private void MaxHp_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited || _IgnoreHpValueChange) return;

      Combatant.MaxHp = (int)MaxHp.Value;
      _RefreshHpStatus();
    }

    private void DmgBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      _OnDamage(DMGDialog.MakeDamage(_Core, Combatant, false, Parent));
    }

    private void HealBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      _OnDamage(DMGDialog.MakeDamage(_Core, Combatant, true, Parent));
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      if (DialogResult.Yes != MessageBox.Show($"Confirm Deletion of [{CombatantName.Text}]", @"Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

      _DeleteDelegate(Combatant);
    }

    private void ShowEffectsCB_CheckedChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.ShowEffects = ShowEffectsCB.Checked;
      RefreshSize();
      _OnManualResize();
    }

    private void ShowCommentCB_CheckedChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.ShowComment = ShowCommentCB.Checked;
      RefreshSize();
      _OnManualResize();
    }

    private void ShowAbilitiesCB_CheckedChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.ShowAbilities = ShowAbilitiesCB.Checked;
      RefreshSize();
      _OnManualResize();
    }

    private void AddEffectBtn_Click(object sender, EventArgs e)
    {
      _OnEffectAdd(EffectDialog.CreateEffect(_Core, Combatant, Parent));
    }

    private void AddAbilityBtn_Click(object sender, EventArgs e)
    {
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

      RefreshSize();
      EffectsFlow.ResumeLayout();
    }

    private EffectControl _CreateEffectControl()
    {
      return new EffectControl(_DeleteEffect);
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

      RefreshSize();
      AbilitiesFlow.ResumeLayout();
    }

    private AbilityControl _CreateAbilityControl()
    {
      return new AbilityControl(_DeleteAbility);
    }

    private void _DeleteAbility(Ability ability)
    {
      Combatant.Abilities.Remove(ability);

      RefreshAbilities();
    }

    #endregion

    public void RefreshSize()
    {
      var effectsDelta = GetFlowDelta(EffectsFlow, Combatant.ShowEffects, _DefaultEffectsHeight);
      var commentDelta = Combatant.ShowComment ? 0 : -_DefaultCommentHeight;
      var abilitiesDelta = GetFlowDelta(AbilitiesFlow, Combatant.ShowAbilities, _DefaultAbilitiesHeight);

      TableLayoutPanel.RowStyles[1].Height = _DefaultEffectsHeight + effectsDelta;
      TableLayoutPanel.RowStyles[2].Height = _DefaultCommentHeight + commentDelta;
      TableLayoutPanel.RowStyles[3].Height = _DefaultAbilitiesHeight + abilitiesDelta;

      Height = (int)(_DefaultHeight + effectsDelta + commentDelta + abilitiesDelta);

      float GetFlowDelta(FlowLayoutPanel flow, bool showFlag, float totalBoxHeight)
      {
        var prSize = flow.PreferredSize;
        var heightMult = (int)((double)prSize.Width / flow.Width) + 1;
        return showFlag
          ? heightMult > 1
            ? flow.GetPreferredSize(new Size(flow.Width, prSize.Height * heightMult)).Height - prSize.Height
            : 0
          : -totalBoxHeight;
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
