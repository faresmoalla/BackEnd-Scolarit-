using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Naxxum.Enlightenment.Salle.Application.Interfaces;

namespace Naxxum.Enlightenment.Salle.Infrastructure.Services;
public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _context;
    private readonly DbSet<T> _entities;

    public Repository(DbContext context)
    {
        _context = context;
        _entities = _context.Set<T>();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _entities.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _entities.ToListAsync();
    }

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public void Update(T entity)
    {
        _entities.Update(entity);
    }

    public void Remove(T entity)
    {
        _entities.Remove(entity);
    }
}
