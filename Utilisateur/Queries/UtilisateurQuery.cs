namespace Utilisateur.Queries;
using MediatR;
using Utilisateur.Model;

public record UtilisateurQuery : IRequest<IEnumerable<User>>;
public class UtilisateurQueryHandler : RequestHandler<UtilisateurQuery, IEnumerable<User>>
{
    protected override IEnumerable<User> Handle(UtilisateurQuery request)
    {
        throw new NotImplementedException();
    }
}
