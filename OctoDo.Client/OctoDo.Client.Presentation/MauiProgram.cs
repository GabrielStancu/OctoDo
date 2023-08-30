using Microsoft.Extensions.Logging;
using OctoDo.Client.Presentation.Utilities;
using OctoDo.Client.Presentation.ViewModels;
using OctoDo.Client.Presentation.Views;

namespace OctoDo.Client.Presentation;
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

        builder.Services.AddRepositories("OctoDo.db3");

        builder.Services.AddSingleton<UserInfoViewModel>();
        builder.Services.AddSingleton<UserInfoPage>();

        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}
