namespace OctoDo.Authentication.Api.Business.Authentication;
public class AuthenticationResponseModel
{
    public bool Succeeded { get; set; }
    public string? Error { get; set; }
}

public class LoginResponseModel : AuthenticationResponseModel
{
    public string? Email { get; set; }
    public string? Token { get; set; }
}

public class RegisterResponseModel : AuthenticationResponseModel
{
}
