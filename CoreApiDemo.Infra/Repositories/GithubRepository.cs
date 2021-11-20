using CoreApiDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApiDemo.Infra.Repositories
{
    public class GithubRepository
    {
        public UserProfile GetUserProfile()
        {
            var userProfile = new UserProfile();
            // api call
            return userProfile;
        }
    }
}
