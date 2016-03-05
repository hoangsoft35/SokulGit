using System;
using System.Collections;
using System.Data.Entity;
using Hsp.GenericFramework.IUnitOfWorks;

namespace Hsp.GenericFramework.UnitOfWorks
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DbContext _context;
        private Hashtable _repositories;
        private bool _disposed;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
       
        public int SaveChanges()
        {
            using (var tran = _context.Database.BeginTransaction())
            {
                try
                {
                    var result = _context.SaveChanges();
                    tran.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception(ex.Message);

                }
            }
            
            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
