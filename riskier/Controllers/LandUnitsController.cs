namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class LandUnitsController : ControllerBase
{
  private readonly LandUnitsService _lus;
  private readonly Auth0Provider _a0;

  public LandUnitsController(LandUnitsService lus, Auth0Provider a0)
  {
    _lus = lus;
    _a0 = a0;
  }
  // SECTION
  #region Infantry Add/Remove
  [HttpPost("infantry")]
  public async Task<ActionResult<string>> CreateInfantry()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateInfantry(userInfo.Id);
      return Ok("Infantry Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("infantry")]
  public async Task<ActionResult<string>> RemoveInfantry()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveInfantry(userInfo?.Id);
      return Ok("Infantry Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region SpecialForces Add/Remove
  [HttpPost("specialForces")]
  public async Task<ActionResult<string>> CreateSpecialForces()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateSpecialForces(userInfo?.Id);
      return Ok("Special Forces Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("specialForces")]
  public async Task<ActionResult<string>> RemoveSpecialForces()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveSpecialForces(userInfo?.Id);
      return Ok("Special Forces Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  #endregion

  // SECTION
  #region Add/Remove Mech
  [HttpPost("mech")]
  public async Task<ActionResult<string>> CreateMech()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateMech(userInfo?.Id);
      return Ok("Mech Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("mech")]
  public async Task<ActionResult<string>> RemoveMech()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveMech(userInfo?.Id);
      return Ok("Mech Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION 
  #region Add/Remove Ifv
  [HttpPost("ifv")]
  public async Task<ActionResult<string>> CreateIfv()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateIfv(userInfo?.Id);
      return Ok("Ifv Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("ifv")]
  public async Task<ActionResult<string>> RemoveIfv()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveIfv(userInfo?.Id);
      return Ok("Ifv Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Add/Remove Mbt
  [HttpPost("mbt")]
  public async Task<ActionResult<string>> CreateMbt()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateMbt(userInfo?.Id);
      return Ok("Mbt Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("mbt")]
  public async Task<ActionResult<string>> RemoveMbt()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveMbt(userInfo?.Id);
      return Ok("Mbt Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Add/Remove Artillery
  [HttpPost("artillery")]
  public async Task<ActionResult<string>> CreateArtillery()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateArtillery(userInfo?.Id);
      return Ok("Artillery Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("artillery")]
  public async Task<ActionResult<string>> RemoveArtillery()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveArtillery(userInfo?.Id);
      return Ok("Artillery Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Add/Remove SsArtillery
  [HttpPost("ssArtillery")]
  public async Task<ActionResult<string>> CreateSsArtillery()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateSsArtillery(userInfo?.Id);
      return Ok("SsArtillery Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("ssArtillery")]
  public async Task<ActionResult<string>> RemoveSsArtillery()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveSsArtillery(userInfo?.Id);
      return Ok("SsArtillery Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Add/Remove AntiAircraft
  [HttpPost("antiAircraft")]
  public async Task<ActionResult<string>> CreateAntiAircraft()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateAntiAircraft(userInfo?.Id);
      return Ok("AntiAircraft Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("antiAircraft")]
  public async Task<ActionResult<string>> RemoveAntiAircraft()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveAntiAircraft(userInfo?.Id);
      return Ok("AntiAircraft Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Add/Remove SupplyTruck
  [HttpPost("supplyTruck")]
  public async Task<ActionResult<string>> CreateSupplyTruck()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.CreateSupplyTruck(userInfo?.Id);
      return Ok("SupplyTruck Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("supplyTruck")]
  public async Task<ActionResult<string>> RemoveSupplyTruck()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _lus.RemoveSupplyTruck(userInfo?.Id);
      return Ok("SupplyTruck Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

}