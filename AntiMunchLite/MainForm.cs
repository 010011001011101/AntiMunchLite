using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntiMunchLite.Controls;
using AntiMunchLite.Core;
using AntiMunchLite.Dialogs;

namespace AntiMunchLite
{
  public partial class MainForm : Form
  {
    private readonly SaveLoadManager _SaveLoadManager;
    private readonly ControlsCache<CombatantControl> _CombatantControlsCache;
    public Core.Core Core { get; private set; } = new Core.Core();


    public MainForm()
    {
      InitializeComponent();

      _SaveLoadManager = new SaveLoadManager(this);
      _CombatantControlsCache = new ControlsCache<CombatantControl>(MainFlow.Controls, _CreateCombatantControl);
    }

    private CombatantControl _CreateCombatantControl()
    {
      var newControl = new CombatantControl();
      newControl.InitiativeChange += _OnInitiativeChange;
      newControl.Damage += _OnDamage;
      newControl.AbilityAdd += _OnAbilityAdd;
      newControl.EffectAdd += _OnEffectAdd;
      newControl.NeedDeleteCombatant += _OnNeedDeleteCombatant;
      newControl.ManualResize += _OnManualResize;
      newControl.ShiftStart += _OnShiftStart;
      newControl.ShiftEnd += _OnShiftEnd;

      return newControl;
    }

    public void RefreshCombatants(bool forceInitiativeInit = false)
    {
      MainFlow.SuspendLayout();

      ColorUtils.ResetBackColorAlternation();
      _CombatantControlsCache.AbjustSize(Core.Combatants.Count());

      var current = Core.GetCurrentCombatant();
      var combatants = Core.Combatants.ToList();
      for (var i = 0; i < combatants.Count; ++i)
        _CombatantControlsCache[i].Initialize(Core, combatants[i], combatants[i] == current, forceInitiativeInit);

      RefreshCombatantsCollision();

      RoundLbl.Text = @"Round " + Core.CurrentRound;

      _ControlsSizeRefresh();

      MainFlow.ResumeLayout();
    }

    public void RefreshCombatantsCollision()
    {
      var initiativeCollision = (from combatant in Core.Combatants
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

    #region Handlers

    private void _OnInitiativeChange()
    {
      if (Core.Started)
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

    private void _OnAbilityAdd(IEnumerable<Combatant> combatants)
    {
      foreach (var control in from cc in _CombatantControlsCache
                              join c in combatants on cc.Combatant equals c
                              select cc)
        control.RefreshAbilities();
    }

    private void _OnDamage(IEnumerable<Combatant> combatants)
    {
      foreach (var control in from cc in _CombatantControlsCache
                              join c in combatants on cc.Combatant equals c
                              select cc)
        control.RefreshHp();
    }

    private void _OnManualResize()
    {
      _FixCombatantControlsWidth();
    }

    private void _OnNeedDeleteCombatant(Combatant combatant)
    {
      Core.RemoveCombatant(combatant);
      RefreshCombatants();
    }

    #endregion

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
        Core.ShiftInitiativeAfter(shiftFrom, shiftAfter);
      else if (shiftFrom != null && shiftBefore != null)
        Core.ShiftInitiativeBefore(shiftFrom, shiftBefore);
      else
        shiftCanceled = true;

      foreach (var combatantControl in _CombatantControlsCache)
        combatantControl.OnShiftEnd(shiftCanceled);

      if(!shiftCanceled)
        RefreshCombatants(true);
    }

    #endregion

    private void AddBtn_Click(object sender, EventArgs e)
    {
      Core.AddCombatant();
      RefreshCombatants();
    }

    private void CloneBtn_Click(object sender, EventArgs e)
    {
      if (CloneDialog.ResetEncounter(Core, this))
        RefreshCombatants();
    }

    private void NextBtn_Click(object sender, EventArgs e)
    {
      Core.Next();
      RefreshCombatants();
    }

    private void NextRoundBtn_Click(object sender, EventArgs e)
    {
      Core.NextRound();
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

      foreach (var control in _CombatantControlsCache)
        control.RefreshSize();

      _FixCombatantControlsWidth();
    }

    private void _FixCombatantControlsWidth()
    {
      if (_CombatantControlsCache == null) return;

      var newWidth = _GetCombatantControlsWidth();
      foreach (var control in _CombatantControlsCache)
        control.Width = newWidth;
    }

    private void ResetBtn_Click(object sender, EventArgs e)
    {
      if (ResetDialog.ResetEncounter(Core, this))
        RefreshCombatants(true);
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
      _SaveLoadManager.Save(Core);
    }

    private void OpenBtn_Click(object sender, EventArgs e)
    {
      var loaded = _SaveLoadManager.Load();
      if (loaded == null) return;

      Core = loaded;
      RefreshCombatants();
    }

    private void LoadAddBtn_Click(object sender, EventArgs e)
    {
      var loaded = _SaveLoadManager.Load();
      if (loaded == null) return;

      Core.Add(loaded);
      RefreshCombatants();
    }

    private void AbilitiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PreGenAbilitiesDialog.Show(Core.PreGenAbilities, this);
    }

    private void ShowPreGenEffects_Click(object sender, EventArgs e)
    {
      PreGenEffectsDialog.Show(Core.PreGenEffects, this);
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control)
        switch (e.KeyCode)
        {
          case Keys.A:
            AddBtn.PerformClick();
            break;
          case Keys.P:
            CloneBtn.PerformClick();
            break;
          case Keys.N:
            NextBtn.PerformClick();
            break;
          case Keys.R:
            ResetBtn.PerformClick();
            break;
          case Keys.D:
            OnCurrentCombatantControl(c => c.ShowDamageDialog());
            break;
          case Keys.H:
            OnCurrentCombatantControl(c => c.ShowHealDialog());
            break;
          case Keys.E:
            OnCurrentCombatantControl(c => c.ShowAddEffectDialog());
            break;
        }

      void OnCurrentCombatantControl(Action<CombatantControl> action)
      {
        var currentControl = _CombatantControlsCache.FirstOrDefault(c => c.IsCurrent);
        if (currentControl != null)
          action(currentControl);
      }
    }
  }
}
