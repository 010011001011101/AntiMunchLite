using System;
using System.Drawing;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class EffectControl : UserControl
  {
    private bool _Inited;
    private readonly Action<Effect> _DeleteDelegate;
    public Effect Effect { get; private set; }


    public EffectControl()
    {
      InitializeComponent();
    }

    public EffectControl(Action<Effect> deleteDelegate) : this()
    {
      _DeleteDelegate = deleteDelegate;
    }

    public void Initialize(Effect effect)
    {
      if(Effect == null || Effect == effect) return;

      _Inited = false;

      Effect = effect;
      EffectName.Text = Effect.Name;
      RemainTime.Value = Effect.RemainTurns;

      EffectName.ForeColor =
      RemainTime.ForeColor = Effect.Type == EffectType.Buff ? Color.Black : Color.DarkRed;

      _Inited = true;
    }

    public void SetBackColor(Color color)
    {
      EffectName.BackColor = color;
    }

    private void EffectName_TextChanged(object sender, EventArgs e)
    {
      Width -= EffectName.Size.Width - EffectName.PreferredSize.Width;

      if (!_Inited) return;

      Effect.Name = EffectName.Text;
    }

    private void RemainTime_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Effect.RemainTurns = (int)RemainTime.Value;
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      _DeleteDelegate(Effect);
    }
  }
}
