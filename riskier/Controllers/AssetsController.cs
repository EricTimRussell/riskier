namespace riskier.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AssetsController : ControllerBase
{
  private readonly AssetsService _as;
  private readonly Auth0Provider _a0;

  public AssetsController(AssetsService @as, Auth0Provider a0)
  {
    _as = @as;
    _a0 = a0;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Asset>> CreateAssets([FromBody] Asset newAssets)
  {
    try
    {
      Account userInfo = await _a0.GetUserInfoAsync<Account>(HttpContext);
      if (userInfo == null || userInfo.Id == null)
      {
        throw new Exception("Invalid user Id or Expired Authtoken");
      }
      newAssets.OwnerId = userInfo?.Id;
      Asset createdAssets = _as.CreateAssets(newAssets);
      createdAssets.Creator = userInfo;
      return Ok(createdAssets);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
