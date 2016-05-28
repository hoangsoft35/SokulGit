using System;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Entities
{
    public class BaseEntity
    {
        public DateTimeOffset Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}