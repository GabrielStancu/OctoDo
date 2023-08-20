using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OctoDo.Client.Infrastructure.Data;

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

        builder.Services.AddDbContext<AppDbContext>(options => 
            options.UseSqlite("OctoDo.db"));

        return builder.Build();
    }
}
