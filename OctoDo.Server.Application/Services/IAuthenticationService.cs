using OctoDo.Server.Application.Authentication;

namespace OctoDo.Server.Application.Services;

public interface IAuthenticationService
{
    Task<LoginResponse> LoginAsync(string email, string password);
    Task<RegisterResponse> RegisterAsync(string email, string password);
}