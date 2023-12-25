using Api.Kashilog.Tests.TestContexts;
using Cache.Kashilog.Dummies;

namespace Api.Kashilog.Tests; 
public class ProductTest(ApiKashilogTestContext testContext) : IDisposable, IClassFixture<ApiKashilogTestContext> {
    ApiKashilogTestContext TestContext { get; } = testContext;

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

    [Fact(DisplayName = "SQLServer接続テスト")]
    public async Task DatabaseConnectionTest() {
        await using var sqlManager = TestContext.GetSqlManager();

        var expectCount = 0;

        var actualCount = await sqlManager.GetValueAsync<int>(@"SELECT COUNT(*) FROM kashi.MstProduct;");

        Assert.Equal(expectCount, actualCount);
    }

    [Fact(DisplayName = "UseCacheテスト")]
    public async Task UseCacheTestAsync() {
        var cache = new DummyCache(TestContext.GetRedisServer());

        const string fooFieldValue = "foo";
        const string barFieldValue = "bar";
        const string bazFieldValue = "baz";

        var (expectFoo, expectBar, expectBaz) = (new Dummy(1, fooFieldValue), new Dummy(2, barFieldValue), new Dummy(3, bazFieldValue));

        await cache.StoreAsync(fooFieldValue, expectFoo);
        await cache.StoreAsync(barFieldValue, expectBar);
        await cache.StoreAsync(bazFieldValue, expectBaz);

        Assert.Equal(expectFoo, (await cache.GetAsync(fooFieldValue)).Value);
        Assert.Equal(expectBar, (await cache.GetAsync(barFieldValue)).Value);
        Assert.Equal(expectBaz, (await cache.GetAsync(bazFieldValue)).Value);
    }

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
