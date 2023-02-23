using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.RoutineCommands;

public interface IDeleteRoutineCommand
{
    public Task<bool> ExecuteAsync(Routine routine);
}