using OctoDo.Domain.Models;
using OctoDo.Domain.Queries.RoutineQueries;

namespace OctoDo.Persistence.Queries.RoutineQueries;

public class GetRoutineForDayQuery : IGetRoutineForDayQuery
{
    public async Task<Routine> ExecuteAsync(DateTime date)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}