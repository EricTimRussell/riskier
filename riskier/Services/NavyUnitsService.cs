namespace riskier.Services;

public class NavyUnitsService
{
  private readonly AccountsRepository _ar;

  public NavyUnitsService(AccountsRepository ar)
  {
    _ar = ar;
  }

  internal void CreateCarrier(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 6;
    owner.TotalIndustry -= 6;
    owner.TotalAgriculture -= 6;
    owner.Carrier++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveCarrier(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 6;
    owner.TotalIndustry += 6;
    owner.TotalAgriculture += 6;
    owner.Carrier--;
    owner = _ar.Edit(owner);
  }

  internal void CreateCruiser(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 5;
    owner.TotalIndustry -= 5;
    owner.TotalAgriculture -= 2;
    owner.Cruiser++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveCruiser(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 5;
    owner.TotalIndustry += 5;
    owner.TotalAgriculture += 2;
    owner.Cruiser--;
    owner = _ar.Edit(owner);
  }

  internal void CreateDestroyer(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 5;
    owner.TotalIndustry -= 4;
    owner.TotalAgriculture -= 2;
    owner.Destroyer++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveDestroyer(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 5;
    owner.TotalIndustry += 4;
    owner.TotalAgriculture += 2;
    owner.Destroyer--;
    owner = _ar.Edit(owner);
  }
}