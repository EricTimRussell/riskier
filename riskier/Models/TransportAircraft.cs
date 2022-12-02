namespace riskier.Models;

public class TransportAircraft : DbItem<int>
{
  public string OwnerId { get; set; }
  public int Capital { get; set; } = 1;
  public int Industry { get; set; } = 1;
  public int Agriculture { get; set; } = 0;
}