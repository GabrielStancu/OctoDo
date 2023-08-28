using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Infrastructure.Repositories;

namespace OctoDo.Client.Presentation.Utilities;

public static class ServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services, string dbName)
    {
        var dbPath = FileAccessHelper.GetLocalFilePath(dbName);

        services.AddSingleton<IActivityRepository, ActivityRepository>(s =>
            ActivatorUtilities.CreateInstance<ActivityRepository>(s, dbPath));
        services.AddSingleton<IActivityStatusRepository, ActivityStatusRepository>(s =>
            ActivatorUtilities.CreateInstance<ActivityStatusRepository>(s, dbPath));
        services.AddSingleton<ICompletionRepository, CompletionRepository>(s =>
            ActivatorUtilities.CreateInstance<CompletionRepository>(s, dbPath));
        services.AddSingleton<IRoutineRepository, RoutineRepository>(s =>
            ActivatorUtilities.CreateInstance<RoutineRepository>(s, dbPath));
    }
}
