namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class BuildingsController : ControllerBase
{
  private readonly BuildingsService _bs;
  private readonly Auth0Provider _a0;

  public BuildingsController(BuildingsService bs, Auth0Provider a0)
  {
    _bs = bs;
    _a0 = a0;
  }

  // SECTION
  #region Airfield Add/Remove
  [HttpPost("airfield")]
  public async Task<ActionResult<string>> CreateAirfield()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.CreateAirfield(userInfo.Id);
      return Ok("Airfield Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("airfield")]
  public async Task<ActionResult<string>> RemoveAirfield()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.RemoveAirfield(userInfo?.Id);
      return Ok("Airfield Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region NavalYard Add/Remove
  [HttpPost("navalYard")]
  public async Task<ActionResult<string>> CreateNavalYard()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.CreateNavalYard(userInfo.Id);
      return Ok("NavalYard Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("navalYard")]
  public async Task<ActionResult<string>> RemoveNavalYard()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.RemoveNavalYard(userInfo?.Id);
      return Ok("NavalYard Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Warehouse Add/Remove
  [HttpPost("warehouse")]
  public async Task<ActionResult<string>> CreateWarehouse()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.CreateWarehouse(userInfo.Id);
      return Ok("Warehouse Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("warehouse")]
  public async Task<ActionResult<string>> RemoveWarehouse()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.RemoveWarehouse(userInfo?.Id);
      return Ok("Warehouse Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Factory Add/Remove
  [HttpPost("factory")]
  public async Task<ActionResult<string>> CreateFactory()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.CreateFactory(userInfo.Id);
      return Ok("Factory Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("factory")]
  public async Task<ActionResult<string>> RemoveFactory()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _bs.RemoveFactory(userInfo?.Id);
      return Ok("Factory Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion


}