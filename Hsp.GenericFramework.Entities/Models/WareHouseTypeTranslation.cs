﻿using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class WareHouseTypeTranslation : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int WareHouseTypeId { get; set; }
        public string WareHouseTypeName { get; set; }
        public string WareHouseTypeDescription { get; set; }
        public virtual WareHouseType WareHouseType { get; set; }


    }
}
