using System;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class MainForm : Form
  {
    private readonly Core.Core _Core = new Core.Core();


    public MainForm()
    {
      InitializeComponent();
    }

    public void RefreshCombatants()
    {
      MainFlow.SuspendLayout();
      MainFlow.Controls.Clear();

      var current = _Core.CurrentCombatant;
      foreach (var combatant in _Core.Combatants)
        MainFlow.Controls.Add(
          new CombatantControl(combatant, combatant == current, _OnInitiativeChange, _DeleteCombatant));

      RoundLbl.Text = @"Round " + _Core.CurrentRound;
      _ControlsSizeRefresh();

      MainFlow.ResumeLayout();
    }

    private int _GetCombatantControlsWidth()
    {
      return MainFlow.ClientRectangle.Width - 10;
    }

    private void _OnInitiativeChange()
    {
      if(_Core.Started)
        RefreshCombatants();
    }

    private void _DeleteCombatant(Combatant combatant)
    {
      _Core.RemoveCombatant(combatant);
      RefreshCombatants();
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
      _Core.AddCombatant();
      RefreshCombatants();
    }

    private void NextBtn_Click(object sender, EventArgs e)
    {
      _Core.Next();
      RefreshCombatants();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      RefreshCombatants();
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
      _ControlsSizeRefresh();
    }

    private void _ControlsSizeRefresh()
    {
      foreach (Control control in MainFlow.Controls)
        control.Width = _GetCombatantControlsWidth();
    }

    private void ResetBtn_Click(object sender, EventArgs e)
    {
      if (_Core.Started && 
          DialogResult.Yes != MessageBox.Show(@"Confirm Encounter Reset", @"Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
        return;

      _Core.Reset();
      RefreshCombatants();
    }
  }
}
