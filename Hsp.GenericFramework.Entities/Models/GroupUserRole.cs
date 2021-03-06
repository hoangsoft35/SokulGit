﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class GroupUserRole : BaseEntityWithoutUserInformation
    {
        [Key, Column(Order = 1)]
        public Guid RoleId { get; set; }

        [Key, Column(Order = 2)]
        public Guid GroupUserId { get; set; }

        public virtual GroupUser GroupUser { get; set; }
        public virtual Role Role { get; set; }

    }}
