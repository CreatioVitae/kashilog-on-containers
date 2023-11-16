using Api.Kashilog.Repositories.Enterprise.Companies;
using Api.Kashilog.Repositories.Kashi.Products;
using DomainObject.Kashilog.Kashi.Entities;
using DomainObject.Kashilog.Kashi.QueryResults;
using Service.Extensions.DependencyInjection.Markers;

namespace Api.Kashilog.Services.Kashi {
    public class ProductService : IService {

        private ProductRepository ProductRepository { get; }

        private CompanyRepository CompanyRepository { get; }

        public ProductService(ProductRepository productRepository, CompanyRepository companyRepository) {
            ProductRepository = productRepository;
            CompanyRepository = companyRepository;
        }

        public async ValueTask<IEnumerable<ProductResult>?> GetAllProductsAsync() {
            var allProducts = (await ProductRepository.FindAllProductAsync()).AsList();

            if (!allProducts.Any()) {
                return null;
            }

            var allProductId = allProducts.Select(product => product.ProductId).ToArray();

            var referencedProductTextures = await ProductRepository.FindProductTextureInProductIdsAsync(allProductId);

            var referencedProductTastes = await ProductRepository.FindProductTasteInProductIdsAsync(allProductId);

            static IEnumerable<int> GetReferencedCompanyIds(List<Product> allProducts) => allProducts.Select(m => m.MakerCompanyId).AsEnumerable().Union(allProducts.Select(m => m.PublisherCompanyId).AsEnumerable());

            var referencedCompanies = await CompanyRepository.FindCompanyInIdsAsync(GetReferencedCompanyIds(allProducts).Distinct());

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
            var allProducts = (await ProductRepository.FindAllProductAsync()).AsList();

            if (!allProducts.Any()) {
                yield break;
            }

            var allProductId = allProducts.Select(product => product.ProductId).ToList();

            var referencedProductTextures = await ProductRepository.FindProductTextureInProductIdsAsync(allProductId);

            var referencedProductTastes = await ProductRepository.FindProductTasteInProductIdsAsync(allProductId);

            static IEnumerable<int> GetReferencedCompanyIds(List<Product> allProducts) => allProducts.Select(m => m.MakerCompanyId).AsEnumerable().Union(allProducts.Select(m => m.PublisherCompanyId).AsEnumerable());

            var referencedCompanies = await CompanyRepository.FindCompanyInIdsAsync(GetReferencedCompanyIds(allProducts).Distinct());

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

            var product = (await ProductRepository.FindProductByIdAsync(id)).SingleOrDefault();

            return product == null
                ? null
                : new ProductResult(
                product,
                (await CompanyRepository.FindCompanyByIdAsync(product.MakerCompanyId)).SingleOrDefault(),
                (await CompanyRepository.FindCompanyByIdAsync(product.PublisherCompanyId)).SingleOrDefault(),
                (await ProductRepository.FindProductTextureByProductIdAsync(product.ProductId)).AsList(),
                (await ProductRepository.FindProductTasteByProductIdAsync(product.ProductId)).AsList()
            );
        }
    }
}
