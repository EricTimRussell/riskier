namespace riskier.Repositories;

public class LandUnitsRepository : BaseRepository
{
  public LandUnitsRepository(IDbConnection db) : base(db)
  {
  }

  // internal Infantry CreateInfantry(Infantry infantry)
  // {
  //   var sql = @"
  //   INSERT INTO infantry(
  //     ownerId,
  //     capital,
  //     industry,
  //     agriculture
  //   )
  //   VALUES(
  //     @OwnerId,
  //     @Capital,
  //     @Industry,
  //     @Agriculture
  //   );
  //   SELECT LAST_INSERT_ID()
  //   ;";
  //   infantry.CreatedAt = DateTime.Now;
  //   infantry.UpdatedAt = DateTime.Now;
  //   infantry.Id = _db.ExecuteScalar<int>(sql, infantry);
  //   return infantry;
  // }

  // internal Infantry GetInfantryById(int id)
  // {
  //   var sql = @"
  //   SELECT
  //     i.*,
  //     ra.*
  //     FROM infantry i
  //     JOIN riskierAccounts ra ON ra.id = i.ownerId
  //     WHERE i.id = @id
  //   ;";

  //   return _db.Query<Infantry, Profile, Infantry>(sql, (i, p) =>
  //   {
  //     i.OwnerId = p.Id;
  //     return i;
  //   }, new { id }).FirstOrDefault();
  // }

  // internal void RemoveInfantry(int infantryId)
  // {
  //   _db.Execute("DELETE FROM infantry WHERE infantryId = @Id", new { infantryId });
  // }
}
