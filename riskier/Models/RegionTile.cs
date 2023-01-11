namespace riskier.Models;

public class RegionTile : DbItem<int>
{
  public string OwnerId { get; set; }
  public Account Creator { get; set; }
  public int RegionNumber { get; set; }
  public int Capital { get; set; }
  public int Industry { get; set; }
  public int Agriculture { get; set; }
  public int Production { get; set; }
}
