namespace Utilisateur.Controllers;



using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;



[ApiController]
[Route("[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    private ISender _mediator = null!;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
