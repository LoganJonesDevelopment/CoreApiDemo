using CoreApiDemo.Infra.Interfaces.Repositories;
using CoreApiDemo.Infra.Interfaces.Services;

namespace CoreApiDemo.Infra.Services
{
    public class GithubService : IGithubService
    {
        private readonly IGithubRepository _githubRepository;
        public GithubService(IGithubRepository githubRepository)
        {
            _githubRepository = githubRepository;
        }
        public UserProfile GetUserProfile(string userId)
        {
            return _githubRepository.GetUserProfile(userId); // todo error handling
           
        }
    }
}
