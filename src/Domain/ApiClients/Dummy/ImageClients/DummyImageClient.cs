namespace ApiClient.Dummy.ImageClients;

public class DummyImageClient(HttpClient httpClient) : IApiClient {
    HttpClient HttpClient { get; } = httpClient;

    public async Task<byte[]> GetImageByteArrayAsync(string requestUri) {
        var headResponse = await HttpClient.HeadAsync(requestUri).IfStatusCodeIsAllowed(AllowedHttpStatusCodes.Ok);

        const string availableMediaType = "image/jpeg";

        if (headResponse.Content.GetMediaType() is not availableMediaType) {
            throw new HttpRequestException($"MIME(MediaType)が、{availableMediaType}を期待していますが、実際には{headResponse.Content.GetMediaType()}です");
        }

        var getResponse = await HttpClient.GetAsync(requestUri).IfStatusCodeIsAllowed(AllowedHttpStatusCodes.Ok);

        return await getResponse.Content.ReadAsByteArrayAsync();
    }
}
