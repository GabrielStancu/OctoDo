using System.ComponentModel.DataAnnotations;

namespace OctoDo.Server.Contracts.Authentication;
public class AuthenticationRequest
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }
}
