namespace riskier.Models;

public class Asset : DbItem<int>
{
  public string OwnerId { get; set; }
  public Account Creator { get; set; }
  public int Infantry { get; set; }
  public int EliteInfantry { get; set; }
  public int Mech { get; set; }
  public int Ifv { get; set; }
  public int Mbt { get; set; }
  public int Artillery { get; set; }
  public int SsArtillery { get; set; }
  public int AntiAircraft { get; set; }
  public int FighterAircraft { get; set; }
  public int CloseAirSupport { get; set; }
  public int Carrier { get; set; }
  public int Cruiser { get; set; }
  public int Destroyer { get; set; }
  public int SupplyTruck { get; set; }
  public int TransportAircraft { get; set; }
  public int Airfield { get; set; }
  public int NavalYard { get; set; }
  public int Warehouse { get; set; }
  public int Factory { get; set; }
}
