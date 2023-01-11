namespace riskier.Repositories;

public class AccountsRepository
{
  private readonly IDbConnection _db;

  public AccountsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Account GetByEmail(string userEmail)
  {
    string sql = "SELECT * FROM riskierAccounts WHERE email = @userEmail";
    return _db.QueryFirstOrDefault<Account>(sql, new { userEmail });
  }

  internal Account GetById(string id)
  {
    string sql = "SELECT * FROM riskierAccounts WHERE id = @id";
    return _db.QueryFirstOrDefault<Account>(sql, new { id });
  }

  internal Account Create(Account newAccount)
  {
    string sql = @"
            INSERT INTO riskierAccounts
              (name, picture, email, id, teamName, totalCapital, totalIndustry, totalAgriculture, totalProduction)
            VALUES
              (@Name, @Picture, @Email, @Id, @TeamName, @TotalCapital, @TotalIndustry, @TotalAgriculture, @TotalProduction)";
    _db.Execute(sql, newAccount);
    return newAccount;
  }

  internal Account Edit(Account update)
  {
    string sql = @"
            UPDATE riskierAccounts SET 
              name = @Name,
              picture = @Picture,
              teamName = @TeamName,
              totalCapital = @TotalCapital,
              totalIndustry = @TotalIndustry,
              totalAgriculture = @TotalAgriculture,
              totalProduction = @TotalProduction,
              infantry = @Infantry,
              specialForces = @SpecialForces,
              mech = @Mech,
              ifv = @Ifv,
              mbt = @Mbt,
              artillery = @Artillery,
              ssArtillery = @SsArtillery,
              antiAircraft = @AntiAircraft,
              fighterAircraft = @FighterAircraft,
              closeAirSupport = @CloseAirSupport,
              carrier = @Carrier,
              cruiser = @Cruiser,
              destroyer = @Destroyer,
              supplyTruck = @SupplyTruck,
              transportAircraft = @TransportAircraft,
              airfield = @Airfield,
              navalYard = @NavalYard,
              warehouse = @Warehouse,
              factory = @Factory
            WHERE id = @Id;";
    _db.Execute(sql, update);
    return update;
  }
}
