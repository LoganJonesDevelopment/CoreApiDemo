using CoreApiDemo.Infra.Interfaces.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CoreApiDemo.Infra.Repositories
{
    public class GithubRepository : IGithubRepository
    {
        public UserProfile GetUserProfile(string UserID)
        {
            var userProfile = new UserProfile();
            var client = new RestClient("https://api.github.com/users/" + UserID );
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            userProfile = JsonSerializer.Deserialize<UserProfile>(response.Content);
            return userProfile;
        }

        
    }
}
