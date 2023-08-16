using Microsoft.AspNetCore.Identity;

namespace OctoDo.Authentication.Api.Data;
public class AppUser : IdentityUser
{
    public Guid UserId { get; set; }
}
