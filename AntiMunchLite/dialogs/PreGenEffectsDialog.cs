using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public partial class PreGenEffectsDialog : Form
  {
    private readonly List<string> _PreGenEffects;


    public static void Show(List<string> preGenEffects, IWin32Window parent)
    {
      using (var dialog = new PreGenEffectsDialog(preGenEffects))
        dialog.ShowDialog(parent);
    }

    public PreGenEffectsDialog()
    {
      InitializeComponent();
    }

    public PreGenEffectsDialog(List<string> preGenEffects) : this()
    {
      _PreGenEffects = preGenEffects;

      _Apply();
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(NewEffectName.Text) ||
          _PreGenEffects.Contains(NewEffectName.Text))
        return;

      _PreGenEffects.Add(NewEffectName.Text);
      _Apply();
    }

    private void DelBtn_Click(object sender, EventArgs e)
    {
      foreach (string effect in PreGenEffects.CheckedItems)
        _PreGenEffects.Remove(effect);

      _Apply();
    }

    private void _Apply()
    {
      PreGenEffects.Items.Clear();
      PreGenEffects.Items.AddRange(_PreGenEffects.ToArray());
    }
  }
}
