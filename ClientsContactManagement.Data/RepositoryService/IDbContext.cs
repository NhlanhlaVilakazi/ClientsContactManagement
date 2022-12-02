using Microsoft.EntityFrameworkCore;

namespace ClientsContactManagement.Data.RepositoryService
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();
    }
}
