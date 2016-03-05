using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Hsp.GenericFramework.IEntities
{
    public interface IHspContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}
