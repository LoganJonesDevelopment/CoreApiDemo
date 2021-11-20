using CoreApiDemo.Infra.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApiDemo.Infra.Interfaces.Services
{
    public interface IGithubService
    {
        public UserProfile GetUserProfile(string userId);
    }
}
