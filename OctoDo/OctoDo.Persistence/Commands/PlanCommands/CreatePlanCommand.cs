using AutoMapper;
using OctoDo.Domain.Commands.PlanCommands;
using OctoDo.Domain.Models;
using OctoDo.Persistence.DTOs;

namespace OctoDo.Persistence.Commands.PlanCommands;

public class CreatePlanCommand : ICreatePlanCommand
{
    private readonly DbContext _context;
    private readonly IMapper _mapper;

    public CreatePlanCommand(DbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<Plan> ExecuteAsync(Plan plan)
    {
        await Task.Run(() =>
        {
            var planDto = _mapper.Map<Plan, PlanDto>(plan);
            _context.Database.Insert(planDto);

            // TODO: check if there is no other plan with the same name already. If so, return null
        });

        return plan;
    }
}