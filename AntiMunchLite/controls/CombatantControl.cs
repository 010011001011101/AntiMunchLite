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
    private readonly Action _OnInitiativeChange;
    private readonly Action<IEnumerable<Combatant>> _OnEffectAdd, _OnDamage;
    private readonly Action<Combatant> _DeleteDelegate;
    private readonly ControlsCache<EffectControl> _ControlsCache;

    private bool _Inited;
    private readonly int _DefaultHeight;
    public Combatant Combatant { get; private set; }
    public bool IsCurrent { get; private set; }


    public CombatantControl()
    {
      InitializeComponent();

      _DefaultHeight = Height;
    }

    public CombatantControl(Core.Core core,
                            Action onInitiativeChangeDelegate,
                            Action<IEnumerable<Combatant>> onEffectAdd,
                            Action<IEnumerable<Combatant>> onDamage,
                            Action<Combatant> deleteDelegate)
      : this()
    {
      _Core = core;
      _OnInitiativeChange = onInitiativeChangeDelegate;
      _OnEffectAdd = onEffectAdd;
      _OnDamage = onDamage;
      _DeleteDelegate = deleteDelegate;

      _ControlsCache = new ControlsCache<EffectControl>(EffectsFlow.Controls, _CreateEffectControl);
    }

    public void ResetCore(Core.Core core)
    {
      _Core = core;
    }

    #region Initialize

    public void Initialize(Combatant combatant, bool isCurrent)
    {
      if (Combatant != combatant)
      {
        _InitializeCombatant(combatant);
        RefreshEffects();
      }

      _SetIsCurrent(isCurrent);
    }

    private void _InitializeCombatant(Combatant combatant)
    {
      _Inited = false;

      Combatant = combatant;
      Initiative.Value = combatant.Initiative;
      SubInitiative.Value = combatant.SubInitiative;
      CombatantName.Text = combatant.Name;
      CurrentHp.Value = combatant.CurrentHp;
      MaxHp.Value = combatant.MaxHp;
      _RefreshHpStatus();

      _Inited = true;
    }

    private void _SetIsCurrent(bool isCurrent)
    {
      IsCurrent = isCurrent;

      var backColor = IsCurrent ? ColorUtils.Green : ColorUtils.Yellow;
      CombatantName.BackColor = BackColor = backColor;
      foreach (var effectControl in _ControlsCache)
        effectControl.SetTextBackColor(backColor);

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

      Combatant.SubInitiative = (uint)SubInitiative.Value;
      _OnInitiativeChange();
    }

    private void CombatantName_TextChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.Name = CombatantName.Text;
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

      _DeleteDelegate(Combatant);
    }

    private void AddEffectBtn_Click(object sender, EventArgs e)
    {
      _OnEffectAdd(EffectDialog.CreateEffect(_Core, Combatant, Parent));
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

      _ControlsCache.AbjustSize(Combatant.Effects.Count);

      var effects = Combatant.Effects.OrderBy(e => e.Type).ToList();
      for (var i = 0; i < effects.Count; ++i)
        _ControlsCache[i].Initialize(effects[i], BackColor);

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

    public void RefreshSize()
    {
      var prSize = EffectsFlow.PreferredSize;
      var heightMult = (int)((double)prSize.Width / EffectsFlow.Width) + 1;

      Height = heightMult > 1
        ? EffectsFlow.GetPreferredSize(new Size(EffectsFlow.Width, prSize.Height * heightMult)).Height
        : _DefaultHeight;
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
