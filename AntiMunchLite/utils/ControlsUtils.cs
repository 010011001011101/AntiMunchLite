using System;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public static class ControlsUtils
  {
    public static void SubscribeOnChildDragOver(Control control, DragEventHandler handler)
    {
      foreach (Control subControl in control.Controls)
      {
        subControl.DragOver += handler;
        SubscribeOnChildDragOver(subControl, handler);
      }
    }
  }
}