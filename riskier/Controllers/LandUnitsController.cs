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
  [HttpPost]
  public async Task<ActionResult<string>> createInfantry()
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

  [HttpDelete]
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




  #endregion
}