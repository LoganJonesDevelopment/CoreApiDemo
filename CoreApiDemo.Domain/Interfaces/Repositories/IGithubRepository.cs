using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApiDemo.Infra.Interfaces.Repositories
{
    public interface IGithubRepository
    {
        public UserProfile GetUserProfile(string UserId);
    }
}
