using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Repository.Kashilog;

public static class StartupExtensionLibrary {
    public static IServiceCollection AddScopedServicesFromKashilogService(this IServiceCollection services) =>
        services.AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes());
}
