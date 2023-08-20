using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;

public interface IRoutineRepository
{
    Task<Routine> GetRoutineAsync(Guid id);
    Task<IEnumerable<Routine>> GetTodayRoutinesAsync();
    Task CreateRoutineAsync();
    Task ModifyRoutineAsync(Routine routine);
    Task DeleteRoutineAsync(Guid id);
}
