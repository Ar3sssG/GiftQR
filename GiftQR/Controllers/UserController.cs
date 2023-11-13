using GiftQRDataAccess.DAL.Interfaces;
using GiftQRDataAccess.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftQR.Controllers
{
    [ApiController]
    //[ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        public UserController(IUnitOfWork unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<UserController> logger)
            : base(unitOfWork, userManager, signInManager, logger)
        {
        }

        //[AllowAnonymous]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public async Task<IActionResult> IsWorking()
        {
            return Ok(true);
        }

    }
}
