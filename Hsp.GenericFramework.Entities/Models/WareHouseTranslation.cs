﻿using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class WareHouseTranslation : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int WareHouseId { get; set; }
        public string WareHouseName { get; set; }
        public string WareHouseDescription { get; set; }
        public virtual WareHouse WareHouse { get; set; }


    }
}
