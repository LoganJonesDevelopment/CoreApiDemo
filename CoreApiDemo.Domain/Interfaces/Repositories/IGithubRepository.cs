using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApiDemo.Infra.Interfaces.Repositories
{
    public interface IGithubRepository
    {
        public Task<UserProfile> GetUserProfile(string UserId);
    }
}
