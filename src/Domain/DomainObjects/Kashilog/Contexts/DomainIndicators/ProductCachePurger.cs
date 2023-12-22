namespace DomainObject.Kashilog.Contexts.DomainIndicators;

public partial class ProductCachePurger(RequestContext context) {
    public RequestContext Context { get; } = context;

    public static readonly TimeOnly Deadline = new(12, 40);

    public bool ReadyToRun(DateTime target) {
        if (Context.ForceExecuteOption) {
            return true;
        }

        var criteriaDate =
            new TimeOnly(Context.RequestedDatetime.TimeOfDay.Ticks) >= Deadline
                ? Context.RequestedDatetime.Date
                : Context.RequestedDatetime.Date.AddDays(-1);

        return criteriaDate == target.Date;
    }
}
