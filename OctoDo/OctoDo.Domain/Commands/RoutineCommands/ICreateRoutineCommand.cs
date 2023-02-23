using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.RoutineCommands;

public interface ICreateRoutineCommand
{
    public Task<Routine> ExecuteAsync(Routine routine);
}