namespace riskier.Models;

public class Profile : DbItem<string>
{
  public string Name { get; set; }
  public string Picture { get; set; }
  public string TeamName { get; set; }
  public int TotalCapital { get; set; }
  public int TotalIndustry { get; set; }
  public int TotalAgriculture { get; set; }
}