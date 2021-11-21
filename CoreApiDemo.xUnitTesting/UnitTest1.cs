using RestSharp;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CoreApiDemo.xUnitTesting
{
    public class UnitTest1
    {
        private readonly string ApiBaseUrl = "https://api.github.com/logan/";
        [Fact]
        public async Task GetPublicHealthEndpoint()
        {
            var client = new RestClient("https://api.github.com/users/logan"); // hit api passing in userid provided by request
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            Assert.True(response.IsSuccessful);
        }
    }
}
