using Database.Kashilog;

// ReSharper disable once CheckNamespace
namespace Api.Kashilog;

public static class StartupExtensionLibrary {
    internal static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration) {
        //SqlManager<TDatabaseConnection>
        services
            .AddSqlManagerFromKashilogDatabase(configuration, DefaultWebEnvironment.WebApps);

        //Services,Repositories
        services.AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes());

        // HttpClientFactory

        //Logger.

        return services;
    }
}
