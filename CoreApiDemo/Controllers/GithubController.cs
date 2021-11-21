using CoreApiDemo.Domain.Extensions;
using CoreApiDemo.Infra.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GithubController : ControllerBase
    {
        private readonly ILogger<GithubController> _logger;
        private readonly IGithubService _githubService;


        public GithubController(ILogger<GithubController> logger, IGithubService githubService)
        {
            _logger = logger;
            _githubService = githubService;
        }

        [HttpGet]
        public async Task<UserProfile> GetUserProfile(string userId)
        {
            var userProfile = await _githubService.GetUserProfile(userId).ConfigureAwait(false);
            if (userProfile.login == null)
                throw new CustomException("Error retrieving profile for" + userId);
            return userProfile;
        }
    }
}
