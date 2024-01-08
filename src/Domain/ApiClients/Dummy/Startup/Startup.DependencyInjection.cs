using ApiClient.Dummy.ImageClients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Extensions.DependencyInjection.Options;
using System.Net;
using System.Net.Http.Headers;

namespace ApiClient.Dummy.Startup;

public static class StartupExtensionLibrary {
    public static IServiceCollection AddApiClientsFromDummyApiClient(this IServiceCollection services, IConfiguration configuration) {
        var dummyImageClientOptions = configuration.GetSection(ApiClientOptions.GetDefaultSection(nameof(DummyImageClient))).GetAvailable<ApiClientOptions>();
        var dummyImageClientBasicAuthOptions = configuration.GetSection(ApiClientOptions.GetDefaultSection(nameof(DummyImageClient))).GetAvailable<BasicAuthenticationOptions>();

        services.AddApiClient<DummyImageClient>(
            c => {
                c.BaseAddress = new(dummyImageClientOptions.BaseAddress);

                if (dummyImageClientOptions.TimeoutSeconds is not null) {
                    c.Timeout = TimeSpan.FromSeconds(dummyImageClientOptions.TimeoutSeconds.Value);
                }

                if (dummyImageClientBasicAuthOptions.HasValues()) {
                    c.DefaultRequestHeaders.Authorization = dummyImageClientBasicAuthOptions.GetAuthenticationHeaderValue();
                }
            },
            PolicyHandleOptions.CreateDefault() with {
                RetryPolicyOption = RetryPolicyOption.CreateDefault() with { ClientErrorStatusCodesRequiresRetry = new List<HttpStatusCode> { HttpStatusCode.NotFound } }
            }
        );

        return services;
    }
}

public record BasicAuthenticationOptions {
    public string? UserName { get; set; }
    public string? Password { get; set; }

    public bool HasValues() =>
        !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);

    public AuthenticationHeaderValue GetAuthenticationHeaderValue() =>
        new("Basic", (UserName + ":" + Password).EncodeBase64String());
}
