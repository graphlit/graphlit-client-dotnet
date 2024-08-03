using FluentAssertions;
using Microsoft.Extensions.Configuration;
using StrawberryShake;

namespace GraphlitClient.Tests
{
    public class GraphlitClientTests
    {
        private readonly IConfiguration _configuration;

        public GraphlitClientTests()
        {
            // Build configuration
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        [Fact]
        public void Client_ShouldSucceedCreateClient()
        {
            using var httpClient = new HttpClient();

            var client = new Graphlit(httpClient, _configuration.GetSection("ClientSettings")["GRAPHLIT_ORGANIZATION_ID"], _configuration.GetSection("ClientSettings")["GRAPHLIT_ENVIRONMENT_ID"], _configuration.GetSection("ClientSettings")["GRAPHLIT_JWT_SECRET"], _configuration.GetSection("ClientSettings")["GRAPHLIT_OWNER_ID"]);

            client.Client.Should().NotBeNull();
        }

        [Fact]
        public async Task Client_ShouldSucceedGetProject()
        {
            using var httpClient = new HttpClient();

            var client = new Graphlit(httpClient, _configuration.GetSection("ClientSettings")["GRAPHLIT_ORGANIZATION_ID"], _configuration.GetSection("ClientSettings")["GRAPHLIT_ENVIRONMENT_ID"], _configuration.GetSection("ClientSettings")["GRAPHLIT_JWT_SECRET"], _configuration.GetSection("ClientSettings")["GRAPHLIT_OWNER_ID"]);

            client.Client.Should().NotBeNull();

            var result = await client.Client.GetProject.ExecuteAsync();

            result.EnsureNoErrors();

            var project = result.Data.Project;

            project.Name.Should().NotBeNullOrEmpty();
        }
    }
}