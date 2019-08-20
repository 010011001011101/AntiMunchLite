using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite.Dialogs
{
  public partial class CloneDialog : Form
  {
    public static bool ResetEncounter(Core.Core core, IWin32Window parent)
    {
      using (var dialog = new CloneDialog(core))
      {
        if (dialog.ShowDialog(parent) == DialogResult.OK)
        {
          core.CloneCombatants(dialog.Combotants.CheckedItems.OfType<Combatant>(), dialog.DropInitiativeCB.Checked, dialog.DropHPCB.Checked);
          return true;
        }

        return false;
      }
    }

    public CloneDialog(Core.Core core)
    {
      InitializeComponent();

      var allCombatants = core.Combatants.OrderBy(c => c.Name).ToList();
      Combotants.Items.AddRange(allCombatants.Cast<object>().ToArray());
    }
  }
}
