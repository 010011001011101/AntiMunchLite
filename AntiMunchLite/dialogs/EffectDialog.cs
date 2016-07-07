using System.Collections.Generic;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class EffectDialog : Form
  {
    private readonly List<string> _PreGenEffects;

    public static Effect GetNewEffect(List<string> preGenEffects, IWin32Window parent)
    {
      using (var dialog = new EffectDialog(preGenEffects))
        return dialog.ShowDialog(parent) == DialogResult.OK
          ? dialog._CreateEffect()
          : null;
    }

    private Effect _CreateEffect()
    {
      if (!_PreGenEffects.Contains(EffectName.Text))
        _PreGenEffects.Add(EffectName.Text);

      return new Effect
      {
        Name = EffectName.Text,
        RemainTurns = (int) RemainTime.Value,
        Type = IsBuff.Checked ? EffectType.Buff : EffectType.Debuff
      };
    }

    public EffectDialog(List<string> preGenEffects)
    {
      _PreGenEffects = preGenEffects;

      InitializeComponent();

      EffectName.Items.AddRange(_PreGenEffects.ToArray());
    }
  }
}
