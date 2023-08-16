using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OctoDo.Authentication.Api.Business.Configuration;

namespace OctoDo.Authentication.Api.Extensions;
public static class ServiceCollectionExtensions
{
    public static OptionsBuilder<TCustomConfiguration> AddConfiguration<TCustomConfiguration>(this IServiceCollection services, string sectionName, ServiceLifetime serviceLifetime)
        where TCustomConfiguration : class, ICustomApplicationSetting, new()
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        if (string.IsNullOrWhiteSpace(sectionName))
        {
            throw new ArgumentNullException(nameof(sectionName));
        }

        services.Add(new ServiceDescriptor(typeof(TCustomConfiguration), provider =>
        {
            var options = provider.GetRequiredService<IOptions<TCustomConfiguration>>();
            return options.Value;
        }, serviceLifetime));

        return services.AddOptions<TCustomConfiguration>().Configure<IConfiguration>((customSetting, configuration) =>
        {
            configuration.GetSection(sectionName).Bind(customSetting);
        });
    }
}
