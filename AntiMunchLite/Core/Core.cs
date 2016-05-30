using System.Linq;
using System.Collections.Generic;

namespace AntiMunchLite.Core
{
  public class Core
  {
    public bool Started { get; private set; }
    public uint CurrentRound { get; private set; }
    public decimal CurrentInitiative { get; private set; }

    private readonly List<Combatant> _Combatants = new List<Combatant>();

    public Core()
    {
      CurrentRound = 1;
      CurrentInitiative = decimal.MaxValue;
    }

    public void Next()
    {
      if (_Combatants.Count == 0) return;

      Started = true;
      var next = NextCombatant;
      if (next == null)
      {
        ++CurrentRound;
        CurrentInitiative = decimal.MaxValue;
        Next();
      }
      else
        CurrentInitiative = next.Initiative;
    }

    public void AddCombatant()
    {
      _Combatants.Add(new Combatant { Name = "<Name>" });
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
                where Started && combatant.Initiative <= CurrentInitiative
                orderby combatant.Initiative descending
                select combatant
               ).FirstOrDefault();
      }
    }

    public Combatant NextCombatant
    {
      get
      {
        return (from combatant in _Combatants
                where Started && combatant.Initiative < CurrentInitiative
                orderby combatant.Initiative descending
                select combatant
               ).FirstOrDefault();
      }
    }


    public IEnumerable<Combatant> Combatants
    {
      get
      {
        return Started
          ? _Combatants.OrderByDescending(c => c.Initiative)
          : _Combatants.AsEnumerable();
      }
    }
  }
}