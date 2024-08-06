using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TakeAway.IdentityServer.Dtos;
using TakeAway.IdentityServer.Models;
using TakeAway.IdentityServer.Tools;

namespace TakeAway.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public LoginsController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, false,false);
            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (result.Succeeded)
            {
                GetCheckAppUserViewModel getCheckApp = new GetCheckAppUserViewModel();
                getCheckApp.UserName = loginDto.UserName;
                getCheckApp.Id=user.Id;
                
                var token = JwtTokenGenerator.GenerateToken(getCheckApp);
                return Ok(token);
            }
            else
            {
                return Ok("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
