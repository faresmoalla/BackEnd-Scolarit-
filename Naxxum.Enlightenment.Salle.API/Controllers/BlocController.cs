using MediatR;
using Microsoft.AspNetCore.Mvc;
using Naxxum.Enlightenment.Salle.Application.Commands;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.API.Controllers;



[ApiController]
[Route("api/[controller]")]
public class BlocController : ControllerBase
{
    private readonly IMediator _mediator;

    //constructor 
    public BlocController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<Bloc>> Create(CreateBlocCommand command)
    {
        return await _mediator.Send(command);
    }

}
