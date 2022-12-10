namespace riskier.Models;

public class Division : DbItem<int>
{
  public string OwnerId { get; set; }
  public Account Creator { get; set; }
  public string UnitSlot1 { get; set; }
  public string UnitSlot2 { get; set; }
  public string UnitSlot3 { get; set; }
  public string UnitSlot4 { get; set; }
  public string UnitSlot5 { get; set; }
  public string UnitSlot6 { get; set; }
}