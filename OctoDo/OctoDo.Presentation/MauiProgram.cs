using Microsoft.Extensions.Logging;
using OctoDo.Presentation.Pages;
using OctoDo.Presentation.ServiceCollectionExtensions;
using OctoDo.Presentation.Stores;
using OctoDo.Presentation.ViewModels;

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

        // Database
        builder.Services.AddSqlite(ConnectionString());

		// Commands and Queries
		builder.Services.AddCommands();
		builder.Services.AddQueries();

		// IMapper
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

		// Stores
        builder.Services.AddSingleton<PlansStore>();

		// ViewModels
        builder.Services.AddSingleton<PlansPageViewModel>();

        // Pages
        builder.Services.AddSingleton(provider => new PlansPage
        {
			BindingContext = provider.GetService<PlansPageViewModel>()
        });

        return builder.Build();
	}

    private static string ConnectionString() 
        => Path.Combine(FileSystem.AppDataDirectory, "OctoDo.db");
}
