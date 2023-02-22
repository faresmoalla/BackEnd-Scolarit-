namespace Utilisateur.Controllers;

using System.Threading;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Utilisateur.Commands;
using Utilisateur.Model;




//[Microsoft.AspNetCore.Components.Route("api/login")]
public class LoginController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;
 

    public LoginController(IMediator mediator, IMapper mapper)
{
    this.mediator = mediator;
    this.mapper = mapper;

}

       

// [Authorize]
[Route("GetListUser")]
    [HttpGet]
    public IActionResult ListDinners()
    {
        return Ok(Array.Empty<string>());
    }
    /*
    [HttpPost]
    public async Task<ActionResult<User>> Create(CreateUserCommand user, CancellationToken cancellationToken)
    {
        var userr = mapper.Map<CreateUserCommand>(user);

        var item = await mediator.Send(userr,cancellationToken);

        return await mediator.Send(userr);

        
}*/


}