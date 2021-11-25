using System;
using System.Windows.Forms;

namespace AntiMunchLite
{
    static class Program
  {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
