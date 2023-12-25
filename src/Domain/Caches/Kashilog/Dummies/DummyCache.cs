using CloudStructures;
using CloudStructures.Structures;
using RedisServerWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Cache.Kashilog.Dummies;

public class DummyCache : ICache {
    readonly (string cacheKey, int hoursOfCacheExpiry) _cacheSettings = ("members/dummies", 24);

    readonly RedisDictionary<string, Dummy> _cache;

    public DummyCache(RedisServer redis) =>
        _cache = new(redis.Connection, _cacheSettings.cacheKey, TimeSpan.FromHours(_cacheSettings.hoursOfCacheExpiry));

    public Task<RedisResult<Dummy>> GetAsync(string fieldValue) =>
        _cache.GetAsync(fieldValue);

    public Task StoreAsync(string fieldValue, Dummy dummies) =>
        _cache.SetAsync(fieldValue, dummies);
}

[method: SetsRequiredMembers]
[method: JsonConstructor]
public record Dummy(int Id, string Name) {
    [Required]
    public required int Id { get; init; } = Id;

    [Required]
    public required string Name { get; init; } = Name;
}
