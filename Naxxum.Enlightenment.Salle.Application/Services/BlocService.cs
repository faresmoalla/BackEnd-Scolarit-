using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naxxum.Enlightenment.Salle.Application.Interfaces;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Application.Services;
public class BlocService : IBlocService
{
    private readonly IRepository<Bloc> _blocRepository;
    private readonly IUnitOfWork _unitOfWork;

    public BlocService(IRepository<Bloc> blocRepository, IUnitOfWork unitOfWork)
    {
        _blocRepository = blocRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Bloc>> GetAllProductsAsync()
    {
        return await _blocRepository.GetAllAsync();
    }

    public async Task<Bloc> GetProductByIdAsync(int id)
    {
        return await _blocRepository.GetByIdAsync(id);
    }

    public async Task AddProductAsync(Bloc bloc)
    {
        _blocRepository.Add(bloc);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Bloc bloc)
    {
        _blocRepository.Update(bloc);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task RemoveProductAsync(Bloc bloc)
    {
        _blocRepository.Remove(bloc);
        await _unitOfWork.SaveChangesAsync();
    }
}