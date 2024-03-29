﻿namespace OctoDo.Authentication.Business.Identity;
public class IdentityResponse
{
    public bool Succeeded { get; set; }
    public string? Error { get; set; }
}

public class LoginIdentityResponse : IdentityResponse
{
    public string? Email { get; set; }
}

public class RegisterIdentityResponse : IdentityResponse
{
}
