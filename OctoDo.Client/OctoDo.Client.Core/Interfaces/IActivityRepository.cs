using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;
public interface IActivityRepository
{
    Task<Activity> GetActivityAsync(Guid id);
    Task CreateActivityAsync(Activity activity);
    Task ModifyActivityAsync(Activity activity);
    Task DeleteActivityAsync(Guid id);
    Task<IEnumerable<Activity>> GetRoutineActivitiesAsync(Guid routineId);
}
