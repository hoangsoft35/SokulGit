using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class WageFee : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public decimal Price { get; set; }
        public int DepartmentId { get; set; }


    }
}
