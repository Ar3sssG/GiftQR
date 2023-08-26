using GiftQRDataAccess.DAL.Interfaces;
using GiftQRDataAccess.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GiftQR.Controllers
{
    [Route("v{version:apiVersion}/[controller]/[action]")]
    public class BaseApiController : ControllerBase
    {
        protected readonly ILogger<BaseApiController> _logger;
        protected IUnitOfWork _unitOfWork;
        protected UserManager<User> _userManager;
        protected SignInManager<User> _signInManager;
        public BaseApiController(IUnitOfWork unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager,ILogger<BaseApiController> logger = null)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
    }
}
