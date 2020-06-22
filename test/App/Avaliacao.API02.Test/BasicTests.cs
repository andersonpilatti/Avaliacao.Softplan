using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Avaliacao.API02.Test
{
    public class BasicTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public BasicTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }


        [Theory]       
        [InlineData("/CalculaJuros", HttpStatusCode.NotFound)]
        [InlineData("/CalculaJuros?valorInicial=100", HttpStatusCode.NotFound)]
        [InlineData("/CalculaJuros?valorInicial=100&meses=5", HttpStatusCode.BadRequest)]
        [InlineData("/ShowMeTheCode", HttpStatusCode.OK)]
        public async Task EndPointTest(string url, HttpStatusCode status)
        {
            var _client = _factory.CreateClient();
            var response = await _client.GetAsync(url);

            Assert.Equal(status, response.StatusCode);
        }
    }
}
