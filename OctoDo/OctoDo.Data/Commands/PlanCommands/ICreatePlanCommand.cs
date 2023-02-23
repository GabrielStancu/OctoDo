using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.PlanCommands;

public interface ICreatePlanCommand
{
    public Task<Plan> ExecuteAsync(Plan plan);
}