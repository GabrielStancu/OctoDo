using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OctoDo.Presentation.ServiceCollectionExtensions;

namespace OctoDo.Presentation;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		// Pages
		builder.Services.AddSingleton<MainPage>();

		// Database
        builder.Services.AddSqlite(ConnectionString());

		// Commands and Queries
		builder.Services.AddCommands();
		builder.Services.AddQueries();

        return builder.Build();
	}

    private static string ConnectionString() 
        => Path.Combine(FileSystem.AppDataDirectory, "OctoDo.db");
}
