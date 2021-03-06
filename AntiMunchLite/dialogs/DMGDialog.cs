﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class DmgDialog : Form
  {
    public static List<Combatant> MakeDamage(Core.Core core, Combatant combatant, bool heal, IWin32Window parent)
    {
      using (var dialog = new DmgDialog(core, combatant, heal))
        return dialog.ShowDialog(parent) == DialogResult.OK
          ? dialog._MakeDamage().ToList()
          : new List<Combatant>();
    }

    public DmgDialog(Core.Core core, Combatant combatant, bool heal)
    {
      InitializeComponent();

      if (heal)
        IsHeal.Checked = true;

      var allCombatants = core.Combatants.OrderBy(c => c.Name).ToList();
      Combotants.Items.AddRange(allCombatants.Cast<object>().ToArray());
      Combotants.SetItemChecked(allCombatants.IndexOf(combatant), true);
    }

    private void DMGDialog_Load(object sender, EventArgs e)
    {
      DmgCounter.Select(0, 1);
    }

    private IEnumerable<Combatant> _MakeDamage()
    {
      var dmg = DmgCounter.Value;
      if (dmg == 0) yield break;

      if (IsHeal.Checked) dmg *= -1;

      foreach (Combatant combatant in Combotants.CheckedItems)
      {
        combatant.CurrentHp -= dmg;

        if (NoOverheal.Checked &&
            combatant.CurrentHp > combatant.MaxHp &&
            dmg < 0)
          combatant.CurrentHp = combatant.MaxHp;

        yield return combatant;
      }
    }
  }
}
