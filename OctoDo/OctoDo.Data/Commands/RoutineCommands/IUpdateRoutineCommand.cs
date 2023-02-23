using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.RoutineCommands;

public interface IUpdateRoutineCommand
{
    public Task<Routine> ExecuteAsync(Routine routine);
}