using OctoDo.Domain.Models;

namespace OctoDo.Domain.Queries.RoutineQueries;

public interface IGetRoutineForDayQuery
{
    public Task<Routine> ExecuteAsync(DateTime date);
}