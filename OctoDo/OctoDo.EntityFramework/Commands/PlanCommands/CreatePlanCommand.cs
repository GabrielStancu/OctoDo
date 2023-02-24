using OctoDo.Domain.Commands.PlanCommands;
using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.Commands.PlanCommands;

public class CreatePlanCommand : ICreatePlanCommand
{
    public async Task<Plan> ExecuteAsync(Plan plan)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}