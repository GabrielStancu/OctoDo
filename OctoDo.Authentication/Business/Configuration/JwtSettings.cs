namespace OctoDo.Authentication.Business.Configuration;
public class JwtSettings
{
    public const string Jwt = "Jwt";
    public string? Key { get; set; }
    public string? Issuer { get; set; }
}
