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

        public GithubController(ILogger<GithubController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async UserProfile GetUserProfile(string userId)
        {
           var userProfile = new UserProfile();
            userProfile = await //
        }
    }
}
