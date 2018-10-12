using System;
using System.Collections.Generic;
using System.Drawing;
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

    private readonly CheckBox _DropInitiativeOnReset, _DropEffectsOnReset;


    public MainForm()
    {
      InitializeComponent();

      _SaveLoadManager = new SaveLoadManager(this);
      _CombatantControlsCache = new ControlsCache<CombatantControl>(MainFlow.Controls, _CreateCombatantControl);

      ToolBar.Items.AddRange(new[]
      {
        _CreateToolBarCheckBox(out _DropInitiativeOnReset, @"Drop Initiative", true),
        _CreateToolBarCheckBox(out _DropEffectsOnReset, @"Drop Effects", true)    
      });
    }

    private ToolStripItem _CreateToolBarCheckBox(out CheckBox dropEffectsOnReset, string text, bool initial)
    {
      dropEffectsOnReset = new CheckBox
      {
        Text = text,
        Anchor =  AnchorStyles.Left,
        BackColor = Color.Transparent,
        Checked = initial
      };

      dropEffectsOnReset.CheckedChanged += (s, e) => ToolBar.Focus();

      return new ToolStripControlHost(dropEffectsOnReset) {Margin = new Padding( 3, 3, 0, 2)};
    }

    private CombatantControl _CreateCombatantControl()
    {
      return new CombatantControl(_Core, _OnInitiativeChange, _OnEffectAdd, _OnDamage, _DeleteCombatant, _OnShiftStart, _OnShiftEnd);
    }

    public void RefreshCombatants(bool refreshCoreObject = false, bool forceInitiativeInit = false)
    {
      MainFlow.SuspendLayout();

      _CombatantControlsCache.AbjustSize(_Core.Combatants.Count());

      var current = _Core.GetCurrentCombatant();
      var combatants = _Core.Combatants.ToList();
      for (var i = 0; i < combatants.Count; ++i)
        _CombatantControlsCache[i].Initialize(combatants[i], combatants[i] == current, forceInitiativeInit);

      if (refreshCoreObject)
        foreach (var control in _CombatantControlsCache)
          control.ResetCore(_Core);

      RefreshCombatantsCollision();

      RoundLbl.Text = @"Round " + _Core.CurrentRound;

      _ControlsSizeRefresh();

      MainFlow.ResumeLayout();
    }

    public void RefreshCombatantsCollision()
    {
      var initiativeCollision = (from combatant in _Core.Combatants
                                 group combatant by new { combatant.Initiative, combatant.SubInitiative } into grp
                                 where grp.Count() > 1
                                 from combatant in grp
                                 select combatant
                                ).ToList();

      foreach (var combatantControl in _CombatantControlsCache)
        combatantControl.MarkInitiativeCollision(initiativeCollision.Contains(combatantControl.Combatant));
    }

    private int _GetCombatantControlsWidth()
    {
      return MainFlow.ClientRectangle.Width - 10;
    }

    private void _OnInitiativeChange()
    {
      if(_Core.Started)
        RefreshCombatants();
      else
        RefreshCombatantsCollision();
    }

    private void _OnEffectAdd(IEnumerable<Combatant> combatants)
    {
      foreach (var control in from cc in _CombatantControlsCache
                              join c in combatants on cc.Combatant equals c
                              select cc)
        control.RefreshEffects();
    }

    private void _OnDamage(IEnumerable<Combatant> combatants)
    {
      foreach (var control in from cc in _CombatantControlsCache
                              join c in combatants on cc.Combatant equals c
                              select cc)
        control.RefreshHp();
    }

    private void _DeleteCombatant(Combatant combatant)
    {
      _Core.RemoveCombatant(combatant);
      RefreshCombatants();
    }

    #region Shift Initiative

    private void _OnShiftStart()
    {
      foreach (var combatantControl in _CombatantControlsCache)
        combatantControl.OnShiftStart();
    }

    private void _OnShiftEnd()
    {
      var shiftFrom = (from combatantControl in _CombatantControlsCache
                       where combatantControl.ShiftMode == CombatantControl.ShiftInitiativeMode.ShiftFrom
                       select combatantControl.Combatant
                      ).FirstOrDefault();

      var shiftAfter = (from combatantControl in _CombatantControlsCache
                       where combatantControl.ShiftMode == CombatantControl.ShiftInitiativeMode.ShiftToAfter
                       select combatantControl.Combatant
                      ).FirstOrDefault();

      var shiftBefore = (from combatantControl in _CombatantControlsCache
                        where combatantControl.ShiftMode == CombatantControl.ShiftInitiativeMode.ShiftToBefore
                        select combatantControl.Combatant
                      ).FirstOrDefault();

      var shiftCanceled = false;
      if (shiftFrom != null && shiftAfter != null)
        _Core.ShiftInitiativeAfter(shiftFrom, shiftAfter);
      else if (shiftFrom != null && shiftBefore != null)
        _Core.ShiftInitiativeBefore(shiftFrom, shiftBefore);
      else
        shiftCanceled = true;

      foreach (var combatantControl in _CombatantControlsCache)
        combatantControl.OnShiftEnd(shiftCanceled);

      if(!shiftCanceled)
        RefreshCombatants(forceInitiativeInit: true);
    }

    #endregion

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
      if (_CombatantControlsCache == null) return;

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

      _Core.Reset(_DropInitiativeOnReset.Checked, _DropEffectsOnReset.Checked);
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
      RefreshCombatants(true);
    }

    private void LoadAddBtn_Click(object sender, EventArgs e)
    {
      var loaded = _SaveLoadManager.Load();
      if (loaded == null) return;

      _Core.Add(loaded);
      RefreshCombatants();
    }

    private void ShowPreGenEffects_Click(object sender, EventArgs e)
    {
      PreGenEffectsDialog.Show(_Core.PreGenEffects, this);
    }

  }
}
