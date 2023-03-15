

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

using MediatR;
using Naxxum.Enlightenment.User.Domain;

//using DomainUser.Configuration.TokenGenerator;


namespace Naxxum.Enlightenment.User.Api.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
       private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AccountController(IJwtTokenGenerator jwtTokenGenerator, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)

   
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenGenerator = jwtTokenGenerator;
      
        }

  
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterDTO registerDTO)
        {
            var exist = await _userManager.FindByEmailAsync(registerDTO.Email);
            if (exist != null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { message = $"{exist.Email} has been registered already!" });
            }

            // Generate a new IdentityUser object
            var user = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = registerDTO.Email,
                Email = registerDTO.Email,
                EmailConfirmed = true
                     
            };
            

            // Create a new user
           // var result = await Mediator.Send(_userManager.CreateAsync(user, registerDTO.Password));
            var result = await _userManager.CreateAsync(user, registerDTO.Password);

            // If the creation process is not succeeded return a BadRequest status
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { message = "Registeration failed" });
            }

            // Check if users has not been registered with role user, then the user will be added to the User role 
            if (!await _userManager.IsInRoleAsync(user, registerDTO.Role))
            {
                await _userManager.AddToRoleAsync(user, registerDTO.Role);
            }

      
            return StatusCode(StatusCodes.Status201Created);
        }

        ///// Login


        [HttpPost("signin")]
        public async  Task<IActionResult> SignIn(LoginDTO loginDTO)
        {
            // Check Password is correct
            var signInResult = await _signInManager.PasswordSignInAsync(loginDTO.Email, loginDTO.Password, false, false);

            if (signInResult.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(loginDTO.Email);
                var token = _jwtTokenGenerator.GenerateToken(user);
                return StatusCode(StatusCodes.Status200OK, new {email=loginDTO.Email,token=token});
            }
            

            // The password or email is incorrect and return a BadRequest as a result of signin endpoint
            return StatusCode(StatusCodes.Status500InternalServerError, new { email = loginDTO.Email, token = _jwtTokenGenerator.GenerateToken(await _userManager.FindByEmailAsync(loginDTO.Email)) });
        
        
        } 
     
    }
}
