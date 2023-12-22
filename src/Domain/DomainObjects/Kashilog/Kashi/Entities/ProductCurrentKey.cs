namespace DomainObject.Kashilog.Kashi.Entities;

public record ProductCurrentKey(int ProductLineUpId, int ProductRevision) {
    public ProductCurrentKey GetNextLineUp() =>
        new (ProductLineUpId: ProductLineUpId + 1, ProductRevision: 1);

    public ProductCurrentKey GetNextRevision() =>
        this with { ProductRevision = ProductRevision + 1 };
}
