using Service.Extensions.DependencyInjection.Markers;
using System;

namespace DomainObject.Kashilog.Contexts;

public class RequestContext : IRequestContext {
    public DateTime RequestedDatetime { get; init; }

    public AuthenticatedUser? User { get; set; }

    public AuthenticatedUser GetAuthenticatedUser() =>
        User switch {
            not null => User,
            _ => throw new InvalidOperationException($"{nameof(RequestContext)}.{nameof(User)}がオブジェクトのインスタンスに設定されていません。")
        };
}
