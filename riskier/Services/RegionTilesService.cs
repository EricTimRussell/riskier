namespace riskier.Services;

public class RegionTilesService
{
  private readonly RegionTilesRepository _rtr;
  private readonly AccountsRepository _ar;

  public RegionTilesService(RegionTilesRepository rtr, AccountsRepository ar)
  {
    _rtr = rtr;
    _ar = ar;
  }

  internal RegionTile CreateRegion(RegionTile newRegion)
  {

    var region = _rtr.CreateRegion(newRegion);
    var regionOwner = _ar.GetById(newRegion.OwnerId);
    regionOwner.TotalCapital += region.Capital;
    regionOwner.TotalIndustry += region.Industry;
    regionOwner.TotalAgriculture += region.Agriculture;
    regionOwner = _ar.Edit(regionOwner);
    return region;
  }

  internal RegionTile GetRegionById(int regionTileId)
  {
    RegionTile foundRegion = _rtr.GetRegionById(regionTileId);
    if (foundRegion == null)
    {
      throw new Exception("Region id does not exist");
    }
    return foundRegion;
  }

  internal List<RegionTile> GetRegions()
  {
    return _rtr.GetRegions();
  }

  internal void RemoveRegion(int regionTileId, string userId)
  {
    var region = GetRegionById(regionTileId);
    if (region.OwnerId != userId)
    {
      throw new Exception("Region does not belong to you");
    }
    _rtr.RemoveRegion(regionTileId);
  }
}