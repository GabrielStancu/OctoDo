namespace OctoDo.Server.Application.Authentication;
public class AuthenticationResponse
{
    public bool Succeeded { get; set; }
    public string? Error { get; set; }
}

public class LoginResponse : AuthenticationResponse
{
    public string? Email { get; set; }
    public string? Token { get; set; }
}

public class RegisterResponse : AuthenticationResponse
{
}
