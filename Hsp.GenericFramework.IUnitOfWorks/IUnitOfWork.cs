using System;

namespace Hsp.GenericFramework.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
