using OctoDo.Domain.Commands.RoutineCommands;
using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.Commands.RoutineCommands;

public class CreateRoutineCommand : ICreateRoutineCommand
{
    public async Task<Routine> ExecuteAsync(Routine routine)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}