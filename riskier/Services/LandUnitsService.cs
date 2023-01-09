namespace riskier.Services;

public class LandUnitsService
{
  private readonly AccountsRepository _ar;

  public LandUnitsService(AccountsRepository ar)
  {
    _ar = ar;
  }

  internal void CreateInfantry(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 1;
    owner.TotalIndustry -= 1;
    owner.TotalAgriculture -= 3;
    owner.Infantry++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveInfantry(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 1;
    owner.TotalIndustry += 1;
    owner.TotalAgriculture += 3;
    if (owner.Infantry <= 0)
    {
      return;
    }
    owner.Infantry--;
    owner = _ar.Edit(owner);
  }

  internal void CreateSpecialForces(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 3;
    owner.TotalIndustry -= 1;
    owner.TotalAgriculture -= 3;
    owner.SpecialForces++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveSpecialForces(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 3;
    owner.TotalIndustry += 1;
    owner.TotalAgriculture += 3;
    if (owner.SpecialForces <= 0)
    {
      return;
    }
    owner.SpecialForces--;
    owner = _ar.Edit(owner);
  }

  internal void CreateMech(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 2;
    owner.TotalIndustry -= 2;
    owner.TotalAgriculture -= 3;
    owner.Mech++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveMech(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 2;
    owner.TotalIndustry += 2;
    owner.TotalAgriculture += 3;
    if (owner.Mech <= 0)
    {
      return;
    }
    owner.Mech--;
    owner = _ar.Edit(owner);
  }

  internal void CreateIfv(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 3;
    owner.TotalIndustry -= 3;
    owner.TotalAgriculture -= 1;
    owner.Ifv++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveIfv(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 3;
    owner.TotalIndustry += 3;
    owner.TotalAgriculture += 1;
    if (owner.Ifv <= 0)
    {
      return;
    }
    owner.Ifv--;
    owner = _ar.Edit(owner);
  }

  internal void CreateMbt(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 4;
    owner.TotalIndustry -= 4;
    owner.TotalAgriculture -= 1;
    owner.Mbt++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveMbt(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 4;
    owner.TotalIndustry += 4;
    owner.TotalAgriculture += 1;
    if (owner.Mbt <= 0)
    {
      return;
    }
    owner.Mbt--;
    owner = _ar.Edit(owner);
  }

  internal void CreateArtillery(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 1;
    owner.TotalIndustry -= 3;
    owner.TotalAgriculture -= 0;
    owner.Artillery++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveArtillery(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 1;
    owner.TotalIndustry += 3;
    owner.TotalAgriculture += 0;
    if (owner.Artillery <= 0)
    {
      return;
    }
    owner.Artillery--;
    owner = _ar.Edit(owner);
  }

  internal void CreateSsArtillery(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 2;
    owner.TotalIndustry -= 4;
    owner.TotalAgriculture -= 0;
    owner.SsArtillery++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveSsArtillery(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 2;
    owner.TotalIndustry += 4;
    owner.TotalAgriculture += 0;
    if (owner.SsArtillery <= 0)
    {
      return;
    }
    owner.SsArtillery--;
    owner = _ar.Edit(owner);
  }

  internal void CreateAntiAircraft(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 3;
    owner.TotalIndustry -= 1;
    owner.TotalAgriculture -= 0;
    owner.AntiAircraft++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveAntiAircraft(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 3;
    owner.TotalIndustry += 1;
    owner.TotalAgriculture += 0;
    if (owner.AntiAircraft <= 0)
    {
      return;
    }
    owner.AntiAircraft--;
    owner = _ar.Edit(owner);
  }

  internal void CreateSupplyTruck(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital -= 1;
    owner.TotalIndustry -= 0;
    owner.TotalAgriculture -= 1;
    owner.SupplyTruck++;
    owner = _ar.Edit(owner);
  }

  internal void RemoveSupplyTruck(string userId)
  {
    var owner = _ar.GetById(userId);
    owner.TotalCapital += 1;
    owner.TotalIndustry += 0;
    owner.TotalAgriculture += 1;
    if (owner.SupplyTruck <= 0)
    {
      return;
    }
    owner.SupplyTruck--;
    owner = _ar.Edit(owner);
  }
}