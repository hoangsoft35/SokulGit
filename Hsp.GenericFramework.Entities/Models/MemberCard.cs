﻿using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MemberCard : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public string MemberCardNumber { get; set; }


    }
}
