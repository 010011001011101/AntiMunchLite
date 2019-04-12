using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public class SaveLoadManager
  {
    private const string SaveFilesExtension = "amls";
    private readonly IWin32Window _Parent;


    public SaveLoadManager(IWin32Window parent)
    {
      _Parent = parent;
    }

    public void Save(Core.Core core)
    {
      try
      {
        _Save(core);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, @"Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public Core.Core Load()
    {
      try
      {
        return _Load();
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, @"Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return null;
      }
    }

    private void _Save(Core.Core core)
    {
      using (var dialog = new SaveFileDialog())
      {
        dialog.FileName = $"Save_R{core.CurrentRound}_[{DateTime.Now:MM.dd.yy H.mm.ss}].{SaveFilesExtension}";
        dialog.Filter = $"AntiMunchLite Save | *.{SaveFilesExtension}";
        dialog.RestoreDirectory = true;

        if(dialog.ShowDialog(_Parent) == DialogResult.OK)
          using (var file = dialog.OpenFile())
          {
            var formetter = new BinaryFormatter();
            formetter.Serialize(file, core);
          }
      }
    }

    private Core.Core _Load()
    {
      using (var dialog = new OpenFileDialog())
      {
        dialog.CheckFileExists = true;
        dialog.Filter = $"AntiMunchLite Save | *.{SaveFilesExtension}";
        dialog.RestoreDirectory = true;

        if (dialog.ShowDialog(_Parent) == DialogResult.OK)
          using (var file = dialog.OpenFile())
            return new BinaryFormatter().Deserialize(file) as Core.Core;

        return null;
      }
    }
  }
}