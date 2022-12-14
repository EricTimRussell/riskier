namespace riskier.Services;

public class ArmiesDivisionsService
{
  private readonly ArmiesDivisionsRepository _adr;

  public ArmiesDivisionsService(ArmiesDivisionsRepository adr)
  {
    _adr = adr;
  }

  internal Division CreateDivision(Division newDivision)
  {
    return _adr.CreateDivision(newDivision);
  }

  internal Division UpdateDivision(Division division, string userId)
  {
    Division originalDivision = GetDivisionById(division.Id);
    if (originalDivision.OwnerId != userId)
    {
      throw new Exception("This division does not belong to you");
    }
    originalDivision.DivisionNumber = division.DivisionNumber;
    originalDivision.UnitSlot1 = division.UnitSlot1;
    originalDivision.UnitSlot2 = division.UnitSlot2;
    originalDivision.UnitSlot3 = division.UnitSlot3;
    originalDivision.UnitSlot4 = division.UnitSlot4;
    originalDivision.UnitSlot5 = division.UnitSlot5;
    originalDivision.UnitSlot6 = division.UnitSlot6;

    return _adr.UpdateDivision(originalDivision);
  }

  internal Division GetDivisionById(int divisionId)
  {
    Division foundDivision = _adr.GetDivisionById(divisionId);
    if (foundDivision == null)
    {
      throw new Exception("Bad id or division does not exist");
    }
    return foundDivision;
  }

  internal List<Division> GetDivisionsByOwnerId(string ownerId)
  {
    return _adr.GetDivisionsByOwnerId(ownerId);
  }

  internal void DeleteDivision(int divisionId, string userId)
  {
    var foundDivision = GetDivisionById(divisionId);
    if (foundDivision.OwnerId != userId)
    {
      throw new Exception("Division does not belong to you");
    }
    _adr.DeleteDivision(divisionId);
  }

  internal Army CreateArmy(Army newArmy)
  {
    return _adr.CreateArmy(newArmy);
  }

  internal Army UpdateArmy(Army army, string userId)
  {
    Army originalArmy = GetArmyById(army.Id);
    if (originalArmy.OwnerId != userId)
    {
      throw new Exception("This Army does not belong to you");
    }
    originalArmy.ArmyNumber = army.ArmyNumber;
    originalArmy.UnitSlot1 = army.UnitSlot1;
    originalArmy.UnitSlot2 = army.UnitSlot2;
    originalArmy.UnitSlot3 = army.UnitSlot3;
    originalArmy.UnitSlot4 = army.UnitSlot4;
    originalArmy.UnitSlot5 = army.UnitSlot5;
    originalArmy.UnitSlot6 = army.UnitSlot6;
    originalArmy.UnitSlot7 = army.UnitSlot7;
    originalArmy.UnitSlot8 = army.UnitSlot8;
    originalArmy.UnitSlot9 = army.UnitSlot9;

    return _adr.UpdateArmy(originalArmy);
  }

  private Army GetArmyById(int armyId)
  {
    Army foundArmy = _adr.GetArmyById(armyId);
    if (foundArmy == null)
    {
      throw new Exception("Bad id or army does not exist");
    }
    return foundArmy;
  }

  internal List<Army> GetArmiesByOwnerId(string ownerId)
  {
    return _adr.GetArmiesByOwnerId(ownerId);
  }

  internal void DeleteArmy(int armyId, string userId)
  {
    var foundArmy = GetArmyById(armyId);
    if (foundArmy.OwnerId != userId)
    {
      throw new Exception("Army does not belong to you");
    }
    _adr.DeleteArmy(armyId);
  }


}