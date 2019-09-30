using System.Drawing;
using System.Threading;

namespace AntiMunchLite
{
  public static class ColorUtils
  {
    public static readonly Color Green = Color.FromArgb(202, 245, 199);
    public static readonly Color Red = Color.FromArgb(255, 211, 210);
    public static readonly Color Yellow1 = Color.FromArgb(255, 255, 221);
    public static readonly Color Yellow2 = Color.FromArgb(245, 245, 211);

    private static int _AltFlag;
    public static Color GetBackColor(bool isCurrent)
    {
      if (Interlocked.CompareExchange(ref _AltFlag, 1, 0) == 0)
        return isCurrent ? Green : Yellow1;

      Interlocked.Decrement(ref _AltFlag);
      return isCurrent ? Green : Yellow2;
    }

    public static void ResetBackColorAlternation()
    {
      Interlocked.Exchange(ref _AltFlag, 0);
    }
  }
}