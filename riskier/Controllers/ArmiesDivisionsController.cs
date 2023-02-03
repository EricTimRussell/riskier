namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class ArmiesDivisionsController : ControllerBase
{
  private readonly Auth0Provider _a0;
  private readonly ArmiesDivisionsService _ads;

  public ArmiesDivisionsController(Auth0Provider a0, ArmiesDivisionsService ads)
  {
    _a0 = a0;
    _ads = ads;
  }

  // SECTION
  #region Divisions Functions
  [HttpPost("division")]
  public async Task<ActionResult<Division>> CreateDivision([FromBody] Division newDivision)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      newDivision.OwnerId = userInfo.Id;
      Division createdDivision = _ads.CreateDivision(newDivision);
      createdDivision.Creator = userInfo;
      return Ok(createdDivision);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("division/{divisionId}")]
  public async Task<ActionResult<Division>> UpdateDivision([FromBody] Division division, int divisionId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      division.Id = divisionId;
      Division newDivision = _ads.UpdateDivision(division, userInfo?.Id);
      return Ok(newDivision);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("division/{ownerId}")]
  public ActionResult<List<Division>> GetDivisionsByOwnerId(string ownerId)
  {
    try
    {
      var divisions = _ads.GetDivisionsByOwnerId(ownerId);
      return Ok(divisions);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("division/{divisionId}")]
  public async Task<ActionResult<string>> DeleteDivision(int divisionId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _ads.DeleteDivision(divisionId, userInfo.Id);
      return Ok("Division deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  // SECTION 
  #region Armies Functions
  [HttpPost("army")]
  public async Task<ActionResult<Army>> CreateArmy([FromBody] Army newArmy)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      newArmy.OwnerId = userInfo.Id;
      Army createdArmy = _ads.CreateArmy(newArmy);
      createdArmy.Creator = userInfo;
      return Ok(createdArmy);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("army/{armyId}")]
  public async Task<ActionResult<Army>> UpdateArmy([FromBody] Army army, int armyId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Bad user or authToken invalid");
      }
      army.Id = armyId;
      Army newArmy = _ads.UpdateArmy(army, userInfo?.Id);
      return Ok(newArmy);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("army/{ownerId}")]
  public ActionResult<List<Army>> GetArmiesByOwnerId(string ownerId)
  {
    try
    {
      var armies = _ads.GetArmiesByOwnerId(ownerId);
      return Ok(armies);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("army/{armyId}")]
  public async Task<ActionResult<string>> DeleteArmy(int armyId)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      _ads.DeleteArmy(armyId, userInfo.Id);
      return Ok("Army Deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  #endregion

}