namespace OctoDo.Authentication.Api.Business.Identity;

public interface IIdentityService
{
    Task<LoginIdentityResponse> LoginAsync(string email, string password);
    Task<RegisterIdentityResponse> RegisterAsync(string email, string password);
}