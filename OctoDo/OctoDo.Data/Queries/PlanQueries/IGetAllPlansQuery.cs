using OctoDo.Domain.Models;

namespace OctoDo.Domain.Queries.PlanQueries;

public interface IGetAllPlansQuery
{
    public Task<IEnumerable<Plan>> ExecuteAsync();
}
