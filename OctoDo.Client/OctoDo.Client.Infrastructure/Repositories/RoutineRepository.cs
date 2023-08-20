using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class RoutineRepository : IRoutineRepository
{
    public Task<Routine> GetRoutineAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Routine>> GetTodayRoutinesAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateRoutineAsync()
    {
        throw new NotImplementedException();
    }

    public Task ModifyRoutineAsync(Routine routine)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRoutineAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
