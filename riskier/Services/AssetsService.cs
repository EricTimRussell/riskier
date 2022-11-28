namespace riskier.Services;

public class AssetsService
{

  private readonly AssetsRepository _ar;

  public AssetsService(AssetsRepository ar)
  {
    _ar = ar;
  }

  internal Asset CreateAssets(Asset newAssets)
  {
    return _ar.CreateAssets(newAssets);
  }

  internal void DeleteAssets(int assetId, string userId)
  {
    var assets = GetAssetsById(assetId);
    if (assets.OwnerId != userId)
    {
      throw new Exception("These assets do not belong to you");
    }
    _ar.DeleteAssets(assetId);
  }

  internal Asset EditAssets(Asset updatedAssets, string userId)
  {
    Asset originalAssets = GetAssetsById(updatedAssets.Id);
    if (originalAssets.OwnerId != userId)
    {
      throw new Exception("These assets do not belong to you");
    }
    originalAssets.Airfield = updatedAssets.Airfield;
    originalAssets.AntiAircraft = updatedAssets.AntiAircraft;
    originalAssets.Artillery = updatedAssets.Artillery;
    originalAssets.Carrier = updatedAssets.Carrier;
    originalAssets.CloseAirSupport = updatedAssets.CloseAirSupport;
    originalAssets.Cruiser = updatedAssets.Cruiser;
    originalAssets.Destroyer = updatedAssets.Destroyer;
    originalAssets.EliteInfantry = updatedAssets.EliteInfantry;
    originalAssets.Factory = updatedAssets.Factory;
    originalAssets.FighterAircraft = updatedAssets.FighterAircraft;
    originalAssets.Ifv = updatedAssets.Ifv;
    originalAssets.Infantry = updatedAssets.Infantry;
    originalAssets.Mbt = updatedAssets.Mbt;
    originalAssets.Mech = updatedAssets.Mech;
    originalAssets.NavalYard = updatedAssets.NavalYard;
    originalAssets.SsArtillery = updatedAssets.SsArtillery;
    originalAssets.SupplyTruck = updatedAssets.SupplyTruck;
    originalAssets.TransportAircraft = updatedAssets.TransportAircraft;
    originalAssets.Warehouse = updatedAssets.Warehouse;

    return _ar.EditAssets(originalAssets);
  }

  internal object GetAssets()
  {
    return _ar.GetAssets();
  }

  internal Asset GetAssetsById(int assetId)
  {
    Asset foundAssets = _ar.GetAssetsById(assetId);
    if (foundAssets == null)
    {
      throw new Exception("Assets do not exist or bad id");
    }
    return foundAssets;
  }
}