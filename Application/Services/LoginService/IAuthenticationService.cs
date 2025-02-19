namespace Application.Services.LoginService
{
    public interface IAuthenticationService
    {
          Task<string> LoginAsync(string username, string password);
    }
}
