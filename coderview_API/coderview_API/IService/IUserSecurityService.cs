namespace coderview_API.IService
{
    public interface IUserSecurityService
    {
        string GenerateAuthorizationToken(string userName, string userPassword);
        bool ValidateUserToken(string authorization, List<string> authorizedRols);
    }
}
