namespace DomainObject.Kashilog.Contexts.DomainIndicators;

public class DomainIndicator(RequestContext context) {

    public ProductCachePurger ProductCachePurger { get; } = new(context);
}
