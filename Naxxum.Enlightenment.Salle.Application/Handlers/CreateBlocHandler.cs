using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Naxxum.Enlightenment.Salle.Application.Commands;
using Naxxum.Enlightenment.Salle.Application.Repositories;

using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Application.Handlers;
internal class CreateBlocHandler : IRequestHandler<CreateBlocCommand, Bloc>
{
  
    private readonly IBlocRepository _blocRepository;
  

    public CreateBlocHandler( IBlocRepository blocRepository)
    {
     
        _blocRepository= blocRepository;
    }
    public Task<Bloc> Handle(CreateBlocCommand request, CancellationToken cancellationToken)
    {
        var entity = new Bloc
        {
            IdBloc = request.IdBloc,
            NomBloc = request.NomBloc,
           
        };
        return Task.FromResult(_blocRepository.CreateBloc(entity));
    }
}
