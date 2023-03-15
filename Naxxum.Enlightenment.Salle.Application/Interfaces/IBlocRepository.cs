using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Application.Repositories;
public interface IBlocRepository
{

    List<Bloc> GetAllBlocs();
    Bloc CreateBloc(Bloc bloc);
    Bloc UpdateBloc(Bloc bloc);
    Bloc GetBlocById(int Id);
    bool DeleteBloc(int Id);
}
