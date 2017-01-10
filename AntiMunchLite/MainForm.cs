using System;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Core;

namespace AntiMunchLite
{
  public partial class MainForm : Form
  {
    private readonly SaveLoadManager _SaveLoadManager;
    private readonly ControlsCache<CombatantControl> _CombatantControlsCache;
    private Core.Core _Core = new Core.Core();


    public MainForm()
    {
      InitializeComponent();

      _SaveLoadManager = new SaveLoadManager(this);
      _CombatantControlsCache = new ControlsCache<CombatantControl>(MainFlow.Controls, _CreateCombatantControl);
    }

    private CombatantControl _CreateCombatantControl()
    {
      return new CombatantControl(_Core, _OnInitiativeChange, _DeleteCombatant);
    }

    public void RefreshCombatants()
    {
      MainFlow.SuspendLayout();

      _CombatantControlsCache.AbjustSize(_Core.Combatants.Count());

      var current = _Core.CurrentCombatant;
      var combatants = _Core.Combatants.ToList();
      for (var i = 0; i < combatants.Count; ++i)
        _CombatantControlsCache[i].Initialize(combatants[i], combatants[i] == current);

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
      var newWidth = _GetCombatantControlsWidth();
      foreach (var control in _CombatantControlsCache)
      {
        control.Width = newWidth;
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
      var loaded = _SaveLoadManager.Load();
      if (loaded == null) return;

      _Core = loaded;
      RefreshCombatants();
    }

    private void ShowPreGenEffects_Click(object sender, EventArgs e)
    {
      PreGenEffectsDialog.Show(_Core.PreGenEffects, this);
    }
  }
}
