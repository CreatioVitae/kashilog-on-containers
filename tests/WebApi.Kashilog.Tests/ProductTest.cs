using MicroORMWrapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using Api.Kashilog.Test.DatabaseConnections;
using Xunit;

namespace Api.Kashilog.Tests {

    public class ProductTest {
        SqlManager<KashilogConnection> SqlManager { get; }

        public ProductTest() {
            var testRootPath = new FileInfo(typeof(EnvironmentInfo).Assembly.Location).Directory.FullName;

            var configuration = new ConfigurationBuilder().SetBasePath(testRootPath).AddJsonFile(EnvironmentInfo.AppSettingsFileName, optional: false).AddEnvironmentVariables().Build();

            SqlManager = new SqlManager<KashilogConnection>(new KashilogConnection() {
                ConnectionName = nameof(KashilogConnection),
                DbConnection = new SqlConnection(configuration[$"kashilogDatabaseConfig:connectionString"])
            });
        }

        [Fact]
        public void AlwaysTrueTest() {
            var expect = true;

            Assert.True(expect);
        }

        [Fact]
        public void AlwaysFalseTest() {
            var expect = false;

            Assert.False(expect);
        }

        [Fact]
        public async Task DatabaseConnectionTest() {
            var expectCount = 0;

            var actualCount = await SqlManager.GetValueAsync<int>(@"SELECT COUNT(*) FROM kashi.MstProduct;");

            Assert.Equal(expectCount, actualCount);
        }
    }
}
