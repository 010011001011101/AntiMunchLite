using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
