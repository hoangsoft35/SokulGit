using System;

namespace Hsp.GenericFramework.IEntities
{
    public interface IBaseEntity
    {
        DateTime Created { get; set; }
        Guid CreatedBy { get; set; }
        DateTime? Updated { get; set; }
        Guid? UpdatedBy { get; set; }
    }
}