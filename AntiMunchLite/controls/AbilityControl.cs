using System;
using System.Drawing;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite.Controls
{
  public partial class AbilityControl : UserControl
  {
    private bool _Inited;
    public Ability Ability { get; private set; }

    #region Events

    public event Action<Ability> NeedDeleteAbility;
    private void _OnNeedDeleteAbility(Ability ability) => NeedDeleteAbility?.Invoke(ability);

    #endregion

    public AbilityControl()
    {
      InitializeComponent();
    }

    public void Initialize(Ability ability, Color backColor)
    {
      _Inited = false;

      Ability = ability;
      AbilityNameTB.Text = Ability.Name;
      RemainNum.Value = Ability.Remain;
      TotalNum.Value = Ability.Total;

      SetTextBackColor(backColor);
      ControlsUtils.SubscribeOnChildDragOver(this, (s, e) => OnDragOver(e));

      _Inited = true;
    }

    public void SetTextBackColor(Color backColor)
    {
      AbilityNameTB.BackColor = backColor;
    }

    private void SpendOneBtn_Click(object sender, EventArgs e)
    {
      RemainNum.Value = RemainNum.Value - 1;
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      if (!_Inited) return;

      _OnNeedDeleteAbility(Ability);
    }

    private void AbilityNameTB_TextChanged(object sender, EventArgs e)
    {
      Width -= AbilityNameTB.Size.Width - AbilityNameTB.PreferredSize.Width;

      if (!_Inited) return;

      Ability.Name = AbilityNameTB.Text;
    }

    private void RemainNum_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Ability.Remain = (int)RemainNum.Value;
    }

    private void TotalNum_ValueChanged(object sender, EventArgs e)
    {
      if (!_Inited) return;

      Ability.Total = (int)TotalNum.Value;
    }
  }
}
