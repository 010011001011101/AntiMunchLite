using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite.Dialogs
{
  public partial class AbilityDialog : Form
  {
    private readonly Core.Core _Core;

    public static List<Combatant> CreateAbility(Core.Core core, Combatant combatant, IWin32Window parent)
    {
      using (var dialog = new AbilityDialog(core, combatant))
        return dialog.ShowDialog(parent) == DialogResult.OK
          ? dialog._CreateAbility().ToList()
          : new List<Combatant>();
    }

    private IEnumerable<Combatant> _CreateAbility()
    {
      if (Combotants.CheckedItems.Count == 0)
        yield break;

      if (!_Core.PreGenAbilities.Contains(NameCB.Text))
        _Core.PreGenAbilities.Add(NameCB.Text);

      foreach (Combatant combatant in Combotants.CheckedItems)
      {
        combatant.Abilities.Add(new Ability
        {
          Name = NameCB.Text,
          Remain = (int)RemainNum.Value,
          Total = (int)TotalNum.Value
        });
        combatant.ShowAbilities = true;

        yield return combatant;
      }
    }

    public AbilityDialog(Core.Core core, Combatant combatant)
    {
      _Core = core;

      InitializeComponent();

      NameCB.Items.AddRange(_Core.PreGenAbilities.Cast<object>().ToArray());
      var allCombatants = _Core.Combatants.OrderBy(c => c.Name).ToList();
      Combotants.Items.AddRange(allCombatants.Cast<object>().ToArray());
      Combotants.SetItemChecked(allCombatants.IndexOf(combatant), true);
    }
  }
}
