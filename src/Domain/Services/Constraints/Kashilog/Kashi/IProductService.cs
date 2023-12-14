using DomainObject.Kashilog.Kashi.QueryResults;

namespace Service.Constraints.Kashilog.Kashi;

public interface IProductService {
    ValueTask<IEnumerable<ProductResult>?> GetAllProductsAsync();
    IAsyncEnumerable<ProductResult> GetAllProductsAsyncUsingIAsyncEnumerable();
    ValueTask<ProductResult?> GetProductByIdAsync(int id);
}
