using System;

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
    
    public HpStatus HpStatus
    {
      get
      {
        if (MaxHp <= 0) return HpStatus.Unknown;
        if (CurrentHp < 0) return HpStatus.BellowZero;
        if (CurrentHp >= MaxHp) return HpStatus.Uninjured;

        var percent = (float) CurrentHp * 100 / MaxHp;

        if (percent > LightPercent) return HpStatus.Light;
        if (percent > MediumPercent) return HpStatus.Medium;
        if (percent > HeavyPercent) return HpStatus.Heavy;
        return HpStatus.Critical;
      }
    }
  }
}