﻿using System.Collections.Generic;
using System.Linq;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.Web.Admin.Base
{
    public static class Helpers
    {
        public static class Resources
        {
            public static string GetValue(List<ResourceModel> resources, string id)
            {
                var resource = resources.First(r => r.Id.ToLower() == id.ToLower());
                return resource?.Value ?? "";
            }
        }
    }
}
