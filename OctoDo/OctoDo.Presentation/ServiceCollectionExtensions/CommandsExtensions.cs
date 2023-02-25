using OctoDo.Domain.Commands.PlanCommands;
using OctoDo.Persistence.Commands.PlanCommands;

namespace OctoDo.Presentation.ServiceCollectionExtensions;

public static class CommandsExtensions
{
    public static void AddCommands(this IServiceCollection services)
    {
        services.AddScoped<ICreatePlanCommand, CreatePlanCommand>();
    }
}