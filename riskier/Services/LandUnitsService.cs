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
    // var newInfantry = _lupo.CreateInfantry(infantry);
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital -= 1;
    infantryOwner.TotalIndustry -= 1;
    infantryOwner.TotalAgriculture -= 3;
    infantryOwner.Infantry++;
    infantryOwner = _ar.Edit(infantryOwner);
    // return newInfantry;
  }

  internal void RemoveInfantry(string userId)
  {
    // var infantry = GetInfantryById(infantryId);
    // if (infantry.OwnerId != userId)
    // {
    //   throw new Exception("This does not belong to you");
    // }
    var infantryOwner = _ar.GetById(userId);
    infantryOwner.TotalCapital += 1;
    infantryOwner.TotalIndustry += 1;
    infantryOwner.TotalAgriculture += 3;
    infantryOwner.Infantry--;
    infantryOwner = _ar.Edit(infantryOwner);

    // _lupo.RemoveInfantry(infantryId);
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
}