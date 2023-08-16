using OctoDo.Server.Domain.Entities;

namespace OctoDo.Server.Application.Interfaces;
public interface IActivityRepository
{
    Task<Activity?> GetRoutineActivitiesAsync(Guid routineId);
}
