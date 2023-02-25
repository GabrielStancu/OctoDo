using OctoDo.Domain.Commands.PlanCommands;
using OctoDo.Domain.Models;
using OctoDo.Persistence.DTOs;

namespace OctoDo.Persistence.Commands.PlanCommands;

public class CreatePlanCommand : ICreatePlanCommand
{
    private readonly DbContext _context;

    public CreatePlanCommand(DbContext context)
    {
        _context = context;
    }
    public async Task<Plan> ExecuteAsync(Plan plan)
    {
        await Task.Delay(10);

        var planDto = new PlanDto
        {
            Name = plan.Name,
            Description = plan.Description,
            IsDisabled = plan.IsDisabled
        };

        _context.Connection.Insert(planDto);

        return plan;
    }
}