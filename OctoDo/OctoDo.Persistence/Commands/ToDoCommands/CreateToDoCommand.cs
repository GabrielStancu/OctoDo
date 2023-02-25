using OctoDo.Domain.Commands.ToDoCommands;
using OctoDo.Domain.Models;

namespace OctoDo.Persistence.Commands.ToDoCommands;

public class CreateToDoCommand : ICreateToDoCommand
{
    public async Task<ToDo> ExecuteAsync(ToDo toDo)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}