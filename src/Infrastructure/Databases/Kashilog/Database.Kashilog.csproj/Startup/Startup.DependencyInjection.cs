using Database.Kashilog.DbContexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// ReSharper disable once CheckNamespace
namespace Database.Members;

public static class StartupExtensionLibrary {
    public static IServiceCollection AddSqlManagerFromKashilogDatabase(this IServiceCollection services, IConfiguration configuration, IDefaultEnvironmentAccessor defaultEnvironment) =>
        services.AddSqlManager(
            (conn, isDevelopment) => new KashilogContext(conn, isDevelopment),
            configuration,
            nameof(KashilogContext),
            defaultEnvironment
        );
}
