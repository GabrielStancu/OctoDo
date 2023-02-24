using OctoDo.Domain.Commands.ToDoCommands;
using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.Commands.ToDoCommands;

public class DeleteToDoCommand : IDeleteToDoCommand
{
    public async Task<bool> ExecuteAsync(ToDo toDo)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}