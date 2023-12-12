using Database.Kashilog.DbContexts;
using Repository.Kashilog.Tests.TestData;
using Xunit.Abstractions;
using Xunit.Sdk;

[assembly: TestFramework("Repository.Kashilog.Tests.AssemblyInitializer", "Repository.Kashilog.Tests")]
namespace Repository.Kashilog.Tests;

public class AssemblyInitializer : XunitTestFramework, IDisposable {
    public static SqlManager<KashilogContext> SqlManager { get; set; } = null!;

    public static IConfiguration Configuration { get; set; } = null!;

    public AssemblyInitializer(IMessageSink messageSink) : base(messageSink) {
        var testRootPath = new FileInfo(typeof(AssemblyInitializer).Assembly.Location).Directory?.FullName ?? throw new InvalidProgramException();
        Configuration = new ConfigurationBuilder()
            .SetBasePath(testRootPath).AddJsonFile(EnvironmentInfo.AppSettingsFileName, optional: false).AddEnvironmentVariables().Build();

        Console.WriteLine(Configuration.GetAvailableValueByKey($"kashilogDatabaseConfig:connectionString"));

        static SqlManager<KashilogContext> SetupTestDataAndGetSqlManager(IConfiguration configuration) {
            var sqlManager = new SqlManager<KashilogContext>((connectionString, isDevelopment) =>
                new KashilogContext(connectionString, isDevelopment), configuration.GetAvailableValueByKey($"kashilogDatabaseConfig:connectionString"));

            return sqlManager;
        }

        SqlManager = SetupTestDataAndGetSqlManager(Configuration);

        SqlManager.Execute(TestDataCreateScripts.TeardownKashilog);
        SqlManager.Execute(TestDataCreateScripts.SetupKashilog);
    }

    public new void Dispose() {
        SqlManager.Execute(TestDataCreateScripts.TeardownKashilog);
        SqlManager.Dispose();

        base.Dispose();
        GC.SuppressFinalize(this);
    }
}
