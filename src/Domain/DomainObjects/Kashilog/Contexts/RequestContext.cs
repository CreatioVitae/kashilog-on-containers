using Service.Extensions.DependencyInjection.Markers;
using System;

namespace DomainObject.Kashilog.Contexts;

public class RequestContext : IRequestContext {
    public DateTime RequestedDatetime { get; init; }
}
