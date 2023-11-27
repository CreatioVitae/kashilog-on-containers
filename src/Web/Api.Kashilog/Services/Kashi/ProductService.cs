using Api.Kashilog.Repositories.Enterprise.Companies;
using DomainObject.Kashilog.Kashi.Entities;
using DomainObject.Kashilog.Kashi.QueryResults;
using Repository.Constraints.Kashilog.Kashi;
using Service.Extensions.DependencyInjection.Markers;

namespace Api.Kashilog.Services.Kashi; 

public class ProductService : IService {

    private IProductsRepository ProductsRepository { get; }

    private CompanyRepository CompanyRepository { get; }

    public ProductService(IProductsRepository productsRepository, CompanyRepository companyRepository) {
        ProductsRepository = productsRepository;
        CompanyRepository = companyRepository;
    }

    public async ValueTask<IEnumerable<ProductResult>?> GetAllProductsAsync() {
        var allProducts = (await ProductsRepository.FindAllProductAsync()).AsList();

        if (!allProducts.Any()) {
            return null;
        }

        var allProductId = allProducts.Select(product => product.ProductId).ToList();

        var referencedProductTextures = await ProductsRepository.FindProductTextureInProductIdsAsync(allProductId);

        var referencedProductTastes = await ProductsRepository.FindProductTasteInProductIdsAsync(allProductId);

        static IEnumerable<int> GetReferencedCompanyIds(List<Product> allProducts) => allProducts.Select(m => m.MakerCompanyId).AsEnumerable().Union(allProducts.Select(m => m.PublisherCompanyId).AsEnumerable());

        var referencedCompanies = (await CompanyRepository.FindCompanyInIdsAsync(GetReferencedCompanyIds(allProducts).Distinct())).AsList();

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

        var referencedCompanies = (await CompanyRepository.FindCompanyInIdsAsync(GetReferencedCompanyIds(allProducts).Distinct())).AsList();

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
                (await CompanyRepository.FindCompanyByIdAsync(product.MakerCompanyId)).SingleOrDefault(),
                (await CompanyRepository.FindCompanyByIdAsync(product.PublisherCompanyId)).SingleOrDefault(),
                (await ProductsRepository.FindProductTextureByProductIdAsync(product.ProductId)).AsList(),
                (await ProductsRepository.FindProductTasteByProductIdAsync(product.ProductId)).AsList()
            );
    }
}
