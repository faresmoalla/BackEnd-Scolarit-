using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naxxum.Enlightenment.Salle.Domain.Entities;

namespace Naxxum.Enlightenment.Salle.Application.Services;
public interface IBlocService
{

    Task<IEnumerable<Bloc>> GetAllProductsAsync();
    Task<Bloc> GetProductByIdAsync(int id);
    Task AddProductAsync(Bloc bloc);
    Task UpdateProductAsync(Bloc bloc);
    Task RemoveProductAsync(Bloc bloc);
}
