using Microsoft.AspNetCore.Identity;
using OctoDo.Authentication.Api.Data;

namespace OctoDo.Authentication.Api.Business.Identity;
public class IdentityService : IIdentityService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public IdentityService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<LoginIdentityResponse> LoginAsync(string email, string password)
    {
        // Check the user exists
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return new LoginIdentityResponse
            {
                Email = string.Empty,
                Succeeded = false,
                Error = "Invalid email or password"
            };
        }

        // Check the password
        var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

        return new LoginIdentityResponse
        {
            Email = result.Succeeded ? email : string.Empty,
            Succeeded = result.Succeeded,
            Error = result.Succeeded ? string.Empty : "Invalid email or password"
        };
    }

    public async Task<RegisterIdentityResponse> RegisterAsync(string email, string password)
    {
        // Validate the request
        if (await _userManager.FindByEmailAsync(email) != null)
        {
            return new RegisterIdentityResponse
            {
                Succeeded = false,
                Error = "Email address is already in use"
            };
        }

        // Register the user
        var user = new AppUser
        {
            Email = email
        };
        var result = await _userManager.CreateAsync(user, password);

        return new RegisterIdentityResponse
        {
            Succeeded = result.Succeeded,
            Error = result.Succeeded ? string.Empty : string.Join(';', result.Errors)
        };
    }
}
