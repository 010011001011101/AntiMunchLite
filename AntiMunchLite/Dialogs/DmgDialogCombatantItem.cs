using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntiMunchLite.Dialogs
{
  public partial class DmgDialogCombatantItem : UserControl
  {
    public Core.Combatant Combatant { get; private set; }

    public DmgDialogCombatantItem()
    {
      InitializeComponent();
    }

    public void Initialize(Core.Combatant combatant, bool selected)
    {
      Combatant = combatant;

      NameCB.Text = combatant.Name;
      NameCB.Checked = selected;
    }

    public bool ApplyDmg(int dmg)
    {
      if (!_Apply(ref dmg))
        return false;

      Combatant.CurrentHp -= dmg;
      return true;
    }

    public bool ApplyHeal(int heal, bool noOverheal)
    {
      if (!_Apply(ref heal))
        return false;

      if (noOverheal)
        heal = Math.Min(heal, Combatant.MaxHp - Combatant.CurrentHp);

      if (heal > 0)
      {
        Combatant.CurrentHp += heal;
        return true;
      }

      return false;
    }

    private bool _Apply(ref int value)
    {
      if (!NameCB.Checked || value <= 0)
        return false;

      if (HalfR.Checked)
        value /= 2;
      else if (DoubleR.Checked)
        value *= 2;

      return true;
    }

    private void NameCB_CheckedChanged(object sender, EventArgs e)
    {
      if (NameCB.Checked)
        BackColor = ColorUtils.Green;
      else
        BackColor = Color.White;
    }
  }
}
