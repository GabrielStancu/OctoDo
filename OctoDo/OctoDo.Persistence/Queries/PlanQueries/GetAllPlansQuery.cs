using OctoDo.Domain.Models;
using OctoDo.Domain.Queries.PlanQueries;
using OctoDo.Persistence.DTOs;

namespace OctoDo.Persistence.Queries.PlanQueries;

public class GetAllPlansQuery : IGetAllPlansQuery
{
    private readonly DbContext _context;

    public GetAllPlansQuery(DbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Plan>> ExecuteAsync()
    {
        await Task.Delay(10);

        var plans = _context.Connection.Table<PlanDto>()
            .ToList().Select(dto => new Plan
            {
                Id = dto.Id,
                Name = dto.Name,
                IsDisabled = dto.IsDisabled,
                Description = dto.Description
            });

        return plans;
    }
}
