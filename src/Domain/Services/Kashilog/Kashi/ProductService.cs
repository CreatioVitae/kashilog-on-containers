using Database.Kashilog.DbContexts;
using Database.Kashilog.EntityDataModels;
using DomainObject.Kashilog.Contexts;
using DomainObject.Kashilog.Kashi.CommandParameters;
using DomainObject.Kashilog.Kashi.Entities;
using DomainObject.Kashilog.Kashi.QueryResults;
using Repository.Constraints.Kashilog.Enterprise;
using Repository.Constraints.Kashilog.Kashi;
using Service.Constraints.Kashilog.Kashi;

namespace Service.Kashilog.Kashi;

public class ProductService(IProductsRepository productsRepository, ICompaniesRepository companiesRepository, RequestContext requestContext, SqlManager<KashilogContext> sqlManager) : IService, IProductService {
    private IProductsRepository ProductsRepository { get; } = productsRepository;

    private ICompaniesRepository CompaniesRepository { get; } = companiesRepository;

    private RequestContext RequestContext { get; } = requestContext;

    private SqlManager<KashilogContext> SqlManager { get; } = sqlManager;

    public async ValueTask<IEnumerable<ProductResult>?> GetAllProductsAsync() {
        var allProducts = (await ProductsRepository.FindAllProductAsync()).AsList();

        if (!allProducts.Any()) {
            return null;
        }

        var allProductId = allProducts.Select(product => product.ProductId).ToList();

        var referencedProductTextures = await ProductsRepository.FindProductTextureInProductIdsAsync(allProductId);

        var referencedProductTastes = await ProductsRepository.FindProductTasteInProductIdsAsync(allProductId);

        static IEnumerable<int> GetReferencedCompanyIds(List<Product> allProducts) =>
            allProducts.Select(m => m.MakerCompanyId).AsEnumerable().Union(allProducts.Select(m => m.PublisherCompanyId).AsEnumerable());

        var referencedCompanies = (await CompaniesRepository.FindCompaniesInIdsAsync(GetReferencedCompanyIds(allProducts).Distinct())).AsList();

        return allProducts.Select(product =>
            new ProductResult(
                product,
                referencedCompanies.SingleOrDefault(m => m.CompanyId == product.MakerCompanyId),
                referencedCompanies.SingleOrDefault(m => m.CompanyId == product.PublisherCompanyId),
                referencedProductTextures.Where(m => m.ProductId == product.ProductId),
                referencedProductTastes.Where(m => m.ProductId == product.ProductId)
            ));
    }

    public async IAsyncEnumerable<ProductResult> GetAllProductsAsyncUsingIAsyncEnumerable() {
        var allProducts = (await ProductsRepository.FindAllProductAsync()).AsList();

        if (!allProducts.Any()) {
            yield break;
        }

        var allProductId = allProducts.Select(product => product.ProductId).ToList();

        var referencedProductTextures = (await ProductsRepository.FindProductTextureInProductIdsAsync(allProductId)).AsList();

        var referencedProductTastes = (await ProductsRepository.FindProductTasteInProductIdsAsync(allProductId)).AsList();

        static IEnumerable<int> GetReferencedCompanyIds(List<Product> allProducts) => allProducts.Select(m => m.MakerCompanyId).AsEnumerable().Union(allProducts.Select(m => m.PublisherCompanyId).AsEnumerable());

        var referencedCompanies = (await CompaniesRepository.FindCompaniesInIdsAsync(GetReferencedCompanyIds(allProducts).Distinct())).AsList();

        foreach (var product in allProducts) {
            yield return new ProductResult(
                product,
                referencedCompanies.SingleOrDefault(m => m.CompanyId == product.MakerCompanyId),
                referencedCompanies.SingleOrDefault(m => m.CompanyId == product.PublisherCompanyId),
                referencedProductTextures.Where(m => m.ProductId == product.ProductId),
                referencedProductTastes.Where(m => m.ProductId == product.ProductId)
            );
        }
    }

    public async ValueTask<ProductResult?> GetProductByIdAsync(int id) {

        var product = await ProductsRepository.FindProductByIdAsync(id);

        return product == null
            ? null
            : new ProductResult(
                product,
                (await CompaniesRepository.FindCompanyByIdAsync(product.MakerCompanyId)).SingleOrDefault(),
                (await CompaniesRepository.FindCompanyByIdAsync(product.PublisherCompanyId)).SingleOrDefault(),
                (await ProductsRepository.FindProductTextureByProductIdAsync(product.ProductId)).AsList(),
                (await ProductsRepository.FindProductTasteByProductIdAsync(product.ProductId)).AsList()
            );
    }

    //public async ValueTask<ProductResult?> CreateProductAsync(ProductCreateParameters parameters) {
    //    await using var transaction = await SqlManager.BeginScopedTransactionAsync();

        //var productEntity = new MstProduct() { };



//    public int ProductId { get; set; }

//    public int ProductLineUpId { get; set; }

//    public int ProductRevision { get; set; }

//    public DateTime ValidBeginDateTime { get; set; }

//    public DateTime ValidEndDateTime { get; set; }

//    public string ProductName { get; set; } = null!;

//    public int LargeCategory { get; set; }

//    public int MiddleCategory { get; set; }

//    public int SmallCategory { get; set; }

//    public decimal UnitPrice { get; set; }

//    public decimal Amount { get; set; }

//    public int AmountType { get; set; }

//    public string Description { get; set; } = null!;

//    public int MakerCompanyId { get; set; }

//    public int PublisherCompanyId { get; set; }

//    public DateTime CreatedTimeStamp { get; set; }

//    public DateTime LastUpdatedTimeStamp { get; set; }

//    public int LastUpdatedSign { get; set; }


//}





//SqlManager.DbContext.MstProducts.AddAsync(new() { })

        //var product = new Product(
        //               parameters.ProductName,
        //                          parameters.LargeCategory,
        //                          parameters.MiddleCategory,
        //                          parameters.SmallCategory,
        //                          parameters.UnitPrice,
        //                          parameters.Amount,
        //                          parameters.AmountType,
        //                          parameters.Description,
        //                          parameters.MakerCompanyId,
        //                          parameters.PublisherCompanyId,
        //                          parameters.ValidBeginDateTime,
        //                          parameters.ValidEndDateTime,
        //                          parameters.ProductRevision,
        //                          parameters.ProductId
        //                      );

        //var createdProduct = await ProductsRepository.CreateProductAsync(product);

        //return createdProduct == null
        //    ? null
        //    : new ProductResult(
        //                       createdProduct,
        //                                      (await CompaniesRepository.FindCompanyByIdAsync(createdProduct.MakerCompanyId)).SingleOrDefault(),
        //                                      (await CompaniesRepository.FindCompanyByIdAsync(createdProduct.PublisherCompanyId)).SingleOrDefault(),
        //                                      (await ProductsRepository.FindProductTextureByProductIdAsync(createdProduct.ProductId)).AsList(),
        //                                      (await ProductsRepository.FindProductTasteByProductIdAsync(createdProduct.ProductId)).AsList()
        //                                  );
    //}
}
