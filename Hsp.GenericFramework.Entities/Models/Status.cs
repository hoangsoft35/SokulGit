﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Status : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
}
