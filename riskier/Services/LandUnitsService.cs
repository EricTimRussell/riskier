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
}