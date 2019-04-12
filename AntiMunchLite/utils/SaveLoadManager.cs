using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using AntiMunchLite.Dialogs;

namespace AntiMunchLite
{
  public class SaveLoadManager
  {
    private const string SavesFolder = "Saves";
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

    #region Save

    private void _Save(Core.Core core)
    {
      var directory = _GetSavesDirectory();
      var fileName = _GenerateFileName(core);
      if (string.IsNullOrWhiteSpace(fileName))
        return;

      using (var file = new FileStream(Path.Combine(directory.ToString(), fileName + $".{SaveFilesExtension}"), FileMode.Create))
      {
        var formetter = new BinaryFormatter();
        formetter.Serialize(file, core);
      }
    }

    private static DirectoryInfo _GetSavesDirectory()
    {
      var directory = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, SavesFolder));

      if(!directory.Exists)
        directory.Create();

      return directory;
    }

    private string _GenerateFileName(Core.Core core)
    {
      return SaveDialog.GetSaveFileName($"Save_R{core.CurrentRound}_[{DateTime.Now:MM.dd.yy H.mm.ss}]", _Parent);
    }

    #endregion

    #region Load

    private Core.Core _Load()
    {
      var fileName = _SelectFile();
      if (fileName == null) return null;

      using (var file = new FileStream(fileName, FileMode.Open))
        return new BinaryFormatter().Deserialize(file) as Core.Core;
    }

    private string _SelectFile()
    {
      using (var dialog = new OpenFileDialog())
      {
        dialog.CheckFileExists = true;
        dialog.Filter = $"AntiMunchLite Save | *.{SaveFilesExtension}";
        dialog.InitialDirectory = _GetSavesDirectory().ToString();

        return dialog.ShowDialog(_Parent) == DialogResult.OK
                 ? dialog.FileName
                 : null;
      }
    }

    #endregion
  }
}