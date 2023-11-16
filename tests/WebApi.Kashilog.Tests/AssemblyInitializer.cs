using Database.Kashilog.DbContexts;
using System.IO;
using Xunit.Abstractions;
using Xunit.Sdk;

[assembly: TestFramework("Api.Kashilog.Tests.AssemblyInitializer", "Api.Kashilog.Tests")]
namespace Api.Kashilog.Tests;

public class AssemblyInitializer : XunitTestFramework, IDisposable {
    public static SqlManager<KashilogContext> SqlManager { get; set; } = null!;

    public static IConfiguration Configuration { get; set; } = null!;

    public AssemblyInitializer(IMessageSink messageSink) : base(messageSink) {
        var testRootPath = new FileInfo(typeof(AssemblyInitializer).Assembly.Location).Directory?.FullName ?? throw new InvalidProgramException();
        Configuration = new ConfigurationBuilder()
            .SetBasePath(testRootPath).AddJsonFile(EnvironmentInfo.AppSettingsFileName, optional: false).AddEnvironmentVariables().Build();

        static SqlManager<KashilogContext> SetupTestDataAndGetSqlManager(IConfiguration configuration) {
            var sqlManager = new SqlManager<KashilogContext>((connectionString, isDevelopment) =>
                new KashilogContext(connectionString, isDevelopment), configuration.GetAvailableValueByKey($"kashilogDatabaseConfig:connectionString"));

            return sqlManager;
        }

        SqlManager = SetupTestDataAndGetSqlManager(Configuration);
    }

    public new void Dispose() {
        SqlManager.Dispose();

        base.Dispose();
        GC.SuppressFinalize(this);
    }
}
