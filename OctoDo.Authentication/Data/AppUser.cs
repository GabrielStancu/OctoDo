﻿using Microsoft.AspNetCore.Identity;

namespace OctoDo.Authentication.Data;
public class AppUser : IdentityUser
{
    public Guid UserId { get; set; }
}
