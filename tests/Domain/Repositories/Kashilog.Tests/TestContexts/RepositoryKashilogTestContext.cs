using Database.Kashilog.DbContexts;

namespace Repository.Kashilog.Tests.TestContexts;

public class RepositoryKashilogTestContext : IDisposable {
    public SqlManager<KashilogContext> GetSqlManager() =>
        new((connectionString, isDevelopment) => new KashilogContext(connectionString, isDevelopment), GetConfiguration().GetAvailableValueByKey("kashilogDatabaseConfig:connectionString"));

    public IConfiguration GetConfiguration() =>
        AssemblyInitializer.Configuration;

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
