namespace riskier.Models;

public class Profile : DbItem<string>
{
  public string Name { get; set; }
  public string Picture { get; set; }
  public string TeamName { get; set; } = "Team Name";
  public int TotalCapital { get; set; } = 40;
  public int TotalIndustry { get; set; } = 40;
  public int TotalAgriculture { get; set; } = 40;
}