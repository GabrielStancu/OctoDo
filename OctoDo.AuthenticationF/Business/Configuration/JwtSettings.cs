namespace OctoDo.Authentication.Api.Business.Configuration;
public class JwtSettings : ICustomApplicationSetting
{
    public string? Key { get; set; }
    public string? Issuer { get; set; }
}
