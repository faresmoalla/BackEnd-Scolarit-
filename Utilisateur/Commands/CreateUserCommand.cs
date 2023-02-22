using MediatR;
using Utilisateur.Infrastructure;
using Utilisateur.Model;

namespace Utilisateur.Commands;

public class CreateUserCommand 
{

    public CreateUserCommand()
    {

    }
    private readonly UserDbContext _context;

      private readonly IUnitOfWork _unitofwork;

    public CreateUserCommand(UserDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitofwork = unitOfWork;


    }
 


}
