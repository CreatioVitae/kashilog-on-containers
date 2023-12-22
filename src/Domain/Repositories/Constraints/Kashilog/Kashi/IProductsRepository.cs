using DomainObject.Kashilog.Kashi.Entities;

namespace Repository.Constraints.Kashilog.Kashi;
public interface IProductsRepository {
    Task<IEnumerable<Product>> FindAllProductAsync();
    Task<Product?> FindProductByIdAsync(int id);
    Task<IEnumerable<ProductTaste>> FindProductTasteByProductIdAsync(int productId);
    Task<IEnumerable<ProductTaste>> FindProductTasteInProductIdsAsync(IEnumerable<int> productIds);
    Task<IEnumerable<ProductTexture>> FindProductTextureByProductIdAsync(int productId);
    Task<IEnumerable<ProductTexture>> FindProductTextureInProductIdsAsync(IEnumerable<int> productIds);
    Task<ProductCurrentKey?> FindProductCurrentKeyAsync();
}
