namespace riskier.Repositories;

public class RegionTilesRepository : BaseRepository
{
  public RegionTilesRepository(IDbConnection db) : base(db)
  {
  }

  internal RegionTile CreateRegion(RegionTile newRegion)
  {
    var sql = @"
    INSERT INTO regions(
      ownerId,
      ownedBy,
      regionNumber,
      capital,
      industry,
      agriculture,
      environment
    )
    VALUES(
      @OwnerId,
      @OwnedBy,
      @RegionNumber,
      @Capital,
      @Industry,
      @Agriculture,
      @Environment
    );
    SELECT LAST_INSERT_ID()
    ;";
    newRegion.CreatedAt = DateTime.Now;
    newRegion.UpdatedAt = DateTime.Now;
    newRegion.Id = _db.ExecuteScalar<int>(sql, newRegion);
    return newRegion;
  }

  internal RegionTile GetRegionById(int regionTileId)
  {
    var sql = @"
    SELECT
    r.*,
    a.*
    FROM regions r
    JOIN accounts a ON a.id = r.ownerId
    WHERE r.id = @regionTileId
    ;";
    return _db.Query<RegionTile, Account, RegionTile>(sql, (r, a) =>
    {
      r.Creator = a;
      return r;
    }, new { regionTileId }).FirstOrDefault();
  }

  internal List<RegionTile> GetRegions()
  {
    var sql = @"
    SELECT
    r.*,
    a.*
    FROM regions r
    JOIN accounts a ON a.id = r.ownerId
    ;";
    return _db.Query<RegionTile, Account, RegionTile>(sql, (r, a) =>
    {
      r.Creator = a;
      return r;
    }).ToList();
  }

  internal void RemoveRegion(int regionTileId)
  {
    var sql = "DELETE FROM regions WHERE id = @RegionTileId LIMIT 1;";
    _db.Execute(sql, new { regionTileId });
    return;
  }
}