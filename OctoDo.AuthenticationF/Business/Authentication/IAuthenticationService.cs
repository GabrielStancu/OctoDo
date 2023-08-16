namespace OctoDo.Authentication.Api.Business.Authentication;

public interface IAuthenticationService
{
    Task<LoginResponseModel> LoginAsync(string email, string password);
    Task<RegisterResponseModel> RegisterAsync(string email, string password);
}