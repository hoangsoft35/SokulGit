using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class DetailItemWareHouse : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int WareHouseId { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public int Quantity { get; set; }


    }
}
