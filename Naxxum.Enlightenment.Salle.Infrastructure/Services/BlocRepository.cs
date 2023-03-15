using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naxxum.Enlightenment.Salle.Application.Repositories;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Infrastructure.Services;
public class BlocRepository : IBlocRepository
{
    private readonly AppDbContext _appDbContext;

    public BlocRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }


    public Bloc CreateBloc(Bloc bloc)
    {
        _appDbContext.Bloc.Add(bloc);
        _appDbContext.SaveChanges();
        return bloc;
    }

    public bool DeleteBloc(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Bloc> GetAllBlocs()
    {
        return _appDbContext.Bloc.ToList();
    }

    public Bloc GetBlocById(int Id)
    {
        throw new NotImplementedException();
    }

    public Bloc UpdateBloc(Bloc bloc)
    {
        throw new NotImplementedException();
    }
}
