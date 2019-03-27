using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public partial class PreGenAbilitiesDialog : Form
  {
    private readonly List<string> _PreGenAbilities;


    public static void Show(List<string> preGenAbilities, IWin32Window parent)
    {
      using (var dialog = new PreGenAbilitiesDialog(preGenAbilities))
        dialog.ShowDialog(parent);
    }

    public PreGenAbilitiesDialog()
    {
      InitializeComponent();
    }

    public PreGenAbilitiesDialog(List<string> preGenAbilities) : this()
    {
      _PreGenAbilities = preGenAbilities;

      _Apply();
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(NewAbilityName.Text) ||
          _PreGenAbilities.Contains(NewAbilityName.Text))
        return;

      _PreGenAbilities.Add(NewAbilityName.Text);
      _Apply();
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      foreach (string effect in PreGenAbilities.CheckedItems)
        _PreGenAbilities.Remove(effect);

      _Apply();
    }

    private void _Apply()
    {
      PreGenAbilities.Items.Clear();
      PreGenAbilities.Items.AddRange(_PreGenAbilities.Cast<object>().ToArray());
    }
  }
}
