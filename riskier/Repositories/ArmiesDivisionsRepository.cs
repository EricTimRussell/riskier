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
      divisionNumber,
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
      @DivisionNumber,
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

  internal List<Division> GetDivisionsByOwnerId(string ownerId)
  {
    var sql = @"
    SELECT
    *
    FROM divisions
    WHERE ownerId = @ownerId
    ;";

    return _db.Query<Division>(sql, new { ownerId }).ToList();
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

  internal Army CreateArmy(Army newArmy)
  {
    var sql = @"
    INSERT INTO armies(
      id,
      armyNumber,
      ownerId,
      unitSlot1,
      unitSlot2,
      unitSlot3,
      unitSlot4,
      unitSlot5,
      unitSlot6,
      unitSlot7,
      unitSlot8,
      unitSlot9
    )
    VALUES(
      @id,
      @armyNumber,
      @ownerId,
      @unitSlot1,
      @unitSlot2,
      @unitSlot3,
      @unitSlot4,
      @unitSlot5,
      @unitSlot6,
      @unitSlot7,
      @unitSlot8,
      @unitSlot9
    );
    SELECT LAST_INSERT_ID()
    ;";
    newArmy.CreatedAt = DateTime.Now;
    newArmy.UpdatedAt = DateTime.Now;
    newArmy.Id = _db.ExecuteScalar<int>(sql, newArmy);
    return newArmy;
  }

  internal Army UpdateArmy(Army originalArmy)
  {
    var sql = @"
    UPDATE armies SET
      unitSlot1 = @UnitSlot1,
      unitSlot2 = @UnitSlot2,
      unitSlot3 = @UnitSlot3,
      unitSlot4 = @UnitSlot4,
      unitSlot5 = @UnitSlot5,
      unitSlot6 = @UnitSlot6,
      unitSlot7 = @UnitSlot7,
      unitSlot8 = @UnitSlot8,
      unitSlot9 = @UnitSlot9
    WHERE id = @Id LIMIT 1
    ;";
    originalArmy.UpdatedAt = DateTime.Now;
    _db.Execute(sql, originalArmy);
    return originalArmy;
  }

  internal Army GetArmyById(int armyId)
  {
    var sql = @"
    SELECT
     a.*,
     ra.*
    FROM armies a
    JOIN riskierAccounts ra ON ra.id = a.ownerId
    WHERE a.id = @armyId
    ;";

    return _db.Query<Army, Account, Army>(sql, (a, ra) =>
    {
      a.Creator = ra;
      return a;
    }, new { armyId }).FirstOrDefault();
  }

  internal List<Army> GetArmiesByOwnerId(string ownerId)
  {
    var sql = @"
    SELECT
    *
    FROM armies
    WHERE ownerId = @ownerId
    ;";

    return _db.Query<Army>(sql, new { ownerId }).ToList();
  }

  internal void DeleteArmy(int armyId)
  {
    var sql = "DELETE FROM armies WHERE id = @ArmyId LIMIT 1";
    var rows = _db.Execute(sql, new { armyId });
    if (rows != 1)
    {
      throw new Exception("data was not deleted Id may be bad or data is bad");
    }
    return;
  }
}