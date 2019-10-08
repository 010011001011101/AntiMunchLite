using System;
using System.Threading;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public class AutoScroller
  {
    private const int ScrollsSpeed = 12;
    private const int ScrollsDelay = 50;

    private volatile State _State = State.Disable;

    public AutoScroller(FlowLayoutPanel scrollArea)
    {
      new Thread(_DoScroll).Start(scrollArea);
    }

    private void _DoScroll(object param)
    {
      if(!(param is FlowLayoutPanel scrollArea))
        return;

      while (!scrollArea.Disposing)
      {
        switch (_State)
        {
          case State.Up:
            InvokeScroll(-ScrollsSpeed);
            break;
          case State.Down:
            InvokeScroll(ScrollsSpeed);
            break;
        }

        Thread.Sleep(ScrollsDelay);
      }

      void InvokeScroll(int step)
      {
        if (scrollArea.InvokeRequired)
          scrollArea.Invoke((Action<object>) Scroll, step);
        else
          Scroll(step);
      }

      void Scroll(object step)
      {
        var newValue = scrollArea.VerticalScroll.Value + (int) step;
        newValue = Math.Min(scrollArea.VerticalScroll.Maximum, newValue);
        newValue = Math.Max(scrollArea.VerticalScroll.Minimum, newValue);

        scrollArea.VerticalScroll.Value = newValue;
      }
    }

    public void SetState(State state) => _State = state;

    public enum State
    {
      Up,
      Disable,
      Down
    }
  }
}