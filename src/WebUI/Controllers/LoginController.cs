using CleanArchitecture.WebUI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;


[Microsoft.AspNetCore.Components.Route("[controller]")]
public class LoginController : ApiControllerBase
{
    [Authorize]
    [HttpGet]
    public IActionResult ListDinners()
    {
        return Ok(Array.Empty<string>());
    }

}
