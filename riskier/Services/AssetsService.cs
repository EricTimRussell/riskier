namespace riskier.Services;

public class AssetsService
{

  private readonly AssetsRepository _ar;

  public AssetsService(AssetsRepository ar)
  {
    _ar = ar;
  }

  internal Asset CreateAssets(Asset newAssets)
  {
    return _ar.CreateAssets(newAssets);
  }
}