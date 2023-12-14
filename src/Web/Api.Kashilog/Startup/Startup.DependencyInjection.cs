using DomainObject.Kashilog.Contexts;
using Repository.Kashilog;

// ReSharper disable once CheckNamespace
namespace Api.Kashilog;

public static class StartupExtensionLibrary {
    internal static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration) {
       
        services
            .AddScopedServicesFromKashilogRepository(configuration, DefaultWebEnvironment.WebApps)
            .AddScopedServicesFromKashilogService()
            .AddScopedServicesFromKashilogWebApi()
            .AddRequestContext<RequestContext>(configuration.GetAvailableValueByKey($"requestContextSettings:timezoneId"));

        return services;
    }

    internal static IServiceCollection AddScopedServicesFromKashilogWebApi(this IServiceCollection services) =>
        services.AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes());
}
