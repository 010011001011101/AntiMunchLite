using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class EffectDialog : Form
  {
    public static Effect GetNewEffect(IWin32Window parent)
    {
      using (var dialog = new EffectDialog())
        return dialog.ShowDialog(parent) == DialogResult.OK
          ? dialog._CreateEffect()
          : null;
    }

    private Effect _CreateEffect()
    {
      return new Effect
      {
        Name = EffectName.Text,
        RemainTurns = (int) RemainTime.Value,
        Type = IsBuff.Checked ? EffectType.Buff : EffectType.Debuff
      };
    }

    public EffectDialog()
    {
      InitializeComponent();
    }
  }
}
