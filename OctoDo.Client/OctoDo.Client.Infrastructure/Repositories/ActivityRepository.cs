using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class ActivityRepository : IActivityRepository
{
    public Task<Activity> GetActivityAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task CreateActivityAsync(Activity activity)
    {
        throw new NotImplementedException();
    }

    public Task ModifyActivityAsync(Activity activity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteActivityAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Activity>> GetRoutineActivitiesAsync(Guid routineId)
    {
        throw new NotImplementedException();
    }
}
