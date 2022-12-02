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

  internal Infantry CreateInfantry(Infantry infantry)
  {
    var newInfantry = _lupo.CreateInfantry(infantry);
    var infantryOwner = _ar.GetById(newInfantry.OwnerId);
    infantryOwner.TotalCapital -= newInfantry.Capital;
    infantryOwner.TotalIndustry -= newInfantry.Industry;
    infantryOwner.TotalAgriculture -= newInfantry.Agriculture;
    infantryOwner.Infantry++;
    infantryOwner = _ar.Edit(infantryOwner);
    return newInfantry;
  }
}