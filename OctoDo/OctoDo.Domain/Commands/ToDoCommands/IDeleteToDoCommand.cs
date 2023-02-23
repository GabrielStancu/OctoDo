using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.ToDoCommands;

public interface IDeleteToDoCommand
{
    public Task<bool> ExecuteAsync(ToDo toDo);
}