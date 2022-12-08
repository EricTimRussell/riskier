namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]


public class RegionTilesController : ControllerBase
{
  private readonly RegionTilesService _rts;
  private readonly Auth0Provider _a0;

  public RegionTilesController(RegionTilesService rts, Auth0Provider a0)
  {
    _rts = rts;
    _a0 = a0;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<RegionTile>> CreateRegion([FromBody] RegionTile newRegion)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      newRegion.OwnerId = userInfo?.Id;
      RegionTile createdRegion = _rts.CreateRegion(newRegion);
      createdRegion.Creator = userInfo;
      return Ok(createdRegion);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet]
  public async Task<ActionResult<List<RegionTile>>> GetRegions()
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      var regions = _rts.GetRegions();
      return Ok(regions);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("hello")]
  public ActionResult<string> Hello()
  {
    try
    {
      return Ok("Hello");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  // [HttpGet("{regionTileId}")]
  // public ActionResult<RegionTile> GetRegionById(int regionTileId)
  // {
  //   try
  //   {
  //     RegionTile foundRegion = _rts.GetRegionById(regionTileId);
  //     return Ok(foundRegion);
  //   }
  //   catch (Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }

  [HttpGet("{ownerId}")]
  public async Task<ActionResult<List<RegionTile>>> GetRegionByOwnerId(string ownerId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      var regions = _rts.GetRegionByOwnerId(userInfo!.Id);
      return Ok(regions);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{regionTileId}")]
  public async Task<ActionResult<string>> RemoveRegion(int regionTileId)
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _rts.RemoveRegion(regionTileId, userInfo.Id);
      return Ok("Region Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}

