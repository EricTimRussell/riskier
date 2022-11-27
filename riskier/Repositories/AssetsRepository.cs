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
      eliteInfantry
      mech
      ifv
      mbt
      artillery
      ssArtillery
      antiAircraft
      fighterAircraft
      closeAirSupport
      carrier
      cruiser
      destroyer
      supplyTruck
      transportAircraft
      airfield
      navalYard
      warehouse
      factory
    )
    VALUES(
      @Id
      @OwnerId
      @Infantry,
      @EliteInfantry
      @Mech
      @Ifv
      @Mbt
      @Artillery
      @SsArtillery
      @AntiAircraft
      @FighterAircraft
      @CloseAirSupport
      @Carrier
      @Cruiser
      @Destroyer
      @SupplyTruck
      @TransportAircraft
      @Airfield
      @NavalYard
      @Warehouse
      @Factory
    );
    SELECT LAST_INSERT_ID()
    ;";
    newAssets.CreatedAt = DateTime.Now;
    newAssets.UpdatedAt = DateTime.Now;
    newAssets.Id = _db.ExecuteScalar<int>(sql, newAssets);
    return newAssets;
  }
}



