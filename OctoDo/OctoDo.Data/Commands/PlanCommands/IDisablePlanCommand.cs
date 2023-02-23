using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.PlanCommands;

public interface IDisablePlanCommand
{
    public Task<Plan> ExecuteAsync(Plan plan);
}