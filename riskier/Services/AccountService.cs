namespace riskier.Services;

public class AccountService
{
  private readonly AccountsRepository _repo;

  public AccountService(AccountsRepository repo)
  {
    _repo = repo;
  }

  internal Account GetProfileByEmail(string email)
  {
    return _repo.GetByEmail(email);
  }

  internal Account GetOrCreateProfile(Account userInfo)
  {
    Account profile = _repo.GetById(userInfo.Id);
    if (profile == null)
    {
      return _repo.Create(userInfo);
    }
    return profile;
  }

  internal Account Edit(Account editData, Account userInfo)
  {
    Account original = GetProfileByEmail(userInfo.Email);
    original.Name = editData.Name.Length > 0 ? editData.Name : original.Name;
    original.Picture = editData.Picture.Length > 0 ? editData.Picture : original.Picture;
    original.TeamName = editData.TeamName ?? original.TeamName;
    original.TotalCapital = editData.TotalCapital;
    original.TotalIndustry = editData.TotalIndustry;
    original.TotalAgriculture = editData.TotalAgriculture;
    return _repo.Edit(original);
  }
}

