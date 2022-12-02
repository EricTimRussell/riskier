namespace riskier.Models;

public class Ifv : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 3;
  public int Industry { get; set; } = 3;
  public int Agriculture { get; set; } = 1;
}