namespace riskier.Repositories;

public class LandUnitsRepository : BaseRepository
{
  public LandUnitsRepository(IDbConnection db) : base(db)
  {
  }

  internal Infantry CreateInfantry(Infantry infantry)
  {
    var sql = @"
    INSERT INTO infantry(
      ownerId,
      capital,
      industry,
      agriculture
    )
    VALUES(
      @OwnerId,
      @Capital,
      @Industry,
      @Agriculture
    );
    SELECT LAST_INSERT_ID()
    ;";
    infantry.CreatedAt = DateTime.Now;
    infantry.UpdatedAt = DateTime.Now;
    infantry.Id = _db.ExecuteScalar<int>(sql, infantry);
    return infantry;
  }
}
