using System;
using System.Windows.Forms;

namespace AntiMunchLite.Dialogs
{
  public partial class SaveDialog : Form
  {
    public static string GetSaveFileName(string pregen, IWin32Window parent)
    {
      using (var dialog = new SaveDialog())
      {
        dialog.SaveFileName.Text = pregen;

        return dialog.ShowDialog(parent) == DialogResult.OK
          ? dialog.SaveFileName.Text
          : null;
      }
    }

    public SaveDialog()
    {
      InitializeComponent();
    }

    private void SaveDialog_Load(object sender, EventArgs e)
    {
      SaveFileName.Select();
    }
  }
}
