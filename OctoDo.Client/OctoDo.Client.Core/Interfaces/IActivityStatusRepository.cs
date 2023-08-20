using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;
public interface IActivityStatusRepository
{
    Task ToggleActivityStatusAsync(Guid id);
    Task CreateActivityStatusAsync(ActivityStatus activityStatus);
    Task DeleteActivityStatusAsync(Guid id);
}
