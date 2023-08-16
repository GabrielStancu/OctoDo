using OctoDo.Authentication.Api.Business.Identity;
using OctoDo.Authentication.Api.Business.Jwt;

namespace OctoDo.Authentication.Api.Business.Authentication;
public class AuthenticationService : IAuthenticationService
{
    private readonly IIdentityService _identityService;
    private readonly IJwtService _jwtService;

    public AuthenticationService(IIdentityService identityService, IJwtService jwtService)
    {
        _identityService = identityService;
        _jwtService = jwtService;
    }

    public async Task<LoginResponseModel> LoginAsync(string email, string password)
    {
        var identityResponse = await _identityService.LoginAsync(email, password);
        if (!identityResponse.Succeeded)
        {
            return new LoginResponseModel
            {
                Succeeded = false,
                Email = string.Empty,
                Error = identityResponse.Error,
                Token = string.Empty
            };
        }

        var token = _jwtService.CreateToken(email);
        return new LoginResponseModel
        {
            Succeeded = true,
            Email = email,
            Error = string.Empty,
            Token = token
        };
    }

    public async Task<RegisterResponseModel> RegisterAsync(string email, string password)
    {
        var identityResponse = await _identityService.RegisterAsync(email, password);

        return new RegisterResponseModel
        {
            Succeeded = identityResponse.Succeeded,
            Error = identityResponse.Error
        };
    }
}
