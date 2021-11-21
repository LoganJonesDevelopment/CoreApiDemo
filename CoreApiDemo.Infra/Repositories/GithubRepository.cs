using CoreApiDemo.Infra.Interfaces.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreApiDemo.Infra.Repositories
{
    public class GithubRepository : IGithubRepository
    {
        public async Task<UserProfile> GetUserProfile(string UserID)
        {

            var client = new RestClient("https://api.github.com/users/" + UserID); // hit api passing in userid provided by request
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var userProfile = JsonSerializer.Deserialize<UserProfile>(response.Content);  // deserialize response content into the declared object
            return userProfile;
        }
    }
}
