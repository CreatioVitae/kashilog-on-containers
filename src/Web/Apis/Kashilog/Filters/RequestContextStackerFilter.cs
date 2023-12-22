using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Web.Kashilog.Core.HttpHeaders.DomainIndicators;

namespace Api.Kashilog.Filters;

public sealed class RequestContextStackerFilter(RequestContext requestContext) : ActionFilterAttribute {
    RequestContext RequestContext { get; } = requestContext;

    public override void OnActionExecuting(ActionExecutingContext context) {
        static void StackRequestContext(RequestContext requestContext, HttpContext httpContext) {
            requestContext.ForceExecuteOption = httpContext.GetForceExecuteOption();
            requestContext.ForceDefaultExecutionDate = httpContext.GetForceDefaultExecutionDate();
            requestContext.DomainIndicator = new(requestContext);
        }

        StackRequestContext(RequestContext, context.HttpContext);
        base.OnActionExecuting(context);
    }
}
