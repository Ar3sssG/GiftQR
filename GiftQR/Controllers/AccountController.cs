using GiftQRDataAccess.DAL.Interfaces;
using GiftQRDataAccess.Identity;
using GQRCommon.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using GiftQRModels;

namespace GiftQR.Controllers
{
    public class AccountController : BaseApiController
    {
        public AccountController(IUnitOfWork unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<BaseApiController> logger = null)
            : base(unitOfWork, userManager, signInManager, logger)
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate(AuthRequestModel request)
        {
            //var userMana
            //var signedUser = _signInManager.SignInAsync(user);
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, request.Username) };

            JwtSecurityToken jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            string token = new JwtSecurityTokenHandler().WriteToken(jwt);
            AuthResponseModel response = new AuthResponseModel
            {
                Token = $"Bearer {token}",
                Username = request.Username
            };

            return Ok(response);
        }
    }
}
