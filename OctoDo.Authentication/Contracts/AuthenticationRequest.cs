﻿using System.ComponentModel.DataAnnotations;

namespace OctoDo.Authentication.Contracts;
public class AuthenticationRequest
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }
}
