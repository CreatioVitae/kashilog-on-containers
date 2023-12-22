using DomainObject.Kashilog.Kashi.Entities;
using Repository.Constraints.Kashilog.Kashi;

namespace Repository.Kashilog.Kashi;
public class ProductsRepository(SqlManager<KashilogContext> sqlManager) : IRepository, IProductsRepository {

    private SqlManager<KashilogContext> KashilogSqlManager { get; } = sqlManager;

    public Task<IEnumerable<Product>> FindAllProductAsync() =>
        KashilogSqlManager.SelectAsync<Product>($"""
             SELECT
                 ProductId            AS ProductId,
                 ProductRevision      AS ProductRevision,
                 ValidBeginDateTime   AS ValidBeginDateTime,
                 ValidEndDateTime     AS ValidEndDateTime,
                 ProductName          AS ProductName,
                 LargeCategory        AS LargeCategory,
                 MiddleCategory       AS MiddleCategory,
                 SmallCategory        AS SmallCategory,
                 UnitPrice            AS UnitPrice,
                 Amount               AS Amount,
                 AmountType           AS AmountType,
                 Description          AS Description,
                 MakerCompanyId       AS MakerCompanyId,
                 PublisherCompanyId   AS PublisherCompanyId
             FROM
                 kashi.MstProduct
             """);

    public Task<Product?> FindProductByIdAsync(int id) =>
        KashilogSqlManager.SelectSingleOrDefaultAsync<Product>($"""
            SELECT
                ProductId            AS ProductId,
                ProductRevision      AS ProductRevision,
                ValidBeginDateTime   AS ValidBeginDateTime,
                ValidEndDateTime     AS ValidEndDateTime,
                ProductName          AS ProductName,
                LargeCategory        AS LargeCategory,
                MiddleCategory       AS MiddleCategory,
                SmallCategory        AS SmallCategory,
                UnitPrice            AS UnitPrice,
                Amount               AS Amount,
                AmountType           AS AmountType,
                Description          AS Description,
                MakerCompanyId       AS MakerCompanyId,
                PublisherCompanyId   AS PublisherCompanyId
            FROM
                kashi.MstProduct
            WHERE
                ProductId = @Id
            """, new { Id = id });

    public Task<IEnumerable<ProductTaste>> FindProductTasteByProductIdAsync(int productId) =>
        KashilogSqlManager.SelectAsync<ProductTaste>($"""
            SELECT
                ProductTaste.ProductId  AS ProductId,
                ProductTaste.TasteId    AS TasteId,
                Taste.TasteName         AS TasteName,
                ProductTaste.Value      AS Value
            FROM
                kashi.MstProductTaste ProductTaste
            INNER JOIN
                Kashi.CmnTaste Taste
            ON
                ProductTaste.TasteId = Taste.TasteId
            WHERE
                ProductTaste.ProductId = @ProductId
            """,
            new { ProductId = productId });

    public Task<IEnumerable<ProductTaste>> FindProductTasteInProductIdsAsync(IEnumerable<int> productIds) =>
        KashilogSqlManager.SelectAsync<ProductTaste>($"""
            SELECT
                ProductTaste.ProductId  AS ProductId,
                ProductTaste.TasteId    AS TasteId,
                Taste.TasteName         AS TasteName,
                ProductTaste.Value      AS Value
            FROM
              kashi.MstProductTaste ProductTaste
            INNER JOIN
                Kashi.CmnTaste Taste
            ON
                ProductTaste.TasteId = Taste.TasteId
            WHERE
                ProductTaste.ProductId In @ProductIds
            """, new { ProductIds = productIds });

    public Task<IEnumerable<ProductTexture>> FindProductTextureByProductIdAsync(int productId) =>
        KashilogSqlManager.SelectAsync<ProductTexture>($"""
            SELECT
                ProductTexture.ProductId    AS ProductId,
                ProductTexture.TextureId    AS TextureId,
                Texture.TextureName         AS TextureName,
                ProductTexture.Value        AS Value
            FROM
                kashi.MstProductTexture ProductTexture
            INNER JOIN
                Kashi.CmnTexture Texture
            ON
                ProductTexture.TextureId = Texture.TextureId
            WHERE
                ProductTexture.ProductId = @ProductId
            """, new { ProductId = productId });

    public Task<IEnumerable<ProductTexture>> FindProductTextureInProductIdsAsync(IEnumerable<int> productIds) =>
        KashilogSqlManager.SelectAsync<ProductTexture>($"""
            SELECT
                ProductTexture.ProductId    AS ProductId,
                ProductTexture.TextureId    AS TextureId,
                Texture.TextureName         AS TextureName,
                ProductTexture.Value        AS Value
            FROM
                kashi.MstProductTexture ProductTexture
            INNER JOIN
                Kashi.CmnTexture Texture
            ON
                ProductTexture.TextureId = Texture.TextureId
            WHERE
                ProductTexture.ProductId In @ProductIds
            """, new { ProductIds = productIds });

    public Task<ProductCurrentKey?> FindProductCurrentKeyAsync() =>
        KashilogSqlManager.SelectFirstOrDefaultAsync<ProductCurrentKey>($"""
            SELECT
                ProductLineUpId AS ProductLineUpId,
                ProductRevision AS ProductRevision
            FROM
                kashi.MstProduct
            WHERE
                ProductLineUpId = (SELECT MAX(ProductLineUpId) FROM kashi.MstProduct)
            ORDER BY
                ProductRevision DESC
            """);
}
