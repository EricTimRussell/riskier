namespace riskier.Models;

public class Warehouse : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 1;
  public int Industry { get; set; } = 0;
  public int Agriculture { get; set; } = 3;
}