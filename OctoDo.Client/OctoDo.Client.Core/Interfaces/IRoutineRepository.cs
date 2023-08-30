using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;

public interface IRoutineRepository
{
    Task<IEnumerable<Routine>> GetTodayRoutinesAsync();
}
