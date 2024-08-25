using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;
using AntiMunchLite.Dialogs;

namespace AntiMunchLite
{
  public partial class DmgDialog : Form
  {
    public static IEnumerable<Combatant> MakeDamage(Core.Core core, Combatant combatant, bool heal, IWin32Window parent)
    {
      using var dialog = new DmgDialog(core, combatant, heal);

      return dialog.ShowDialog(parent) == DialogResult.OK
        ? dialog._MakeDamage().ToArray()
        : [];
    }

    public DmgDialog(Core.Core core, Combatant selectedCombatant, bool heal)
    {
      InitializeComponent();

      IsHeal.Checked = heal;

      foreach (var combatant in core.Combatants.OrderBy(c => c.Name))
      {
        var itemControl = new DmgDialogCombatantItem
        {
          TabStop = false,
          Margin = new Padding(3, 1, 3, 1)
        };
        itemControl.Initialize(combatant, combatant == selectedCombatant);
        CombotantsFlow.Controls.Add(itemControl);
      }

      _ControlsSizeRefresh();
    }

    private void _ControlsSizeRefresh()
    {
      var controls = CombotantsFlow.Controls.OfType<DmgDialogCombatantItem>().ToArray();
      if (controls.Length == 0)
        return;

      var newWidth = CombotantsFlow.Width - controls[0].Margin.Left - controls[0].Margin.Right;
      if (CombotantsFlow.VerticalScroll.Visible)
        newWidth -= SystemInformation.VerticalScrollBarWidth;

      foreach (var control in controls)
        control.Width = newWidth;

      LabelTable.ColumnStyles[LabelTable.ColumnCount - 1].Width = -(newWidth - CombotantsFlow.Width);
    }

    private void DMGDialog_Load(object sender, EventArgs e)
    {
      DmgCounter.Focus();
      DmgCounter.Select(0, 1);
    }

    private IEnumerable<Combatant> _MakeDamage()
    {
      var value = DmgCounter.Value;
      if (value <= 0) yield break;

      foreach (var itemControl in CombotantsFlow.Controls.OfType<DmgDialogCombatantItem>())
      {
        if (IsHeal.Checked && itemControl.ApplyHeal(value, NoOverheal.Checked) ||
            !IsHeal.Checked && itemControl.ApplyDmg(value))
          yield return itemControl.Combatant;
      }
    }

    private void DmgDialog_Resize(object sender, EventArgs e)
    {
      _ControlsSizeRefresh();
    }

    private void IsHeal_CheckedChanged(object sender, EventArgs e)
    {
      NoOverheal.Visible = IsHeal.Checked;
    }

    private void RollB_Click(object sender, EventArgs e)
    {
      RollResultT.Text = $"{DmgCounter.Value / 2}[X/2]; {DmgCounter.Value}[X]; {DmgCounter.Value * 2}[2X]: {DmgCounter.ParseDescription}";
    }
  }
}
