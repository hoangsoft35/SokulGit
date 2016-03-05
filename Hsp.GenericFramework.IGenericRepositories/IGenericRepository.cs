using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hsp.GenericFramework.IGenericRepositories
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Find(params object[] keyValues);
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        void AddRange(List<TEntity> entities);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        void Delete(object id);
        void DeleteRange(List<TEntity> entities);

        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>,
                IOrderedQueryable<TEntity>> orderBy = null,
            List<Expression<Func<TEntity, object>>>
                includeProperties = null,
            int? page = null,
            int? pageSize = null);

    }
}
