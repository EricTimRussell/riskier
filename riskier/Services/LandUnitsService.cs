namespace riskier.Services;

public class LandUnitsService
{
  private readonly LandUnitsRepository _lupo;
  private readonly AccountsRepository _ar;

  public LandUnitsService(LandUnitsRepository lupo, AccountsRepository ar)
  {
    _lupo = lupo;
    _ar = ar;
  }

  internal void CreateInfantry(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 1;
    infantryOwner.TotalIndustry -= 1;
    infantryOwner.TotalAgriculture -= 3;
    infantryOwner.Infantry++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveInfantry(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 1;
    infantryOwner.TotalIndustry += 1;
    infantryOwner.TotalAgriculture += 3;
    infantryOwner.Infantry--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateSpecialForces(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 3;
    infantryOwner.TotalIndustry -= 1;
    infantryOwner.TotalAgriculture -= 3;
    infantryOwner.SpecialForces++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveSpecialForces(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 3;
    infantryOwner.TotalIndustry += 1;
    infantryOwner.TotalAgriculture += 3;
    infantryOwner.SpecialForces--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateMech(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 2;
    infantryOwner.TotalIndustry -= 2;
    infantryOwner.TotalAgriculture -= 3;
    infantryOwner.Mech++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveMech(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 2;
    infantryOwner.TotalIndustry += 2;
    infantryOwner.TotalAgriculture += 3;
    infantryOwner.Mech--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateIfv(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 3;
    infantryOwner.TotalIndustry -= 3;
    infantryOwner.TotalAgriculture -= 1;
    infantryOwner.Ifv++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveIfv(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 3;
    infantryOwner.TotalIndustry += 3;
    infantryOwner.TotalAgriculture += 1;
    infantryOwner.Ifv--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateMbt(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 4;
    infantryOwner.TotalIndustry -= 4;
    infantryOwner.TotalAgriculture -= 1;
    infantryOwner.Mbt++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveMbt(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 4;
    infantryOwner.TotalIndustry += 4;
    infantryOwner.TotalAgriculture += 1;
    infantryOwner.Mbt--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateArtillery(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 1;
    infantryOwner.TotalIndustry -= 3;
    infantryOwner.TotalAgriculture -= 0;
    infantryOwner.Artillery++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveArtillery(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 1;
    infantryOwner.TotalIndustry += 3;
    infantryOwner.TotalAgriculture += 0;
    infantryOwner.Artillery--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateSsArtillery(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 1;
    infantryOwner.TotalIndustry -= 4;
    infantryOwner.TotalAgriculture -= 0;
    infantryOwner.SsArtillery++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveSsArtillery(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 1;
    infantryOwner.TotalIndustry += 4;
    infantryOwner.TotalAgriculture += 0;
    infantryOwner.SsArtillery--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateAntiAircraft(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 3;
    infantryOwner.TotalIndustry -= 1;
    infantryOwner.TotalAgriculture -= 0;
    infantryOwner.AntiAircraft++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveAntiAircraft(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 3;
    infantryOwner.TotalIndustry += 1;
    infantryOwner.TotalAgriculture += 0;
    infantryOwner.AntiAircraft--;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void CreateSupplyTruck(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 1;
    infantryOwner.TotalIndustry -= 0;
    infantryOwner.TotalAgriculture -= 1;
    infantryOwner.SupplyTruck++;
    infantryOwner = _ar.Edit(infantryOwner);
  }

  internal void RemoveSupplyTruck(string userId)
  {
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 1;
    infantryOwner.TotalIndustry += 0;
    infantryOwner.TotalAgriculture += 1;
    infantryOwner.SupplyTruck--;
    infantryOwner = _ar.Edit(infantryOwner);
  }
}