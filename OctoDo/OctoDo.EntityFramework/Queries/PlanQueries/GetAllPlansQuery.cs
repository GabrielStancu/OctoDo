using OctoDo.Domain.Models;
using OctoDo.Domain.Queries.PlanQueries;

namespace OctoDo.EntityFramework.Queries.PlanQueries;

public class GetAllPlansQuery : IGetAllPlansQuery
{
    public async Task<IEnumerable<Plan>> ExecuteAsync()
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}
