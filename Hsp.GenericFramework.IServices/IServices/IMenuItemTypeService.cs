﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IMenuItemTypeService
    {
        List<MenuItemTypeModel> GetMenuItemType(int languageId);
    }
}