using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class RoutineRepository : GenericRepository<Routine>, IRoutineRepository
{
    public RoutineRepository(string dbPath) : base(dbPath)
    {
    }

    public Task<IEnumerable<Routine>> GetTodayRoutinesAsync()
    {
        throw new NotImplementedException();
    }
}
