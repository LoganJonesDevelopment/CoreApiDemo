using CoreApiDemo.Infra.Interfaces.Repositories;
using CoreApiDemo.Infra.Interfaces.Services;
using System.Threading.Tasks;

namespace CoreApiDemo.Infra.Services
{
    public class GithubService : IGithubService
    {
        private readonly IGithubRepository _githubRepository;
        public GithubService(IGithubRepository githubRepository)
        {
            _githubRepository = githubRepository;
        }
        public async Task<UserProfile> GetUserProfile(string userId)
        {
            return await _githubRepository.GetUserProfile(userId).ConfigureAwait(false);

        }
    }
}
