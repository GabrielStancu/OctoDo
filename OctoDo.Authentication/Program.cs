using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OctoDo.Authentication.Api.Business.Authentication;
using OctoDo.Authentication.Api.Business.Configuration;
using OctoDo.Authentication.Api.Business.Identity;
using OctoDo.Authentication.Api.Business.Jwt;
using OctoDo.Authentication.Api.Data;
using OctoDo.Authentication.Api.Extensions;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((context, services) =>
    {
        // Identity
        services.AddDbContext<AppIdentityDbContext>(options =>
            options.UseSqlServer(context.Configuration["Identity:ConnectionString"]));
        services.AddIdentityCore<AppUser>(options => {
            options.SignIn.RequireConfirmedAccount = false;
        }).AddEntityFrameworkStores<AppIdentityDbContext>();

        // Services
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<IJwtService, JwtService>();

        // Configurations
        services.AddConfiguration<JwtSettings>("Jwt", ServiceLifetime.Singleton);
    })
    .Build();

host.Run();
