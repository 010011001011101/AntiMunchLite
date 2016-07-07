using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class MainForm : Form
  {
    private readonly SaveLoadManager _SaveLoadManager;
    private Core.Core _Core = new Core.Core();

    private readonly List<CombatantControl> _ControlsCache = new List<CombatantControl>();


    public MainForm()
    {
      _SaveLoadManager = new SaveLoadManager(this);
      InitializeComponent();
    }

    public void RefreshCombatants()
    {
      MainFlow.SuspendLayout();

      _AbjustCacheSize();

      var current = _Core.CurrentCombatant;
      var combatants = _Core.Combatants.ToList();
      for (var i = 0; i < combatants.Count; ++i)
        _ControlsCache[i].Initialize(combatants[i], combatants[i] == current);

      RoundLbl.Text = @"Round " + _Core.CurrentRound;

      _ControlsSizeRefresh();
      MainFlow.ResumeLayout();
    }

    private void _AbjustCacheSize()
    {
      var currentSize = _ControlsCache.Count;
      var newSize = _Core.Combatants.Count();

      if(currentSize > newSize)
        foreach (var controlToDelete in _ControlsCache.Take(currentSize - newSize).ToList())
        {
          _ControlsCache.Remove(controlToDelete);
          MainFlow.Controls.Remove(controlToDelete);
          controlToDelete.Dispose();
        }

      if(currentSize < newSize)
        foreach (var i in Enumerable.Range(0, newSize - currentSize))
        {
          var newControl = new CombatantControl(_Core, _OnInitiativeChange, _DeleteCombatant);
          _ControlsCache.Add(newControl);
          MainFlow.Controls.Add(newControl);
        }
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

    private void NextRoundBtn_Click(object sender, EventArgs e)
    {
      _Core.NextRound();
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
      foreach (var control in _ControlsCache)
      {
        control.Width = _GetCombatantControlsWidth();
        control.RefreshSize();
      }
    }

    private void ResetBtn_Click(object sender, EventArgs e)
    {
      if (_Core.Started && 
          DialogResult.Yes != MessageBox.Show(@"Confirm Encounter Reset", @"Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
        return;

      _Core.Reset();
      RefreshCombatants();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
      _SaveLoadManager.Save(_Core);
    }

    private void LoadBtn_Click(object sender, EventArgs e)
    {
      if(_SaveLoadManager.Load(ref _Core))
        RefreshCombatants();
    }

    private void ShowPreGenEffects_Click(object sender, EventArgs e)
    {
      PreGenEffectsDialog.Show(_Core.PreGenEffects, this);
    }
  }
}
