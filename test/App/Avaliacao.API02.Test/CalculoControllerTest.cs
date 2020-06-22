//using Avaliacao.API02.Controllers;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.TestHost;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Xunit;

//namespace Avaliacao.API02.Test
//{
//    public class CalculoControllerTest
//    {
//        protected CalculoController controller { get; }
//        protected Mock<ITaxaService> service { get; }


//        private readonly HttpClient _http;

//        public CalculoControllerTest()
//        {
//            var server = new TestServer(new WebHostBuilder()
//                                                .UseEnvironment("Development")
//                                                .UseStartup<Startup>());

//            _http = server.CreateClient();

//            service = new Mock<ITaxaService>();          
//            controller = new CalculoController();
//        }

//        //[Fact]
//        //public void GetCalculaJurosTest()
//        //{
//        //    var result = controller.CalculaJuros(100, 5);

//        //    Assert.Equal(TaskStatus.RanToCompletion, result.Status);
//        //}

//        [Theory]
//        [InlineData("GET")]
//        public async Task GetCalculaJurosTest(string method)
//        {
//            var request = new HttpRequestMessage(new HttpMethod(method), "/CalculaJuros");
//            var response = await _http.SendAsync(request);

//            response.EnsureSuccessStatusCode();
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }


//        [Theory]
//        [InlineData("GET")]
//        public async Task GetShowMeTheCodeTest(string method)
//        {
//            var request = new HttpRequestMessage(new HttpMethod(method), "/ShowMeTheCode");
//            var response = await _http.SendAsync(request);

//            response.EnsureSuccessStatusCode();
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }
//    }
//}
