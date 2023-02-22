namespace Utilisateur.Infrastructure
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : class;
        void Commit();
    }
}
