namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class AirUnitsController : ControllerBase
{
  private readonly AirUnitsService _aus;
  private readonly Auth0Provider _a0;

  public AirUnitsController(AirUnitsService aus, Auth0Provider a0)
  {
    _aus = aus;
    _a0 = a0;
  }

  // SECTION
  #region FighterAircraft Add/Remove
  [HttpPost("fighterAircraft")]
  public async Task<ActionResult<string>> CreateFighterAircraft()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _aus.CreateFighterAircraft(userInfo.Id);
      return Ok("FighterAircraft Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("fighterAircraft")]
  public async Task<ActionResult<string>> RemoveFighterAircraft()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _aus.RemoveFighterAircraft(userInfo?.Id);
      return Ok("FighterAircraft Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region CloseAirSupport Add/Remove
  [HttpPost("closeAirSupport")]
  public async Task<ActionResult<string>> CreateCloseAirSupport()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _aus.CreateCloseAirSupport(userInfo.Id);
      return Ok("CloseAirSupport Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("closeAirSupport")]
  public async Task<ActionResult<string>> RemoveCloseAirSupport()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _aus.RemoveCloseAirSupport(userInfo?.Id);
      return Ok("CloseAirSupport Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region TransportAircraft Add/Remove
  [HttpPost("transportAircraft")]
  public async Task<ActionResult<string>> CreateTransportAircraft()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _aus.CreateTransportAircraft(userInfo.Id);
      return Ok("TransportAircraft Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("transportAircraft")]
  public async Task<ActionResult<string>> RemoveTransportAircraft()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _aus.RemoveTransportAircraft(userInfo?.Id);
      return Ok("TransportAircraft Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion


}