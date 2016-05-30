using System;
using System.Drawing;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class CombatantControl : UserControl
  {
    private readonly bool _Inited;
    private readonly Action _OnInitiativeChange;
    public Combatant Combatant { get; private set; }


    public CombatantControl()
    {
      InitializeComponent();
    }

    public CombatantControl(Combatant combatant, bool isCurrent,
      Action onInitiativeChangeDelegate, Action<Combatant> deleteDelegate) : this()
    {
      _OnInitiativeChange = onInitiativeChangeDelegate;
      Combatant = combatant;

      Initiative.Value = combatant.Initiative;
      CombatantName.Text = combatant.Name;
      CurrentHp.Value = combatant.CurrentHp;
      MaxHp.Value = combatant.MaxHp;
      _RefreshHpStatus();
      _Inited = true;

      CombatantName.BackColor =
      Initiative.BackColor =
      BackColor = isCurrent
        ? Color.FromArgb(202, 245, 199)
        : Color.FromArgb(255, 255, 221);

      DelBtn.Click += (s, e) => deleteDelegate(combatant);
    }

    private void Initiative_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Combatant.Initiative = Initiative.Value;
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
      using (var dmgDialog = new DMGDialog())
      {
        if (dmgDialog.ShowDialog(Parent) != DialogResult.OK)
          return;

        CurrentHp.Value -= dmgDialog.DmgCounter.Value;
      }
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
