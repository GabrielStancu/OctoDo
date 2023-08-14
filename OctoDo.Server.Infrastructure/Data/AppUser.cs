using Microsoft.AspNetCore.Identity;

namespace OctoDo.Server.Infrastructure.Data;
public class AppUser : IdentityUser
{
    public Guid UserId { get; set; }
}
