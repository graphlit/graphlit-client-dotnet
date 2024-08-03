using Microsoft.Extensions.DependencyInjection;

namespace GraphlitClient;

public class Graphlit
{
    private const string DEFAULT_URI = "https://data-scus.graphlit.io/api/v1/graphql";
    private static readonly TimeSpan DEFAULT_TIMEOUT = TimeSpan.FromMinutes(10);

    private readonly Lazy<IGraphlitClient> _client;

    public IGraphlitClient Client => _client.Value;

    public Graphlit(IHttpClientFactory httpClientFactory, string organizationId = null, string environmentId = null, string jwtSecret = null, string ownerId = null, Uri apiUri = null)
    {
        string token;

        try
        {
            token = JwtHelpers.GenerateJwt(organizationId, environmentId, jwtSecret, ownerId);
        }
        catch (Exception e)
        {
            throw new InvalidOperationException($"Failed to generate JWT.", e);
        }

        var httpClient = httpClientFactory.CreateClient("Graphlit");

        _client = new Lazy<IGraphlitClient>(ClientAccessor.GetClient(
            client =>
            {
                client.Timeout = DEFAULT_TIMEOUT;
                client.BaseAddress = apiUri ?? new Uri(DEFAULT_URI);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            },
            builder =>
            {
                builder.AddTypedClient(x => httpClient);
            }));
    }

    public Graphlit(HttpClient httpClient, string organizationId = null, string environmentId = null, string jwtSecret = null, string ownerId = null, Uri apiUri = null)
    {
        string token;

        try
        {
            token = JwtHelpers.GenerateJwt(organizationId, environmentId, jwtSecret, ownerId);
        }
        catch (Exception e)
        {
            throw new InvalidOperationException($"Failed to generate JWT.", e);
        }

        _client = new Lazy<IGraphlitClient>(ClientAccessor.GetClient(
            client =>
            {
                client.Timeout = DEFAULT_TIMEOUT;
                client.BaseAddress = apiUri ?? new Uri(DEFAULT_URI);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            },
            builder =>
            {
                builder.AddTypedClient(x => httpClient);
            }));
    }
}

internal static class ClientAccessor
{
    public static IGraphlitClient GetClient(Action<HttpClient> configureClient, Action<IHttpClientBuilder> configureClientBuilder = null)
    {
        return new ServiceCollection()
            .AddGraphlitClient()
            .ConfigureHttpClient(configureClient, configureClientBuilder)
            .Services
            .BuildServiceProvider()
            .GetRequiredService<IGraphlitClient>();
    }
}