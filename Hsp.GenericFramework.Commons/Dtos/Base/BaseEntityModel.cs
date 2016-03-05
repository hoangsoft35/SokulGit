﻿using System;

namespace Hsp.GenericFramework.Commons.Dtos.Base
{
    public abstract class BaseEntityModel
    {
        public DateTimeOffset Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}