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

    public static void InSuspendLayout(Control topControl, Action action, bool isSuspended = false)
    {
      if (isSuspended)
      {
        action();
        return;
      }

      SuspendLayout(topControl);
      try
      {
        action();
      }
      finally
      {
        ResumeLayout(topControl);
      }
    }

    public static void SuspendLayout(Control control)
    {
      var tempSuspendFlag = false;
      SuspendLayout(control, ref tempSuspendFlag);
    }

    public static void SuspendLayout(Control control, ref bool isSuspended)
    {
      if (isSuspended) return;

      control.SuspendLayout();
      foreach (Control subControl in control.Controls)
        SuspendLayout(subControl);

      isSuspended = true;
    }

    public static void ResumeLayout(Control control)
    {
      var tempSuspendFlag = true;
      ResumeLayout(control, ref tempSuspendFlag);
    }

    public static void ResumeLayout(Control control, ref bool isSuspended)
    {
      if (!isSuspended) return;

      control.ResumeLayout();
      foreach (Control subControl in control.Controls)
        ResumeLayout(subControl);

      isSuspended = false;
    }
  }
}