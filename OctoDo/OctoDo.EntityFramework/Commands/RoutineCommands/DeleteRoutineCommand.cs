using OctoDo.Domain.Commands.RoutineCommands;
using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.Commands.RoutineCommands;

public class DeleteRoutineCommand : IDeleteRoutineCommand
{
    public async Task<bool> ExecuteAsync(Routine routine)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}