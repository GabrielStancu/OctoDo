namespace OctoDo.Authentication.Api.Business.Jwt;

public interface IJwtService
{
    string CreateToken(string email);
}