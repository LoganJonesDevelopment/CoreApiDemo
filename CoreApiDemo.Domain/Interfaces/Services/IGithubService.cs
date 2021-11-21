using CoreApiDemo.Infra.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApiDemo.Infra.Interfaces.Services
{
    public interface IGithubService
    {
        public Task<UserProfile> GetUserProfile(string userId);
    }
}
