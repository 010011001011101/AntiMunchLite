using System;

namespace AntiMunchLite.Core
{
  [Serializable]
  public class Effect
  {
    public string Name { get; set; }
    public int RemainTurns { get; set; }
    public EffectType Type { get; set; }

    public Effect Clone()
    {
      return new Effect
      {
        Name = Name,
        RemainTurns = RemainTurns,
        Type = Type
      };
    }
  }
}