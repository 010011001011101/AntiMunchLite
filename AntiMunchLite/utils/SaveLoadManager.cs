using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public class SaveLoadManager(IWin32Window parent)
  {
    private const string SaveFilesExtension = "amls";

    private readonly IWin32Window _Parent = parent;
    private readonly JsonSerializerOptions _Options = new(JsonSerializerDefaults.General)
    {
      WriteIndented = true
    };

    public async Task SaveAsync(Core.Core core)
    {
      try
      {
        await _Save(core);
      }
      catch (Exception e)
      {
        MessageBox.Show(_Parent, e.Message, @"Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        MessageBox.Show(_Parent, e.Message, @"Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return null;
      }
    }

    private async Task _Save(Core.Core core)
    {
      using var dialog = new SaveFileDialog
      {
        FileName = $"Save_R{core.CurrentRound}_[{DateTime.Now:MM.dd.yy H.mm.ss}].{SaveFilesExtension}",
        Filter = $"AntiMunchLite Save | *.{SaveFilesExtension}",
        RestoreDirectory = true
      };

      if (dialog.ShowDialog(_Parent) == DialogResult.OK)
      {
        await using var fileStream = File.Create(dialog.FileName);
        await JsonSerializer.SerializeAsync(fileStream, core, _Options);
      }
    }

    private Core.Core _Load()
    {
      using var dialog = new OpenFileDialog
      {
        CheckFileExists = true,
        Filter = $"AntiMunchLite Save | *.{SaveFilesExtension}",
        RestoreDirectory = true
      };

      if (dialog.ShowDialog(_Parent) == DialogResult.OK)
      {
        var serializedStr = File.ReadAllText(dialog.FileName);
        return JsonSerializer.Deserialize<Core.Core>(serializedStr);
      }

      return null;
    }
  }
}