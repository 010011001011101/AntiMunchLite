using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite.Dialogs
{
  public partial class EffectDialog : Form
  {
    private readonly Core.Core _Core;

    public static List<Combatant> CreateEffect(Core.Core core, Combatant combatant, IWin32Window parent)
    {
      using (var dialog = new EffectDialog(core, combatant))
        return dialog.ShowDialog(parent) == DialogResult.OK
          ? dialog._CreateEffect().ToList()
          : new List<Combatant>();
    }

    private IEnumerable<Combatant> _CreateEffect()
    {
      if (Combotants.CheckedItems.Count == 0)
        yield break;

      if (!_Core.PreGenEffects.Contains(EffectName.Text))
        _Core.PreGenEffects.Add(EffectName.Text);

      foreach (Combatant combatant in Combotants.CheckedItems)
      {
        combatant.Effects.Add(new Effect
        {
          Name = EffectName.Text,
          RemainTurns = _GetTime(),
          Type = IsBuff.Checked ? EffectType.Buff : EffectType.Debuff
        });
        combatant.ShowEffects = true;

        yield return combatant;
      }
    }

    private int _GetTime()
    {
      var remain = (int) RemainTime.Value;

      if (MinuteTime.Checked)
        return remain * 10;

      if (TenMinutesTime.Checked)
        return remain * 10 * 10;

      if (HourTime.Checked)
        return remain * 10 * 60;

      return remain;
    }

    public EffectDialog(Core.Core core, Combatant combatant)
    {
      _Core = core;

      InitializeComponent();

      EffectName.Items.AddRange(_Core.PreGenEffects.Cast<object>().ToArray());
      var allCombatants = _Core.Combatants.OrderBy(c => c.Name).ToList();
      Combotants.Items.AddRange(allCombatants.Cast<object>().ToArray());
      Combotants.SetItemChecked(allCombatants.IndexOf(combatant), true);
    }
  }
}
