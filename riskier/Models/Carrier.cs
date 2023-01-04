namespace riskier.Models;

public class Carrier : DbItem<int>
{
  public string OwnerId { get; set; }
  public Account Creator { get; set; }
  public int CarrierNumber { get; set; }
  public string UnitSlot1 { get; set; }
  public string UnitSlot2 { get; set; }
  public string UnitSlot3 { get; set; }
  public string UnitSlot4 { get; set; }
  public string UnitSlot5 { get; set; }
  public string UnitSlot6 { get; set; }
  public string UnitSlot7 { get; set; }
  public string UnitSlot8 { get; set; }
  public string GroundUnit1 { get; set; }
  public string GroundUnit2 { get; set; }
  public string GroundUnit3 { get; set; }
  public string GroundUnit4 { get; set; }
  public string GroundUnit5 { get; set; }
  public string GroundUnit6 { get; set; }
}