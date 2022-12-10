namespace riskier.Repositories;

public class ArmiesDivisionsRepository : BaseRepository
{
  public ArmiesDivisionsRepository(IDbConnection db) : base(db)
  {
  }

  internal Division CreateDivision(Division newDivision)
  {
    var sql = @"
    INSERT INTO divisions(
      id,
      ownerId,
      unitSlot1,
      unitSlot2,
      unitSlot3,
      unitSlot4,
      unitSlot5,
      unitSlot6
    )
    VALUES(
      @Id,
      @OwnerId,
      @UnitSlot1,
      @UnitSlot2,
      @UnitSlot3,
      @UnitSlot4,
      @UnitSlot5,
      @UnitSlot6
    );
    SELECT LAST_INSERT_ID()
    ;";
    newDivision.CreatedAt = DateTime.Now;
    newDivision.UpdatedAt = DateTime.Now;
    newDivision.Id = _db.ExecuteScalar<int>(sql, newDivision);
    return newDivision;
  }

  internal Division UpdateDivision(Division originalDivision)
  {
    var sql = @"
    UPDATE divisions SET
      unitSlot1 = @UnitSlot1,
      unitSlot2 = @UnitSlot2,
      unitSlot3 = @UnitSlot3,
      unitSlot4 = @UnitSlot4,
      unitSlot5 = @UnitSlot5,
      unitSlot6 = @UnitSlot6
    WHERE id = @Id LIMIT 1
    ;";
    originalDivision.UpdatedAt = DateTime.Now;
    _db.Execute(sql, originalDivision);
    return originalDivision;
  }

  internal Division GetDivisionById(int divisionId)
  {
    var sql = @"
    SELECT
     d.*,
     ra.*
    FROM divisions d
    JOIN riskierAccounts ra ON ra.id = d.ownerId
    WHERE d.id = @divisionId
    ;";

    return _db.Query<Division, Account, Division>(sql, (d, a) =>
    {
      d.Creator = a;
      return d;
    }, new { divisionId }).FirstOrDefault();
  }

  internal List<Division> GetDivisions()
  {
    var sql = @"
    SELECT
      d.*,
      ra.*
    FROM divisions d
    JOIN riskierAccounts ra ON ra.id = d.ownerId
    ;";

    return _db.Query<Division, Account, Division>(sql, (d, a) =>
    {
      d.Creator = a;
      return d;
    }).ToList();
  }

  internal void DeleteDivision(int divisionId)
  {
    var sql = "DELETE FROM divisions WHERE id = @DivisionId LIMIT 1";
    var rows = _db.Execute(sql, new { divisionId });
    if (rows != 1)
    {
      throw new Exception("data was not deleted Id may be bad or data is bad");
    }
    return;
  }


}