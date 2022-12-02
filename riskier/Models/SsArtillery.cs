namespace riskier.Models;

public class SsArtillery : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 1;
  public int Industry { get; set; } = 4;
  public int Agriculture { get; set; } = 0;
}