using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class CustomerHistory : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int CustomerId { get; set; }
        public string FunctionName { get; set; }
        public string Detail { get; set; }



    }
}
