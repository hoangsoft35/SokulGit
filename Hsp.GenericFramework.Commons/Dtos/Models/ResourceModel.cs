using System;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class ResourceModel : BaseEntityModel
    {
        public string Id { get; set; }
        public string ViewId { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }        

    }
}
