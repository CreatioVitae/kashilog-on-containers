using DomainObject.Kashilog.Contexts;
using System.Security.Claims;

namespace Api.Kashilog.Authentications;

public class TokenAuthenticationService(RequestContext requestContext) : ITokenAuthenticationService {
    RequestContext RequestContext { get; } = requestContext;

    public async ValueTask<(bool authenticateResult, Claim[] authenticatedUserClaims)> AuthenticateAsync(string token) {

        RequestContext.User = new (){ Id = "hoge", Email = "hoge@example.com" };

        return (
            authenticateResult: true,
            authenticatedUserClaims: new[] {
                new Claim(ClaimTypes.NameIdentifier, RequestContext.User.Id),
                new Claim(ClaimTypes.Email, RequestContext.User.Email)
            }
        );
    }
}
