using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Application.Commands;
public class  CreateBlocCommand : IRequest<Bloc>
{
    public int IdBloc { get; set; }

    public string? NomBloc { get; set; }

}
