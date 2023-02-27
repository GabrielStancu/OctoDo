using OctoDo.Persistence;

namespace OctoDo.Presentation.ServiceCollectionExtensions;

public static class SqliteExtensions
{
    public static void AddSqlite(this IServiceCollection services, string options)
    {
        services.AddSingleton(_ => new DbContext(options));
    }
}