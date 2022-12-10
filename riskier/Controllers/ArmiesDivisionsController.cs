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
  #region Division Functions
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

  [HttpPut("{divisionId}")]
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

  [HttpGet("division")]
  public ActionResult<List<Division>> GetDivisions()
  {
    try
    {
      var divisions = _ads.GetDivisions();
      return Ok(divisions);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{divisionId}")]
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

}