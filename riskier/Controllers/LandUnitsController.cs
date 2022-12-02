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

  [HttpPost]
  public async Task<ActionResult<Infantry>> createInfantry([FromBody] Infantry infantry)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      infantry.OwnerId = userInfo?.Id;
      var newInfantry = _lus.CreateInfantry(infantry);
      return Ok(infantry);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



}