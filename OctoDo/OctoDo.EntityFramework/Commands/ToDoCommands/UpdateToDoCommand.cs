﻿using OctoDo.Domain.Commands.ToDoCommands;
using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.Commands.ToDoCommands;

public class UpdateToDoCommand : IUpdateToDoCommand
{
    public async Task<ToDo> ExecuteAsync(ToDo toDo)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}