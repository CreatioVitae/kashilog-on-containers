using Database.Kashilog;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Repository.Kashilog;

public static class StartupExtensionLibrary {
    public static IServiceCollection AddScopedServicesFromKashilogRepository(this IServiceCollection services, IConfiguration configuration, IDefaultEnvironmentAccessor defaultEnvironment) =>
        services
            .AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes())
            .AddSqlManagerFromKashilogDatabase(configuration, defaultEnvironment);
}
