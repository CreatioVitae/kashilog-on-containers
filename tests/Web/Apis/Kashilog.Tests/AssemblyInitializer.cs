using Api.Kashilog.Tests.TestData;
using ApiClient.Dummy.ImageClients;
using Database.Kashilog.DbContexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RedisServerWrapper;
using Service.Extensions.DependencyInjection.Options;
using System.IO;
using System.Net.Http;
using Xunit.Abstractions;
using Xunit.Sdk;

[assembly: TestFramework("Api.Kashilog.Tests.AssemblyInitializer", "Api.Kashilog.Tests")]
namespace Api.Kashilog.Tests;

public class AssemblyInitializer : XunitTestFramework, IDisposable {
    public static SqlManager<KashilogContext> SqlManager { get; set; } = null!;

    static TestServer InternalTestServer { get; set; } = null!;

    public static HttpClient HttpClient { get; private set; } = null!;

    public static IConfiguration Configuration { get; set; } = null!;

    public static HttpClient DummyImageHttpClient { get; private set; } = null!;

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

        SqlManager.Execute(TestDataCreateScripts.TeardownKashilog);
        SqlManager.Execute(TestDataCreateScripts.SetupKashilog);

        RedisServer = new RedisServer(Configuration.GetRedisSettings());

        InternalTestServer = new TestServer(
            Microsoft.AspNetCore.WebHost
                .CreateDefaultBuilder()
                .ConfigureAppConfiguration((_, config) =>
                    config
                        .SetBasePath(testRootPath)
                        .AddJsonFile(EnvironmentInfo.AppSettingsFileName)
                        .AddEnvironmentVariables())
                .UseStartup<Startup>()
                .UseContentRoot(testRootPath));

        HttpClient = InternalTestServer.CreateClient();

        var options = Configuration
            .GetSection(ApiClientOptions.GetDefaultSection(nameof(DummyImageClient)))
            .GetAvailable<ApiClientOptions>();

        DummyImageHttpClient = new() { BaseAddress = new(options.BaseAddress) };
    }

    public new void Dispose() {
        SqlManager.Execute(TestDataCreateScripts.TeardownKashilog);
        SqlManager.Dispose();

        base.Dispose();
        GC.SuppressFinalize(this);
    }
}
