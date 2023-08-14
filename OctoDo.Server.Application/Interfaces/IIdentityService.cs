using OctoDo.Server.Application.Authentication;

namespace OctoDo.Server.Application.Interfaces;

public interface IIdentityService
{
    Task<LoginIdentityResponse> LoginAsync(string email, string password);
    Task<RegisterIdentityResponse> RegisterAsync(string email, string password);
}