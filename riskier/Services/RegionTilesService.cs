namespace riskier.Services;

public class RegionTilesService
{
  private readonly RegionTilesRepository _rtr;

  public RegionTilesService(RegionTilesRepository rtr)
  {
    _rtr = rtr;
  }

  internal RegionTile CreateRegion(RegionTile newRegion)
  {
    return _rtr.CreateRegion(newRegion);
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