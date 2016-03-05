using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Import : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public string Note { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }


    }
}
