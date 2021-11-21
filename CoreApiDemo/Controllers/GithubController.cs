using CoreApiDemo.Domain.Extensions;
using CoreApiDemo.Infra.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiDemo.Controllers
{
    [AllowAnonymous]
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
            var userProfile = await _githubService.GetUserProfile(userId).ConfigureAwait(false); // configure await = false should prevent deadlocks
            if (userProfile.login == null)
            {
                _logger.LogInformation("Entering Exception Handling");  // file/db logging?
                throw new CustomException("Error retrieving profile for: " + userId);  // elmah?
            }
            return userProfile;
        }
    }
}
