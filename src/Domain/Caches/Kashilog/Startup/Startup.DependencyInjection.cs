using Microsoft.Extensions.DependencyInjection;
using RedisServerWrapper;
using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Cache.Kashilog;

public static class StartupExtensionLibrary {
    public static IServiceCollection AddScopedServicesFromKashilogCache(this IServiceCollection services, RedisSettings redisSettings) =>
        services
            .AddRedisServer(redisSettings)
            .AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes());
}
