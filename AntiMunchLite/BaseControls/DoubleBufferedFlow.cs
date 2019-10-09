using System.Windows.Forms;

namespace AntiMunchLite.BaseControls
{
  public class DoubleBufferedFlow : FlowLayoutPanel
  {
    public DoubleBufferedFlow()
    {
      DoubleBuffered = true;
    }
  }
}