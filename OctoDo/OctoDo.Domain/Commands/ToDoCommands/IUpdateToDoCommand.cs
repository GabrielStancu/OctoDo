using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.ToDoCommands;

public interface IUpdateToDoCommand
{
    public Task<ToDo> ExecuteAsync(ToDo toDo);
}