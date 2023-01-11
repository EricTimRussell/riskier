namespace riskier.Models;

public class Profile : DbItem<string>
{
  public string Name { get; set; }
  public string Picture { get; set; }
  public string TeamName { get; set; } = "Team Name";
  public int TotalCapital { get; set; }
  public int TotalIndustry { get; set; }
  public int TotalAgriculture { get; set; }
  public int TotalProduction { get; set; }
  public int Infantry { get; set; } = 0;
  public int SpecialForces { get; set; } = 0;
  public int Mech { get; set; } = 0;
  public int Ifv { get; set; } = 0;
  public int Mbt { get; set; } = 0;
  public int Artillery { get; set; } = 0;
  public int SsArtillery { get; set; } = 0;
  public int AntiAircraft { get; set; } = 0;
  public int SupplyTruck { get; set; } = 0;
  public int FighterAircraft { get; set; } = 0;
  public int CloseAirSupport { get; set; } = 0;
  public int Carrier { get; set; } = 0;
  public int Cruiser { get; set; } = 0;
  public int Destroyer { get; set; } = 0;
  public int TransportAircraft { get; set; } = 0;
  public int Airfield { get; set; } = 0;
  public int NavalYard { get; set; } = 0;
  public int Warehouse { get; set; } = 0;
  public int Factory { get; set; } = 0;
}