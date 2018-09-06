using System;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Threading.Tasks;
using multi.web;

namespace multi.web.tests
{
 

    public class TestCalculatorMiddleware
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;


        public TestCalculatorMiddleware(){
            _server =  new TestServer(
                new WebHostBuilder()
            .ConfigureServices(services =>
            {}).UseStartup<Startup>());

             _client = _server.CreateClient();
           
        }

        [Fact]
        public async Task TestMiddlewareWorks()
        {
            var response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.NotNull(responseString);
        }
    }
}
