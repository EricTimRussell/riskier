namespace riskier.Models;

public class NavalYard : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 2;
  public int Industry { get; set; } = 0;
  public int Agriculture { get; set; } = 2;
}