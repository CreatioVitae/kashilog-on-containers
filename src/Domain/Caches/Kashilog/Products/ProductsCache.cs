using CloudStructures;
using CloudStructures.Structures;
using DomainObject.Kashilog.Kashi.QueryResults;
using RedisServerWrapper;
using Service.Extensions.DependencyInjection.Markers;

namespace Cache.Kashilog.Products;

public class ProductsCache : ICache {
    readonly (string cacheKey, int daysOfCacheExpiry) _cacheSettings = ("kashi/products", 7);

    readonly RedisString<IEnumerable<ProductResult>> _cache;

    public ProductsCache(RedisServer redis) =>
        _cache = new(redis.Connection, _cacheSettings.cacheKey, TimeSpan.FromDays(_cacheSettings.daysOfCacheExpiry));

    public Task<IEnumerable<ProductResult>> GetOrStoreAsync(Func<Task<IEnumerable<ProductResult>>> occupations) =>
        _cache.GetOrSetAsync(occupations);

    public Task<RedisResult<IEnumerable<ProductResult>>> GetAsync() =>
        _cache.GetAsync();

    public Task StoreAsync(IEnumerable<ProductResult> products) =>
        _cache.SetAsync(products);

    public Task RemoveAsync() =>
        _cache.DeleteAsync();
}
