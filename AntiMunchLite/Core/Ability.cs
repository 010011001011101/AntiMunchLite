using System;

namespace AntiMunchLite.Core
{
  [Serializable]
  public class Ability
  {
    public string Name { get; set; }
    public int Remain { get; set; }
    public int Total { get; set; }

    public Ability Clone()
    {
      return new Ability
      {
        Name = Name,
        Remain = Remain,
        Total = Total
      };
    }
  }
}