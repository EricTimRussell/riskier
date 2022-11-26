namespace riskier.Models;

public class RegionTile : DbItem<int>
{
  public string OwnerId { get; set; }
  public Account Creator { get; set; }
  public string OwnedBy { get; set; }
  public int Capital { get; set; }
  public int Industry { get; set; }
  public int Agriculture { get; set; }
  public string Environment { get; set; }
}
