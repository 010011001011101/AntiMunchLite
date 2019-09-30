using System;
using System.Drawing;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite.Controls
{
  public partial class EffectControl : UserControl
  {
    private bool _Inited;
    public Effect Effect { get; private set; }

    #region Events

    public event Action<Effect> NeedDeleteEffect;
    private void _OnNeedDeleteCombatant(Effect effect) => NeedDeleteEffect?.Invoke(effect);

    #endregion


    public EffectControl()
    {
      InitializeComponent();
    }

    public void Initialize(Effect effect, Color backColor)
    {
      _Inited = false;

      Effect = effect;
      EffectName.Text = Effect.Name;
      RemainTime.Value = Effect.RemainTurns;

      EffectName.BackColor = backColor;
      EffectName.ForeColor =
      RemainTime.ForeColor = Effect.Type == EffectType.Buff ? Color.Black : Color.DarkRed;

      _Inited = true;
    }

    public void SetTextBackColor(Color backColor)
    {
      EffectName.BackColor = backColor;
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

      _OnNeedDeleteCombatant(Effect);
    }
  }
}
