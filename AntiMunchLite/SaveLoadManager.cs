using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public class SaveLoadManager
  {
    private const string SavesFolder = "Saves";
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

    public bool Load(ref Core.Core core)
    {
      try
      {
        var loadedCore = _Load();
        if (loadedCore != null)
        {
          core = loadedCore;
          return true;
        }
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, @"Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return false;
    }

    #region Save

    private static void _Save(Core.Core core)
    {
      var directory = _GetSavesDirectory();
      var fileName = Path.Combine(directory.ToString(), _GenerateFileName(core));
      using (var file = new FileStream(fileName, FileMode.Create))
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

    private static string _GenerateFileName(Core.Core core)
    {
      return string.Format("Save_R{0}_[{1:MM.dd.yy H.mm.ss}].amls", core.CurrentRound, DateTime.Now);
    }

    #endregion

    #region Save

    private Core.Core _Load()
    {
      var fileName = _SelectFile();
      if (fileName == null) return null;

      using (var file = new FileStream(fileName, FileMode.Open))
      {
        var formetter = new BinaryFormatter();
        return  formetter.Deserialize(file) as Core.Core;
      }
    }

    private string _SelectFile()
    {
      using (var dialog = new OpenFileDialog())
      {
        dialog.CheckFileExists = true;
        dialog.Filter = @"AntiMunchLite Save | *.amls";
        dialog.InitialDirectory = _GetSavesDirectory().ToString();

        return dialog.ShowDialog(_Parent) == DialogResult.OK
                 ? dialog.FileName
                 : null;
      }
    }

    #endregion


  }
}