using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Hsp.GenericFramework.Commons.Exception;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.IGenericRepositories;
using log4net;

namespace Hsp.GenericFramework.GenericRepositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class 
    {
        private DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly ILog _log;


        public GenericRepository(DbContext context, ILogManager<TEntity> logManager)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
            _log = logManager.GetLog();
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _dbSet.AsEnumerable();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("System error when excuting GetAll() {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting GetAll() function");
            }

           
        }

        public TEntity Find(params object[] keyValues)
        {
            try
            {
                return _dbSet.Find(keyValues);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("System error when excuting Find(params object[] keyValues) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting Find(params object[] keyValues) function");
            }
        
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return _dbSet.Where(predicate).AsEnumerable();
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting FindBy(Expression<Func<TEntity, bool>> predicate) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting FindBy(Expression<Func<TEntity, bool>> predicate) function");
            }
            
        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                return _dbSet.Add(entity);
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting Add(TEntity entity) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting Add(TEntity entity) function");
            }
           
        }

        public void AddRange(List<TEntity> entities)
        {
            try
            {
                _dbSet.AddRange(entities);
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting AddRange(List<TEntity> entities) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting AddRange(List<TEntity> entities) function");
            }
            
        }

        public TEntity Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                return entity;
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting TEntity Update(TEntity entity) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting TEntity Update(TEntity entity) function");
            }
          
        }

        public TEntity Delete(TEntity entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                return _dbSet.Remove(entity);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("System error when excuting Delete(TEntity entity) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting Delete(TEntity entity) function");
            }
            
        }

        public void Delete(object id)
        {
            try
            {
                var entityToDelete = _dbSet.Find(id);
                Delete(entityToDelete);
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting Delete(object id) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting Delete(object id) function");
            }

        }

        public void DeleteRange(List<TEntity> entities)
        {
            try
            {
                _dbSet.RemoveRange(entities);
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting DeleteRange(List<TEntity> entities) {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting DeleteRange(List<TEntity> entities) function");
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
        public virtual IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>,
                IOrderedQueryable<TEntity>> orderBy = null,
            List<Expression<Func<TEntity, object>>>
                includeProperties = null,
            int? page = null,
            int? pageSize = null)
        {
            try
            {
                IQueryable<TEntity> query = _dbSet;

                if (includeProperties != null)
                    includeProperties.ForEach(i => { query = query.Include(i); });

                if (filter != null)
                    query = query.Where(filter);

                if (orderBy != null)
                    query = orderBy(query);

                if (page != null && pageSize != null)
                    query = query
                        .Skip((page.Value - 1) * pageSize.Value)
                        .Take(pageSize.Value);

                return query;
            }
            catch (Exception ex)
            {

                _log.ErrorFormat("System error when excuting Get() {0} {1} Detail : {2}", _log.GetType(), Environment.NewLine, ex);
                throw new InternalException(2501, "System error when excuting Get() function");
            }
            
        }

       
    }
}
