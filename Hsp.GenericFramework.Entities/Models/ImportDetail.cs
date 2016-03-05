using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ImportDetail : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public int ImportId { get; set; }
        public virtual Import Import { get; set; }

        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }

        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }


    }
}
