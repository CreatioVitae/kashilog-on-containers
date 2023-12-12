using DomainObject.Kashilog.ConstantValues.Kashi;
using DomainObject.Kashilog.Kashi.Entities;
using Repository.Kashilog.Kashi;
using Repository.Kashilog.Tests.TestContexts;

namespace Repository.Kashilog.Tests.Kashi;
public class ProductTest(RepositoryKashilogTestContext testContext) : IDisposable, IClassFixture<RepositoryKashilogTestContext> {
    RepositoryKashilogTestContext TestContext { get; } = testContext;

    [Fact(DisplayName = "Idを指定して製品を取得する。正常完了ケース")]
    public async Task FindProductByIdAsyncTest_CaseComplete() {
        await using var sqlManager = TestContext.GetSqlManager();

        var repository = new ProductsRepository(sqlManager);
        var product = await repository.FindProductByIdAsync(1);


        var expected = new Product() {
            ProductId = 1,
            ProductRevision = 1,
            ValidBeginDateTime = new DateTime(1966, 1, 1),
            ValidEndDateTime = new DateTime(2999, 12, 31),
            ProductName = "ポッキーチョコレート",
            LargeCategory = LargeCategory.TheWestConfectionery,
            MiddleCategory = MiddleCategory.Chocolate,
            SmallCategory = SmallCategory.QuasiChocolate,
            UnitPrice = 278.0000M,
            Amount = 9.00M,
            AmountType = AmountType.Pack,
            Description = "軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。",
            MakerCompanyId = 1,
            PublisherCompanyId = 1
        };

        Assert.NotNull(product);

        Assert.Equal(expected.ProductId, product.ProductId);
        Assert.Equal(expected.ProductRevision, product.ProductRevision);
        Assert.Equal(expected.ValidBeginDateTime, product.ValidBeginDateTime);
        Assert.Equal(expected.ValidEndDateTime, product.ValidEndDateTime);


        //Assert.Equal(
        //    new () {
        //        ProductId = 1,
        //        ProductRevision = 1,
        //        ValidBeginDateTime = new DateTime(1966, 1, 1),
        //        ValidEndDateTime = new DateTime(2999, 12, 31),
        //        ProductName = "ポッキーチョコレート",
        //        LargeCategory = LargeCategory.TheWestConfectionery,
        //        MiddleCategory = MiddleCategory.Chocolate,
        //        SmallCategory = SmallCategory.QuasiChocolate,
        //        UnitPrice = 278.0000M,
        //        Amount = 9.00M,
        //        AmountType = AmountType.Pack,
        //        Description = "軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。\r\nポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。",
        //        MakerCompanyId = 1,
        //        PublisherCompanyId = 1
        //    },
        //    product);
    }

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
