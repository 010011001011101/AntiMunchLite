using System;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public partial class DMGDialog : Form
  {
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
