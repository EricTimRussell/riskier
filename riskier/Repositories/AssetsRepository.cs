namespace riskier.Repositories;

public class AssetsRepository : BaseRepository
{
  public AssetsRepository(IDbConnection db) : base(db)
  {
  }

  internal Asset CreateAssets(Asset newAssets)
  {
    var sql = @"
    INSERT INTO assets(
      id,
      ownerId,
      infantry,
      eliteInfantry,
      mech,
      ifv,
      mbt,
      artillery,
      ssArtillery,
      antiAircraft,
      fighterAircraft,
      closeAirSupport,
      carrier,
      cruiser,
      destroyer,
      supplyTruck,
      transportAircraft,
      airfield,
      navalYard,
      warehouse,
      factory
    )
    VALUES(
      @Id,
      @OwnerId,
      @Infantry,
      @EliteInfantry,
      @Mech,
      @Ifv,
      @Mbt,
      @Artillery,
      @SsArtillery,
      @AntiAircraft,
      @FighterAircraft,
      @CloseAirSupport,
      @Carrier,
      @Cruiser,
      @Destroyer,
      @SupplyTruck,
      @TransportAircraft,
      @Airfield,
      @NavalYard,
      @Warehouse,
      @Factory
    );
    SELECT LAST_INSERT_ID()
    ;";
    newAssets.CreatedAt = DateTime.Now;
    newAssets.UpdatedAt = DateTime.Now;
    newAssets.Id = _db.ExecuteScalar<int>(sql, newAssets);
    return newAssets;
  }

  internal void DeleteAssets(int assetId)
  {
    var sql = @"DELETE FROM assets WHERE id = @assetId LIMIT 1;";
    var rows = _db.Execute(sql, new { assetId });
    if (rows != 1)
    {
      throw new Exception("Data not deleted Id is bad");
    }
    return;
  }

  internal Asset EditAssets(Asset originalAssets)
  {
    var sql = @"
    UPDATE assets SET
      infantry = @Infantry
      eliteInfantry = @EliteInfantry
      mech = @Mech
      ifv = @Ifv
      mbt = @Mbt
      artillery = @Artillery
      ssArtillery = @SsArtillery
      antiAircraft = @AntiAircraft
      fighterAircraft = @FighterAircraft
      closeAirSupport = @CloseAirSupport
      carrier = @Carrier
      cruiser = @Cruiser
      destroyer = @Destroyer
      supplyTruck = @SupplyTruck
      transportAircraft = @TransportAircraft
      airfield = @Airfield
      navalYard = @NavalYard
      warehouse = @Warehouse
      factory = @Factory
      WHERE id = @Id LIMIT 1
    ;";
    originalAssets.UpdatedAt = DateTime.Now;
    var rows = _db.Execute(sql, originalAssets);
    if (rows < 1)
    {
      throw new Exception("No changes Made");
    }
    if (rows > 1)
    {
      throw new Exception("More than one row affected this should not happen");
    }
    return originalAssets;
  }

  internal Asset GetAssets()
  {
    var sql = @"
    SELECT
    a.*,
    rc.*
    FROM assets a
    JOIN riskierAccounts rc ON rc.id = a.ownerId
    ;";

    return _db.Query<Asset, Account, Asset>(sql, (a, ac) =>
    {
      a.Creator = ac;
      return a;
    }, new { }).FirstOrDefault();
  }

  internal Asset GetAssetsById(int assetId)
  {
    var sql = @"
    SELECT
    a.*,
    rc.*
    FROM assets a
    JOIN riskierAccounts rc ON rc.id = a.ownerId
    WHERE a.id = @assetId
    ;";
    return _db.Query<Asset, Account, Asset>(sql, (a, ac) =>
    {
      a.Creator = ac;
      return a;
    }, new { assetId }).FirstOrDefault();
  }




}



