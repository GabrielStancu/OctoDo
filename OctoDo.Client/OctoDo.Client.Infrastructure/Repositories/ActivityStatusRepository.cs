using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class ActivityStatusRepository : IActivityStatusRepository
{
    public Task ToggleActivityStatusAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task CreateActivityStatusAsync(ActivityStatus activityStatus)
    {
        throw new NotImplementedException();
    }

    public Task DeleteActivityStatusAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
