namespace riskier.Services;

public class NavyUnitsService
{
  private readonly AccountsRepository _ar;
  private readonly CarrierGroupRepository _cgr;

  public NavyUnitsService(AccountsRepository ar, CarrierGroupRepository cgr)
  {
    _ar = ar;
    _cgr = cgr;
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
    if (owner.Carrier <= 0)
    {
      return;
    }
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
    if (owner.Cruiser <= 0)
    {
      return;
    }
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
    if (owner.Destroyer <= 0)
    {
      return;
    }
    owner.Destroyer--;
    owner = _ar.Edit(owner);
  }

  internal Carrier CreateCarrierGroup(Carrier newCarrier)
  {
    return _cgr.CreateCarrierGroup(newCarrier);
  }

  internal void DeleteCarrierGroup(int carrierGroupId, string userId)
  {
    var foundCarrierGroup = GetCarrierGroupById(carrierGroupId);
    if (foundCarrierGroup.OwnerId != userId)
    {
      throw new Exception("Carrier Group does not belong to you");
    }
    _cgr.DeleteCarrierGroup(carrierGroupId);
  }

  private Carrier GetCarrierGroupById(int carrierGroupId)
  {
    {
      Carrier foundCarrierGroup = _cgr.GetCarrierGroupById(carrierGroupId);
      if (foundCarrierGroup == null)
      {
        throw new Exception("Bad id or Carrier Group does not exist");
      }
      return foundCarrierGroup;
    }
  }

  internal List<Carrier> GetCarrierGroupsByOwnerId(string ownerId)
  {
    return _cgr.GetCarrierGroupByOwnerId(ownerId);
  }

  internal Carrier UpdateCarrierGroup(Carrier carrierGroup, string userId)
  {
    {
      Carrier originalCarrierGroup = GetCarrierGroupById(carrierGroup.Id);
      if (originalCarrierGroup.OwnerId != userId)
      {
        throw new Exception("This Carrier Group does not belong to you");
      }
      originalCarrierGroup.CarrierNumber = carrierGroup.CarrierNumber;
      originalCarrierGroup.UnitSlot1 = carrierGroup.UnitSlot1;
      originalCarrierGroup.UnitSlot2 = carrierGroup.UnitSlot2;
      originalCarrierGroup.UnitSlot3 = carrierGroup.UnitSlot3;
      originalCarrierGroup.UnitSlot4 = carrierGroup.UnitSlot4;
      originalCarrierGroup.UnitSlot5 = carrierGroup.UnitSlot5;
      originalCarrierGroup.UnitSlot6 = carrierGroup.UnitSlot6;
      originalCarrierGroup.UnitSlot7 = carrierGroup.UnitSlot7;
      originalCarrierGroup.UnitSlot8 = carrierGroup.UnitSlot8;
      originalCarrierGroup.GroundUnit1 = carrierGroup.GroundUnit1;
      originalCarrierGroup.GroundUnit2 = carrierGroup.GroundUnit2;
      originalCarrierGroup.GroundUnit3 = carrierGroup.GroundUnit3;
      originalCarrierGroup.GroundUnit4 = carrierGroup.GroundUnit4;
      originalCarrierGroup.GroundUnit5 = carrierGroup.GroundUnit5;
      originalCarrierGroup.GroundUnit6 = carrierGroup.GroundUnit6;

      return _cgr.UpdateCarrierGroup(originalCarrierGroup);
    }

  }
}