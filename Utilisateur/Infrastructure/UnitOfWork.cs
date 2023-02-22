
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilisateur.Model;

namespace Utilisateur.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        readonly UserDbContext context = new UserDbContext();
        bool disposed;
        public void Commit()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public IGenericRepository<T> Repository<T>() where T : class
        {
            return new GenericRepository<T>(context.Set<T>());
        }
        void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                context.Dispose();
            }

            disposed = true;
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
