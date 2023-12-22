using DomainObject.Kashilog.ConstantValues.Kashi;
using DomainObject.Kashilog.Kashi.CommandParameters;
using Repository.Kashilog.Kashi;
using Repository.Kashilog.Tests.TestContexts;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Repository.Kashilog.Tests.Kashi;
public class ProductTest(RepositoryKashilogTestContext testContext) : IDisposable, IClassFixture<RepositoryKashilogTestContext> {
    RepositoryKashilogTestContext TestContext { get; } = testContext;

    [Fact(DisplayName = "Idを指定して製品を取得する。正常完了ケース")]
    public async Task FindProductByIdAsyncTest_CaseComplete() {
        await using var sqlManager = TestContext.GetSqlManager();

        var repository = new ProductsRepository(sqlManager);
        var actual = await repository.FindProductByIdAsync(1);
        
        Assert.Equal(
            new() {
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
                Description = $"軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。{Environment.NewLine}ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。",
                MakerCompanyId = 1,
                PublisherCompanyId = 1
            },
            actual);
    }

    [Fact(DisplayName = "ProductCreateParameters検証_商品名桁数範囲外")]
    public void ProductCreateParametersValidationTest_CaseProductNameLengthOutOfRange() {
        var createParam = new ProductCreateParameters() {
            ValidBeginDateTime = new DateTime(2021, 1, 1),
            ValidEndDateTime = new DateTime(2021, 12, 31),
            ProductName = new string('a', ProductsConstraintValues.ProductName.MaximumLength + 1),
            LargeCategory = LargeCategory.TheWestConfectionery,
            MiddleCategory = MiddleCategory.Chocolate,
            SmallCategory = SmallCategory.QuasiChocolate,
            UnitPrice = 278.0000M,
            Amount = 9.00M,
            AmountType = AmountType.Pack,
            Description = $"軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。{Environment.NewLine}ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。",
            MakerCompanyId = 1,
            PublisherCompanyId = 1
        };

        var e =  Assert.Throws<ValidationException>(() => ObjectValidator.ThrowIfInvalid(createParam));
        Assert.Equal(ProductsConstraintValues.ProductName.LengthOutOfRangeErrorMessage, e.Message);
    }

    [Fact(DisplayName = "ProductCreateParameters検証_適用開始日最小値未満")]
    public void ProductCreateParametersValidationTest_CaseValidBeginDateTimeIsLessThanMinValue() {
        var createParam = new ProductCreateParameters() {
            ValidBeginDateTime = new DateTime(1, 1, 1),
            ValidEndDateTime = new DateTime(2021, 12, 31),
            ProductName = "ポッキーチョコレート",
            LargeCategory = LargeCategory.TheWestConfectionery,
            MiddleCategory = MiddleCategory.Chocolate,
            SmallCategory = SmallCategory.QuasiChocolate,
            UnitPrice = 278.0000M,
            Amount = 9.00M,
            AmountType = AmountType.Pack,
            Description = $"軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。{Environment.NewLine}ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。",
            MakerCompanyId = 1,
            PublisherCompanyId = 1
        };

        var e = Assert.Throws<ValidationException>(() => ObjectValidator.ThrowIfInvalid(createParam));

        Assert.Equal($"{nameof(ProductCreateParameters.ValidBeginDateTime)}は{SqlDateTime.MinValue.Value}以上の値を設定してください。", e.Message);
    }


    [Fact(DisplayName = "ProductCreateParameters検証_適用終了日最小値未満")]
    public void ProductCreateParametersValidationTest_CaseValidEndDateTimeIsLessThanMinValue() {
        var createParam = new ProductCreateParameters() {
            ValidBeginDateTime = new DateTime(1, 1, 1),
            ValidEndDateTime = new DateTime(1, 1, 1),
            ProductName = "ポッキーチョコレート",
            LargeCategory = LargeCategory.TheWestConfectionery,
            MiddleCategory = MiddleCategory.Chocolate,
            SmallCategory = SmallCategory.QuasiChocolate,
            UnitPrice = 278.0000M,
            Amount = 9.00M,
            AmountType = AmountType.Pack,
            Description = $"軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。{Environment.NewLine}ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。",
            MakerCompanyId = 1,
            PublisherCompanyId = 1
        };

        var e = Assert.Throws<ValidationException>(() => ObjectValidator.ThrowIfInvalid(createParam));

        Assert.Equal(
            $"{nameof(ProductCreateParameters.ValidBeginDateTime)}は{SqlDateTime.MinValue.Value}以上の値を設定してください。{Environment.NewLine}{nameof(ProductCreateParameters.ValidEndDateTime)}は{SqlDateTime.MinValue.Value}以上の値を設定してください。",
            e.Message
        );
    }

    public void Dispose() =>
        GC.SuppressFinalize(this);
}
