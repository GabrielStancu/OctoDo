﻿namespace OctoDo.Authentication.Contracts;

public class LoginResponse
{
    public string? Email { get; set; }
    public string? Token { get; set; }
}
