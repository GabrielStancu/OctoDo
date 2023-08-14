namespace OctoDo.Server.Application.Interfaces;
public interface IJwtService
{
    string CreateToken(string email);
}
