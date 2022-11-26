namespace riskier.Models;

public class Account : DbItem<string>
{
  public string Name { get; set; }
  public string Email { get; set; }
  public string Picture { get; set; }
  public string TeamName { get; set; }
  public int TotalCapital { get; set; }
  public int TotalIndustry { get; set; }
  public int TotalAgriculture { get; set; }
}
