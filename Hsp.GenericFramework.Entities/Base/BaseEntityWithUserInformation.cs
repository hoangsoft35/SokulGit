using System;

namespace Hsp.GenericFramework.Entities.Base
{
    public abstract class BaseEntityWithUserInformation
    {
        public DateTimeOffset Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public Guid? UpdatedBy { get; set; }
    }}