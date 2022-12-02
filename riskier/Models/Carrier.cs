namespace riskier.Models;

public class Carrier : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 6;
  public int Industry { get; set; } = 6;
  public int Agriculture { get; set; } = 6;
}