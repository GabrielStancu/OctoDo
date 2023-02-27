using AutoMapper;
using OctoDo.Domain.Models;
using OctoDo.Domain.Queries.PlanQueries;
using OctoDo.Persistence.DTOs;

namespace OctoDo.Persistence.Queries.PlanQueries;

public class GetAllPlansQuery : IGetAllPlansQuery
{
    private readonly DbContext _context;
    private readonly IMapper _mapper;

    public GetAllPlansQuery(DbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Plan>> ExecuteAsync()
    {
        var  plans = Enumerable.Empty<Plan>();

        await Task.Run(() =>
        {
            plans = _context.Database
                .Table<PlanDto>()
                .Select(_mapper.Map<PlanDto, Plan>);
        });
        

        return plans;
    }
}
