using Database.Kashilog.DbContexts;
using RedisServerWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.Net.Http;

namespace Api.Kashilog.Tests.TestContexts;

public class ApiKashilogTestContext : IDisposable {
    public HttpClient HttpClient =>
        AssemblyInitializer.HttpClient;

    public HttpClient DummyImageHttpClient =>
        AssemblyInitializer.DummyImageHttpClient;

    public SqlManager<KashilogContext> GetSqlManager() =>
        new((connectionString, isDevelopment) => new KashilogContext(connectionString, isDevelopment), GetConfiguration().GetAvailableValueByKey($"kashilogDatabaseConfig:connectionString"));

    public IConfiguration GetConfiguration() =>
        AssemblyInitializer.Configuration;

    public RedisServer GetRedisServer() =>
        AssemblyInitializer.RedisServer;

    public DateTime GetDatetimeCurrent() =>
        TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
            TimeZoneInfo.FindSystemTimeZoneById(GetConfiguration()
                .GetAvailableValueByKey($"requestContextSettings:timezoneId")));

    public RequestContext CreateRequestContextDefault() =>
        IRequestContext.CreateRequestContext<RequestContext>(GetConfiguration().GetAvailableValueByKey($"requestContextSettings:timezoneId"));

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
