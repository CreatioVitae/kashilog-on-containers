using Database.Kashilog.DbContexts;

namespace Api.Kashilog.Tests.TestContexts;

public class ApiKashilogTestContext : IDisposable {
    public SqlManager<KashilogContext> GetSqlManager() =>
        new((connectionString, isDevelopment) => new KashilogContext(connectionString, isDevelopment), GetConfiguration().GetAvailableValueByKey($"kashilogDatabaseConfig:connectionString"));

    public IConfiguration GetConfiguration() =>
        AssemblyInitializer.Configuration;

    public DateTime GetDatetimeCurrent() =>
        TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
            TimeZoneInfo.FindSystemTimeZoneById(GetConfiguration()
                .GetAvailableValueByKey($"requestContextSettings:timezoneId")));

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
