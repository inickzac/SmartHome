using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/user/{id:int}")]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        private readonly UserManager<User> _userManager;

        public UserController(IServiceManager serviceManager, UserManager<User> userManager)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts(int id)
        {
           var bb = await _userManager.CreateAsync(new User() { UserName = "fgdfg" }, "55666");

            return Ok(bb);
        }
    }
}