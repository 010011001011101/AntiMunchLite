using System;
using System.Collections.Generic;
using System.Linq;

namespace AntiMunchLite.Core
{
  [Serializable]
  public class Combatant
  {
    public string Name { get; set; }
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }
    public int Initiative { get; set; }
    public int SubInitiative { get; set; }
    public string Comment { get; set; }

    public List<Effect> Effects { get; } = new List<Effect>();
    public List<Ability> Abilities { get; } = new List<Ability>();

    public bool ShowComment { get; set; }
    public bool ShowEffects { get; set; }
    public bool ShowAbilities { get; set; }

    private const float LightPercent = 60;
    private const float MediumPercent = 30;
    private const float HeavyPercent = 5;
    public HpStatus HpStatus
    {
      get
      {
        if (MaxHp <= 0) return HpStatus.Unknown;
        if (CurrentHp < 0) return HpStatus.BellowZero;
        if (CurrentHp >= MaxHp) return HpStatus.Uninjured;
        if (CurrentHp == 1) return HpStatus.Critical;

        var percent = (float) CurrentHp * 100 / MaxHp;

        if (percent > LightPercent) return HpStatus.Light;
        if (percent > MediumPercent) return HpStatus.Medium;
        if (percent > HeavyPercent) return HpStatus.Heavy;
        return HpStatus.Critical;
      }
    }

    public void OnNextRound()
    {
      Effects.RemoveAll(e => --e.RemainTurns <= 0);
    }

    public void OnReset(bool resetInitiatives, bool resetEffects)
    {
      if(resetInitiatives)
      {
        Initiative = 0;
        SubInitiative = 1;
      }

      if(resetEffects)
        Effects.Clear();
    }

    public override string ToString()
    {
      return Name;
    }

    public Combatant Clone(bool dropInit, bool dropHp)
    {
      var clone = new Combatant
      {
        Name = Name,
        Comment = Comment,
        ShowComment = ShowComment,
        ShowAbilities = ShowAbilities,
        ShowEffects = ShowEffects
      };
      clone.Effects.AddRange(Effects.Select(e => e.Clone()));
      clone.Abilities.AddRange(Abilities.Select(e => e.Clone()));

      if (!dropInit)
      {
        clone.Initiative = Initiative;
        clone.SubInitiative = SubInitiative;
      }

      if (!dropHp)
      {
        clone.CurrentHp = CurrentHp;
        clone.MaxHp = MaxHp;
      }

      return clone;
    }
  }
}