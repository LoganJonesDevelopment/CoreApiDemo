using CoreApiDemo.Controllers;
using CoreApiDemo.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApiDemo.Infra.Services
{
    public class GithubService
    {
        private readonly IGithubRepository _githubRepository;
        public GithubService(IGithubRepository githubRepository)
        {
            _githubRepository = githubRepository;
        }
        public UserProfile GetUserProfile(string userId)
        {
            var userProfile = new UserProfile();
            userProfile = 
        }
    }
}
