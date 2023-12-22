using DomainObject.Kashilog.Contexts.DomainIndicators;

namespace DomainObject.Kashilog.Contexts;

public class RequestContext : IRequestContext {
    public DateTime RequestedDatetime { get; init; }

    public bool ForceExecuteOption { get; set; } = false;

    public bool ForceDefaultExecutionDate { get; set; } = false;

    public DomainIndicator? DomainIndicator { get; set; } = null;

    public AuthenticatedUser? User { get; set; }

    public AuthenticatedUser GetAuthenticatedUser() =>
        User switch {
            not null => User,
            _ => throw new InvalidOperationException($"{nameof(RequestContext)}.{nameof(User)}がオブジェクトのインスタンスに設定されていません。")
        };
}
