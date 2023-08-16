using Microsoft.AspNetCore.Mvc;
using OctoDo.Authentication.Business.Authentication;
using OctoDo.Authentication.Contracts;

namespace OctoDo.Authentication.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public UsersController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponse>> Login(AuthenticationRequest request)
    {
        var response = await _authenticationService.LoginAsync(request.Email!, request.Password!);

        if (response.Succeeded)
        {
            return Ok(new LoginResponse
            {
                Email = response.Email,
                Token = response.Token
            });
        }

        return Unauthorized(response.Error);
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register(AuthenticationRequest request)
    {
        var response = await _authenticationService.RegisterAsync(request.Email!, request.Password!);

        if (response.Succeeded)
        {
            return Ok();
        }

        return Unauthorized(response.Error);
    }
}
