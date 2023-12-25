using Database.Kashilog.DbContexts;
using Microsoft.AspNetCore.TestHost;
using RedisServerWrapper;
using System.IO;
using Xunit.Abstractions;
using Xunit.Sdk;

[assembly: TestFramework("Api.Kashilog.Tests.AssemblyInitializer", "Api.Kashilog.Tests")]
namespace Api.Kashilog.Tests;

public class AssemblyInitializer : XunitTestFramework, IDisposable {
    public static SqlManager<KashilogContext> SqlManager { get; set; } = null!;

    static TestServer InternalTestServer { get; set; } = null!;

    public static IConfiguration Configuration { get; set; } = null!;

    public static RedisServer RedisServer { get; set; } = null!;

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

        RedisServer = new RedisServer(Configuration.GetRedisSettings());
    }

    public new void Dispose() {
        SqlManager.Dispose();

        base.Dispose();
        GC.SuppressFinalize(this);
    }
}
