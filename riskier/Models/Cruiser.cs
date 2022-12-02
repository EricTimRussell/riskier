namespace riskier.Models;

public class Cruiser : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 5;
  public int Industry { get; set; } = 5;
  public int Agriculture { get; set; } = 2;
}