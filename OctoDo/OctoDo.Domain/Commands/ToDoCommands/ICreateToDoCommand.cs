using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.ToDoCommands;

public interface ICreateToDoCommand
{
    public Task<ToDo> ExecuteAsync(ToDo toDo);
}