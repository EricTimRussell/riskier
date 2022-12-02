namespace riskier.Services;

public class AccountService
{
  private readonly AccountsRepository _repo;

  public AccountService(AccountsRepository repo)
  {
    _repo = repo;
  }

  internal Account GetProfileByEmail(string email)
  {
    return _repo.GetByEmail(email);
  }

  internal Account GetOrCreateProfile(Account userInfo)
  {
    Account profile = _repo.GetById(userInfo.Id);
    if (profile == null)
    {
      return _repo.Create(userInfo);
    }
    return profile;
  }

  internal Account Edit(Account editData, Account userInfo)
  {
    Account original = GetProfileByEmail(userInfo.Email);
    original.Name = editData.Name ?? original.Name;
    original.Picture = editData.Picture ?? original.Picture;
    original.TeamName = editData.TeamName ?? original.TeamName;
    original.Airfield = editData.Airfield;
    original.AntiAircraft = editData.AntiAircraft;
    original.Artillery = editData.Artillery;
    original.Carrier = editData.Carrier;
    original.CloseAirSupport = editData.CloseAirSupport;
    original.Cruiser = editData.Cruiser;
    original.Destroyer = editData.Destroyer;
    original.EliteInfantry = editData.EliteInfantry;
    original.Factory = editData.Factory;
    original.FighterAircraft = editData.FighterAircraft;
    original.Ifv = editData.Ifv;
    original.Infantry = editData.Infantry;
    original.Mbt = editData.Mbt;
    original.Mech = editData.Mech;
    original.NavalYard = editData.NavalYard;
    original.SsArtillery = editData.SsArtillery;
    original.SupplyTruck = editData.SupplyTruck;
    original.TransportAircraft = editData.TransportAircraft;
    original.Warehouse = editData.Warehouse;
    return _repo.Edit(original);
  }
}

