namespace riskier.Repositories;

public class CarrierGroupRepository : BaseRepository
{
  public CarrierGroupRepository(IDbConnection db) : base(db)
  {
  }

  internal Carrier CreateCarrierGroup(Carrier newCarrier)
  {
    var sql = @"
    INSERT INTO carriers(
      id,
      carrierNumber,
      ownerId,
      unitSlot1,
      unitSlot2,
      unitSlot3,
      unitSlot4,
      unitSlot5,
      unitSlot6,
      unitSlot7,
      unitSlot8,
      groundUnit1,
      groundUnit2,
      groundUnit3,
      groundUnit4,
      groundUnit5,
      groundUnit6
    )
    VALUES(
      @Id,
      @CarrierNumber,
      @OwnerId,
      @UnitSlot1,
      @UnitSlot2,
      @UnitSlot3,
      @UnitSlot4,
      @UnitSlot5,
      @UnitSlot6,
      @UnitSlot7,
      @UnitSlot8,
      @GroundUnit1,
      @GroundUnit2,
      @GroundUnit3,
      @GroundUnit4,
      @GroundUnit5,
      @GroundUnit6
    );
    SELECT LAST_INSERT_ID()
    ;";
    newCarrier.CreatedAt = DateTime.Now;
    newCarrier.UpdatedAt = DateTime.Now;
    newCarrier.Id = _db.ExecuteScalar<int>(sql, newCarrier);
    return newCarrier;
  }

  internal void DeleteCarrierGroup(int carrierGroupId)
  {
    {
      var sql = "DELETE FROM carriers WHERE id = @CarrierGroupId LIMIT 1";
      var rows = _db.Execute(sql, new { carrierGroupId });
      if (rows != 1)
      {
        throw new Exception("data was not deleted Id may be bad or data is bad");
      }
      return;
    }
  }

  internal Carrier GetCarrierGroupById(object carrierGroupId)
  {
    var sql = @"
    SELECT
     c.*,
     ra.*
    FROM carriers c
    JOIN riskierAccounts ra ON ra.id = c.ownerId
    WHERE c.id = @carrierGroupId
    ;";

    return _db.Query<Carrier, Account, Carrier>(sql, (c, ra) =>
    {
      c.Creator = ra;
      return c;
    }, new { carrierGroupId }).FirstOrDefault();
  }

  internal List<Carrier> GetCarrierGroupByOwnerId(string ownerId)
  {
    var sql = @"
    SELECT
    *
    FROM carriers
    WHERE ownerId = @ownerId
    ;";

    return _db.Query<Carrier>(sql, new { ownerId }).ToList();
  }

  internal Carrier UpdateCarrierGroup(Carrier originalCarrierGroup)
  {
    var sql = @"
    UPDATE carriers SET
      unitSlot1 = @UnitSlot1,
      unitSlot2 = @UnitSlot2,
      unitSlot3 = @UnitSlot3,
      unitSlot4 = @UnitSlot4,
      unitSlot5 = @UnitSlot5,
      unitSlot6 = @UnitSlot6,
      unitSlot7 = @UnitSlot7,
      unitSlot8 = @UnitSlot8,
      groundUnit1 = @GroundUnit1,
      groundUnit2 = @GroundUnit2,
      groundUnit3 = @GroundUnit3,
      groundUnit4 = @GroundUnit4,
      groundUnit5 = @GroundUnit5,
      groundUnit6 = @GroundUnit6
    WHERE id = @Id LIMIT 1
    ;";
    originalCarrierGroup.UpdatedAt = DateTime.Now;
    _db.Execute(sql, originalCarrierGroup);
    return originalCarrierGroup;
  }
}