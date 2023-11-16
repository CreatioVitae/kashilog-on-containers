using Api.Kashilog.Repositories.Kashi.Products.Sqls;
using Database.Kashilog.DbContexts;
using DomainObject.Kashilog.Kashi.Entities;
using ORMIntegrator;
using Service.Extensions.DependencyInjection.Markers;

namespace Api.Kashilog.Repositories.Kashi.Products {
    public class ProductRepository : IRepository {

        private SqlManager<KashilogContext> KashilogSqlManager { get; }

        public ProductRepository(SqlManager<KashilogContext> sqlManager) =>
            KashilogSqlManager = sqlManager;

        public Task<IEnumerable<Product>> FindAllProductAsync() =>
            KashilogSqlManager.SelectAsync<Product>($"""
                 Select
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
                 From
                     kashi.MstProduct
                 """);

        public Task<IEnumerable<Product>> FindProductByIdAsync(int id) =>
            KashilogSqlManager.SelectAsync<Product>(SqlForProductResource.FindProductById, new { Id = id });

        public Task<IEnumerable<ProductTaste>> FindProductTasteByProductIdAsync(int productId) =>
            KashilogSqlManager.SelectAsync<ProductTaste>(SqlForProductResource.FindProductTasteByProductId, new { ProductId = productId });

        public Task<IEnumerable<ProductTaste>> FindProductTasteInProductIdsAsync(IEnumerable<int> productIds) =>
            KashilogSqlManager.SelectAsync<ProductTaste>(SqlForProductResource.FindProductTasteInProductIds, new { ProductIds = productIds });

        public Task<IEnumerable<ProductTexture>> FindProductTextureByProductIdAsync(int productId) =>
            KashilogSqlManager.SelectAsync<ProductTexture>(SqlForProductResource.FindProductTextureByProductId, new { ProductId = productId });

        public Task<IEnumerable<ProductTexture>> FindProductTextureInProductIdsAsync(IEnumerable<int> productIds) =>
            KashilogSqlManager.SelectAsync<ProductTexture>(SqlForProductResource.FindProductTextureInProductIds, new { ProductIds = productIds });
    }
}
