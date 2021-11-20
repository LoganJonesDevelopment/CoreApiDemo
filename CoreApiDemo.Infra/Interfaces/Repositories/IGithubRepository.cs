using CoreApiDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApiDemo.Infra.Interfaces.Repositories
{
    public interface IGithubRepositoryInterface
    {
        public UserProfile GetUserProfile();
    }
}
