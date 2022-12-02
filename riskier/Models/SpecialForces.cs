namespace riskier.Models;

public class SpecialForces : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 3;
  public int Industry { get; set; } = 1;
  public int Agriculture { get; set; } = 3;
}
