namespace riskier.Services;

public class AirUnitsService
{
  private readonly AccountsRepository _ar;

  public AirUnitsService(AccountsRepository ar)
  {
    _ar = ar;
  }

  internal void CreateFighterAircraft(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 4;
    owner.TotalIndustry -= 4;
    owner.TotalAgriculture -= 0;
    owner.FighterAircraft++;
    owner = _ar.Edit(owner);
  }
  internal void RemoveFighterAircraft(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 4;
    owner.TotalIndustry += 4;
    owner.TotalAgriculture += 0;
    if (owner.FighterAircraft <= 0)
    {
      return;
    }
    owner.FighterAircraft--;
    owner = _ar.Edit(owner);
  }

  internal void CreateCloseAirSupport(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 4;
    owner.TotalIndustry -= 4;
    owner.TotalAgriculture -= 0;
    owner.CloseAirSupport++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveCloseAirSupport(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 4;
    owner.TotalIndustry += 4;
    owner.TotalAgriculture += 0;
    if (owner.CloseAirSupport <= 0)
    {
      return;
    }
    owner.CloseAirSupport--;
    owner = _ar.Edit(owner);
  }

  internal void CreateTransportAircraft(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 1;
    owner.TotalIndustry -= 1;
    owner.TotalAgriculture -= 0;
    owner.TransportAircraft++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveTransportAircraft(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 1;
    owner.TotalIndustry += 1;
    owner.TotalAgriculture += 0;
    if (owner.TransportAircraft <= 0)
    {
      return;
    }
    owner.TransportAircraft--;
    owner = _ar.Edit(owner);
  }
}