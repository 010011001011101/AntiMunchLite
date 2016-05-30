using System.Drawing;

namespace AntiMunchLite.Core
{
  public enum HpStatus
  {
    Unknown,
    Uninjured,
    Light,
    Medium,
    Heavy,
    Critical,
    BellowZero
  }

  public static class HpStatusUtils
  {
    public static Color ToColor(this HpStatus status)
    {
      switch (status)
        {
        case HpStatus.Uninjured:
        case HpStatus.Light:
          return Color.DarkGreen;
        case HpStatus.Medium:
          return Color.DarkOrange;
        case HpStatus.Heavy:
        case HpStatus.Critical:
          return Color.Red;
        case HpStatus.BellowZero:
          return Color.Purple;
        default:
          return Color.Black;
      }
    }
  }
}