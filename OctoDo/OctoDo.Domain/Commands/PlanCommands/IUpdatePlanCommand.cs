using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.PlanCommands;

public interface IUpdatePlanCommand
{
    public Task<Plan> ExecuteAsync(Plan plan);
}