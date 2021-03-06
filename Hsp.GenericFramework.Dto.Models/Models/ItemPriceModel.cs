﻿using System;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class ItemPriceModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CompanyId { get; set; }
        public bool IteIsCurrentPricemId { get; set; }
        public decimal StatusValueId { get; set; }
        public int StatusId { get; set; }
        public DateTimeOffset EffectiveFromDate { get; set; }
        public DateTimeOffset EffectiveToDate { get; set; }




    }
}
