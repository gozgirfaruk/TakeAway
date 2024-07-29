using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TakeAway.IdentityServer.Dtos;
using TakeAway.IdentityServer.Models;

namespace TakeAway.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(CreateRegisterDto createRegisterDto)
        {
            var values = new ApplicationUser()
            {
                UserName = createRegisterDto.UserName,
                Email = createRegisterDto.Email,
                Name = createRegisterDto.Name,
                Surname = createRegisterDto.Surname
            };

            var result = await _userManager.CreateAsync(values, createRegisterDto.Password);
            if(result.Succeeded)
            {
                return Ok("Kayıt başarılı");
            }
            return Ok("bir hata meydana geldi.");
        }

    }  
}