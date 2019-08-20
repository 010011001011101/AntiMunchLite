using System.Windows.Forms;

namespace AntiMunchLite.Dialogs
{
  public partial class ResetDialog : Form
  {
    public static bool ResetEncounter(Core.Core core, IWin32Window parent)
    {
      if (core.Started &&
          DialogResult.Yes != MessageBox.Show(parent, @"Confirm Encounter Reset", @"Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
        return false;

      using (var dialog = new ResetDialog())
      {
        if (dialog.ShowDialog(parent) == DialogResult.OK)
        {
          core.Reset(dialog.DropInitiativeCB.Checked, dialog.DropEffectsCB.Checked);
          return true;
        }

        return false;
      }
    }

    public ResetDialog()
    {
      InitializeComponent();
    }
  }
}
