using System.Data;
using CleanArchitecture.Infrastructure.Identity;
using CleanArchitecture.WebUI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Controllers;


[Authorize]
public class UserController : ApiControllerBase
{

    private readonly UserManager<ApplicationUser> _userManager;

    public UserController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;


    }


    [Route("GetAll")]
    [HttpGet]
    public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
    {
        IEnumerable<ApplicationUser> result = await _userManager.Users.ToListAsync();
        return _userManager.Users;
    }


}
