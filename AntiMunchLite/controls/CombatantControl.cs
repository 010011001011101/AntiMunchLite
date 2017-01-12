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
    private readonly Core.Core _Core;
    private readonly Action _OnInitiativeChange;
    private readonly Action<IEnumerable<Combatant>> _OnEffectAdd;
    private readonly Action<Combatant> _DeleteDelegate;
    private readonly ControlsCache<EffectControl> _ControlsCache;

    private bool _Inited;
    public Combatant Combatant { get; private set; }
    public bool IsCurrent { get; private set; }


    public CombatantControl()
    {
      InitializeComponent();
    }

    public CombatantControl(Core.Core core,
      Action onInitiativeChangeDelegate, Action<IEnumerable<Combatant>> onEffectAdd, Action<Combatant> deleteDelegate) : this()
    {
      _Core = core;
      _OnInitiativeChange = onInitiativeChangeDelegate;
      _OnEffectAdd = onEffectAdd;
      _DeleteDelegate = deleteDelegate;

      _ControlsCache = new ControlsCache<EffectControl>(EffectsFlow.Controls, _CreateEffectControl);
    }

    #region Initialize

    public void Initialize(Combatant combatant, bool isCurrent)
    {
      IsCurrent = isCurrent;

      _SetIsCurrent();
      _InitializeCombatant(combatant);
      
      RefreshEffects();
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

    private void _SetIsCurrent()
    {
      CombatantName.BackColor =
      BackColor = IsCurrent ? ColorUtils.Green : ColorUtils.Yellow;
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

    private void CurrentHp_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.CurrentHp = (int)CurrentHp.Value;

      if (Combatant.CurrentHp > 0 && Combatant.MaxHp == 0)
        MaxHp.Value = Combatant.CurrentHp;
      else
        _RefreshHpStatus();
    }

    private void MaxHp_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.MaxHp = (int)MaxHp.Value;
      _RefreshHpStatus();
    }

    private void DmgBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      var dmg = DMGDialog.GetNewDmg(Parent);
      if(!dmg.HasValue) return;

      CurrentHp.Value -= dmg.Value;
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

      _ControlsCache.AbjustSize(Combatant.Effects.Count());

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
        : 31;
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
