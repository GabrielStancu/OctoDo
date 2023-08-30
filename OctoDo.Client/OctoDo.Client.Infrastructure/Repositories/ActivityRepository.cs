using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class ActivityRepository : GenericRepository<Activity>, IActivityRepository
{
    public ActivityRepository(string dbPath) : base(dbPath)
    {
    }

    public Task<IEnumerable<Activity>> GetRoutineActivitiesAsync(Guid routineId)
    {
        throw new NotImplementedException();
    }
}
