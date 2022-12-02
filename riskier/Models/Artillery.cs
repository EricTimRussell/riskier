namespace riskier.Models;

public class Artillery : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 1;
  public int Industry { get; set; } = 3;
  public int Agriculture { get; set; } = 0;
}