using System;
using System.Linq;
using System.Collections.Generic;

namespace AntiMunchLite.Core
{
  [Serializable]
  public class Core
  {
    public bool Started { get; private set; }
    public uint CurrentRound { get; private set; }
    public int CurrentInitiative { get; private set; }
    public uint CurrentSubInitiative { get; private set; }

    private readonly List<Combatant> _Combatants = new List<Combatant>();

    public Core()
    {
      Reset();
    }

    public void Reset()
    {
      Started = false;
      CurrentRound = 1;
      CurrentSubInitiative = 1;
      CurrentInitiative = int.MaxValue;
    }

    public void Next()
    {
      if (_Combatants.Count == 0) return;

      Started = true;
      var next = NextCombatant;
      if (next == null)
      {
        _SetNextRound();
        CurrentSubInitiative = 1;
        CurrentInitiative = int.MaxValue;
        Next();
      }
      else
      {
        var skipOne = CurrentInitiative != int.MaxValue && next == CurrentCombatant;

        CurrentSubInitiative = next.SubInitiative;
        CurrentInitiative = next.Initiative;

        if(skipOne) Next();
      }
    }

    public void NextRound()
    {
      if (_Combatants.Count == 0) return;

      if(!Started)
        Next();
      else
        _SetNextRound();
    }

    private void _SetNextRound()
    {
      ++CurrentRound;

      foreach (var combatant in Combatants)
        foreach (var effect in combatant.Effects.ToArray())
          if (--effect.RemainTurns <= 0)
            combatant.Effects.Remove(effect);
    }

    public void AddCombatant()
    {
      _Combatants.Add(new Combatant { Name = "<Name>", SubInitiative = 1});
    }

    public void RemoveCombatant(Combatant combatant)
    {
      _Combatants.Remove(combatant);
    }

    public Combatant CurrentCombatant
    {
      get
      {
        return (from combatant in _Combatants
                where Started &&
                      (combatant.Initiative < CurrentInitiative ||
                      (combatant.Initiative == CurrentInitiative && combatant.SubInitiative >= CurrentSubInitiative))
                orderby combatant.Initiative descending, combatant.SubInitiative
                select combatant
               ).FirstOrDefault();
      }
    }

    public Combatant NextCombatant
    {
      get
      {
        return (from combatant in _Combatants
                where Started &&
                      (combatant.Initiative < CurrentInitiative ||
                      (combatant.Initiative == CurrentInitiative && combatant.SubInitiative > CurrentSubInitiative))
                orderby combatant.Initiative descending, combatant.SubInitiative
                select combatant
               ).FirstOrDefault();
      }
    }


    public IEnumerable<Combatant> Combatants
    {
      get
      {
        return Started
          ? _Combatants.OrderByDescending(c => c.Initiative).ThenBy(c => c.SubInitiative)
          : _Combatants.AsEnumerable();
      }
    }
  }
}