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
    private readonly Action _OnInitiativeChange;
    private readonly Action<Combatant> _DeleteDelegate;

    private readonly List<EffectControl> _ControlsCache = new List<EffectControl>();

    private bool _Inited;
    public Combatant Combatant { get; private set; }


    public CombatantControl()
    {
      InitializeComponent();
    }

    public CombatantControl(Action onInitiativeChangeDelegate, Action<Combatant> deleteDelegate) : this()
    {
      _OnInitiativeChange = onInitiativeChangeDelegate;
      _DeleteDelegate = deleteDelegate;
    }

    public void Initialize(Combatant combatant, bool isCurrent)
    {
      _Inited = false;

      Combatant = combatant;

      Initiative.Value = combatant.Initiative;
      SubInitiative.Value = combatant.SubInitiative;
      CombatantName.Text = combatant.Name;
      CurrentHp.Value = combatant.CurrentHp;
      MaxHp.Value = combatant.MaxHp;
      _RefreshHpStatus();

      _RefreshBackColor(isCurrent);
      ArrowPB.Visible = isCurrent;

      RefreshEffects();

      _Inited = true;
    }

    private void _RefreshBackColor(bool isCurrent)
    {
      CombatantName.BackColor =
      SubInitiative.BackColor =
      Initiative.BackColor =
      BackColor = isCurrent ? ColorUtils.Green : ColorUtils.Yellow;
    }

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
      _RefreshHpStatus();
    }

    private void MaxHp_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.MaxHp = (int)MaxHp.Value;
      _RefreshHpStatus();
    }

    private void _RefreshHpStatus()
    {
      StatusLbl.Text = Combatant.HpStatus.ToString();
      StatusLbl.ForeColor =
      CurrentHp.ForeColor = 
      MaxHp.ForeColor = Combatant.HpStatus.ToColor();
    }

    private void DmgBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      using (var dmgDialog = new DMGDialog())
      {
        if (dmgDialog.ShowDialog(Parent) != DialogResult.OK)
          return;

        CurrentHp.Value -= dmgDialog.DmgCounter.Value;
      }
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      _DeleteDelegate(Combatant);
    }

    private void AddEffectBtn_Click(object sender, EventArgs e)
    {
      Combatant.Effects.Add(new Effect {Name = "sd22wasa", RemainTurns = 2});

      RefreshEffects();
    }

    #region Effects

    public void RefreshEffects()
    {
      EffectsFlow.SuspendLayout();

      _AbjustCacheSize();

      var effects = Combatant.Effects.OrderBy(e => e.Type).ToList();
      for (var i = 0; i < effects.Count; ++i)
        _ControlsCache[i].Initialize(effects[i], BackColor);

      RefreshSize();
      EffectsFlow.ResumeLayout();
    }

    private void _AbjustCacheSize()
    {
      var currentSize = _ControlsCache.Count;
      var newSize = Combatant.Effects.Count();

      if (currentSize > newSize)
        foreach (var controlToDelete in _ControlsCache.Take(currentSize - newSize).ToList())
        {
          _ControlsCache.Remove(controlToDelete);
          EffectsFlow.Controls.Remove(controlToDelete);
          controlToDelete.Dispose();
        }

      if (currentSize < newSize)
        foreach (var i in Enumerable.Range(0, newSize - currentSize))
        {
          var newControl = new EffectControl(_DeleteEffect);
          _ControlsCache.Add(newControl);
          EffectsFlow.Controls.Add(newControl);
        }
    }

    private void _DeleteEffect(Effect effect)
    {
      Combatant.Effects.Remove(effect);

      RefreshEffects();
    }

    public void RefreshSize()
    {
      var prSize = EffectsFlow.PreferredSize;
      var heightMult = (int)((double)prSize.Width / EffectsFlow.Width) + 1;

      Height = heightMult > 1
        ? EffectsFlow.GetPreferredSize(new Size(EffectsFlow.Width, prSize.Height * heightMult)).Height
        : 31;
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
