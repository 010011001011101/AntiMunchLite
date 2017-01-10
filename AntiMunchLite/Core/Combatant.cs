using System;
using System.Collections.Generic;

namespace AntiMunchLite.Core
{
  [Serializable]
  public class Combatant
  {
    private const float LightPercent = 60;
    private const float MediumPercent = 30;
    private const float HeavyPercent = 5; 

    public string Name { get; set; }
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }
    public int Initiative { get; set; }
    public uint SubInitiative { get; set; }

    public List<Effect> Effects { get; set; }

    public Combatant()
    {
      Effects = new List<Effect>();
    }

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
  }
}