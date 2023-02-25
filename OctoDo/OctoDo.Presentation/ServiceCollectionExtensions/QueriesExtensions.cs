using OctoDo.Domain.Queries.PlanQueries;
using OctoDo.Persistence.Queries.PlanQueries;

namespace OctoDo.Presentation.ServiceCollectionExtensions;

public static class QueriesExtensions
{
    public static void AddQueries(this IServiceCollection services)
    {
        services.AddScoped<IGetAllPlansQuery, GetAllPlansQuery>();
    }
}