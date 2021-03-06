﻿using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class WareHouse : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int WareHouseTypeId { get; set; }
        public virtual WareHouseType WareHouseType { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }


    }
}
