using System;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public partial class DMGDialog : Form
  {
    public static decimal? GetNewDmg(IWin32Window parent)
    {
      using (var dialog = new DMGDialog())
        return dialog.ShowDialog(parent) == DialogResult.OK
                 ? dialog.DmgCounter.Value
                 : (decimal?) null;
    }

    public DMGDialog()
    {
      InitializeComponent();
    }

    private void DMGDialog_Load(object sender, EventArgs e)
    {
      DmgCounter.Select(0, 1);
    }
  }
}
