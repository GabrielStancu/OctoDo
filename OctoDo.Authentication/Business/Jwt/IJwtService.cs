﻿namespace OctoDo.Authentication.Business.Jwt;

public interface IJwtService
{
    string CreateToken(string email);
}