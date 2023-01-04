namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class NavyUnitsController : ControllerBase
{
  private readonly Auth0Provider _a0;
  private readonly NavyUnitsService _nus;

  public NavyUnitsController(Auth0Provider a0, NavyUnitsService nus)
  {
    _a0 = a0;
    _nus = nus;
  }

  // SECTION
  #region Carrier/CarrierGroup Add/Remove
  [HttpPost("carrier")]
  public async Task<ActionResult<string>> CreateCarrier()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.CreateCarrier(userInfo.Id);
      return Ok("Carrier Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("carrier")]
  public async Task<ActionResult<string>> RemoveCarrier()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.RemoveCarrier(userInfo?.Id);
      return Ok("Carrier Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("carrierGroup/{ownerId}")]
  public ActionResult<List<Carrier>> GetCarrierGroupsByOwnerId(string ownerId)
  {
    try
    {
      var carrierGroups = _nus.GetCarrierGroupsByOwnerId(ownerId);
      return Ok(carrierGroups);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost("carrierGroup")]
  public async Task<ActionResult<Carrier>> CreateCarrierGroup([FromBody] Carrier newCarrier)
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      newCarrier.OwnerId = userInfo?.Id;
      Carrier createdCarrierGoup = _nus.CreateCarrierGroup(newCarrier);
      createdCarrierGoup.Creator = userInfo;
      return Ok(createdCarrierGoup);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("carrierGroup/{carrierGroupId}")]
  public async Task<ActionResult<Carrier>> UpdateCarrierGroup([FromBody] Carrier carrierGroup, int carrierGroupId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      carrierGroup.Id = carrierGroupId;
      Carrier newCarrierGroup = _nus.UpdateCarrierGroup(carrierGroup, userInfo?.Id);
      return Ok(newCarrierGroup);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("carrierGroup/{carrierGroupId}")]
  public async Task<ActionResult<string>> DeleteCarrierGroup(int carrierGroupId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.DeleteCarrierGroup(carrierGroupId, userInfo.Id);
      return Ok("Carrier Group deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  #endregion

  // SECTION
  #region Cruiser Add/Remove
  [HttpPost("cruiser")]
  public async Task<ActionResult<string>> CreateCruiser()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.CreateCruiser(userInfo.Id);
      return Ok("Cruiser Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("cruiser")]
  public async Task<ActionResult<string>> RemoveCruiser()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.RemoveCruiser(userInfo?.Id);
      return Ok("Cruiser Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION
  #region Destroyer Add/Remove
  [HttpPost("destroyer")]
  public async Task<ActionResult<string>> CreateDestroyer()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.CreateDestroyer(userInfo.Id);
      return Ok("Destroyer Created");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("destroyer")]
  public async Task<ActionResult<string>> RemoveDestroyer()
  {
    try
    {
      var userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _nus.RemoveDestroyer(userInfo?.Id);
      return Ok("Destroyer Removed");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion



}