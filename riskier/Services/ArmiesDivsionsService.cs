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

  internal List<Division> GetDivisions()
  {
    return _adr.GetDivisions();
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
}