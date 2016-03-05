using System;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class LoopkupModel: BaseEntityModel
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

    }
}
