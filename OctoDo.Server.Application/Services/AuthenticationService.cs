using OctoDo.Server.Application.Authentication;
using OctoDo.Server.Application.Interfaces;

namespace OctoDo.Server.Application.Services;
public class AuthenticationService : IAuthenticationService
{
    private readonly IIdentityService _identityService;
    private readonly IJwtService _jwtService;

    public AuthenticationService(IIdentityService identityService, IJwtService jwtService)
    {
        _identityService = identityService;
        _jwtService = jwtService;
    }

    public async Task<LoginResponse> LoginAsync(string email, string password)
    {
        var identityResponse = await _identityService.LoginAsync(email, password);
        if (!identityResponse.Succeeded)
        {
            return new LoginResponse
            {
                Succeeded = false,
                Email = string.Empty,
                Error = identityResponse.Error,
                Token = string.Empty
            };
        }

        var token = _jwtService.CreateToken(email);
        return new LoginResponse
        {
            Succeeded = true,
            Email = email,
            Error = string.Empty,
            Token = token
        };
    }

    public async Task<RegisterResponse> RegisterAsync(string email, string password)
    {
        var identityResponse = await _identityService.RegisterAsync(email, password);

        return new RegisterResponse
        {
            Succeeded = identityResponse.Succeeded,
            Error = identityResponse.Error
        };
    }
}
