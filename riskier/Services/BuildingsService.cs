namespace riskier.Services;

public class BuildingsService
{
  private readonly AccountsRepository _ar;

  public BuildingsService(AccountsRepository ar)
  {
    _ar = ar;
  }

  internal void CreateAirfield(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 2;
    owner.TotalIndustry -= 0;
    owner.TotalAgriculture -= 1;
    owner.Airfield++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveAirfield(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 2;
    owner.TotalIndustry += 0;
    owner.TotalAgriculture += 1;
    owner.Airfield--;
    owner = _ar.Edit(owner);
  }

  internal void CreateNavalYard(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 2;
    owner.TotalIndustry -= 0;
    owner.TotalAgriculture -= 2;
    owner.NavalYard++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveNavalYard(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 2;
    owner.TotalIndustry += 0;
    owner.TotalAgriculture += 2;
    owner.NavalYard--;
    owner = _ar.Edit(owner);
  }

  internal void CreateWarehouse(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 1;
    owner.TotalIndustry -= 0;
    owner.TotalAgriculture -= 3;
    owner.Warehouse++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveWarehouse(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 1;
    owner.TotalIndustry += 0;
    owner.TotalAgriculture += 3;
    owner.Warehouse--;
    owner = _ar.Edit(owner);
  }

  internal void CreateFactory(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 2;
    owner.TotalIndustry -= 2;
    owner.TotalAgriculture -= 1;
    owner.Factory++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveFactory(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 2;
    owner.TotalIndustry += 2;
    owner.TotalAgriculture += 1;
    owner.Factory--;
    owner = _ar.Edit(owner);
  }
}

