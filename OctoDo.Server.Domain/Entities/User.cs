﻿namespace OctoDo.Server.Domain.Entities;
public class User
{
    public string? Email { get; set; }
    public IEnumerable<Routine>? Routines { get; set; }
}
