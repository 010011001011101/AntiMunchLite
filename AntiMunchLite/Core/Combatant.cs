namespace AntiMunchLite.Core
{
  public class Combatant
  {
    public string Name { get; set; }
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }
    public decimal Initiative { get; set; }
    
    public HpStatus HpStatus
    {
      get
      {
        if (MaxHp <= 0) return HpStatus.Unknown;
        if (CurrentHp < 0) return HpStatus.BellowZero;
        if (CurrentHp >= MaxHp) return HpStatus.Uninjured;

        var percent = (float) CurrentHp*100/MaxHp;

        if (percent > 60) return HpStatus.Light;
        if (percent > 30) return HpStatus.Medium;
        if (percent > 5) return HpStatus.Heavy;
        return HpStatus.Critical;
      }
    }
  }
}