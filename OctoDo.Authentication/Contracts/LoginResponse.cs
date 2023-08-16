namespace OctoDo.Server.Contracts.Authentication;

public class LoginResponse
{
    public string? Email { get; set; }
    public string? Token { get; set; }
}
