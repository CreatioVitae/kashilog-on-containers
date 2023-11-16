using Api.Kashilog.Tests.TestContexts;

namespace Api.Kashilog.Tests; 
public class ProductTest : IDisposable, IClassFixture<ApiKashilogTestContext> {
    ApiKashilogTestContext TestContext { get; }

    public ProductTest(ApiKashilogTestContext testContext) =>
        TestContext = testContext;

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
        await using var sqlManager = TestContext.GetSqlManager();

        var expectCount = 0;

        var actualCount = await sqlManager.GetValueAsync<int>(@"SELECT COUNT(*) FROM kashi.MstProduct;");

        Assert.Equal(expectCount, actualCount);
    }

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
