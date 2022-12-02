namespace riskier.Models;

public class Destroyer : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 5;
  public int Industry { get; set; } = 4;
  public int Agriculture { get; set; } = 2;
}