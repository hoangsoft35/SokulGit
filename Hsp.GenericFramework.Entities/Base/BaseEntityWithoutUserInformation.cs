using System;

namespace Hsp.GenericFramework.Entities.Base
{
    public abstract class BaseEntityWithoutUserInformation
    {
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
    }
}