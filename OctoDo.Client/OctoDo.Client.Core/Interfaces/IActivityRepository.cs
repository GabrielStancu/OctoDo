using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;
public interface IActivityRepository
{
    Task<IEnumerable<Activity>> GetRoutineActivitiesAsync(Guid routineId);
}
