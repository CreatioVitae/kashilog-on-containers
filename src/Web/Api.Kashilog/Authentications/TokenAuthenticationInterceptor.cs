using DomainObject.Kashilog.Contexts;
using Microsoft.AspNetCore.Http;
using Service.Web.Extensions.DependencyInjection.Extensions;

namespace Api.Kashilog.Authentications;

public class TokenAuthenticationInterceptor(RequestContext requestContext) : ITokenAuthenticationInterceptor {
    public RequestContext RequestContext { get; } = requestContext;

    public void Interrupt(HttpRequest httpRequest) =>
        RequestContext.OverrideRequestedDatetime(httpRequest.HttpContext);

    public Action<HttpRequest>? InterruptOnBeginnings => Interrupt;

    public Func<HttpRequest, (bool interruptResult, string? token)>? InterruptOnCredentials =>
        null;
}
