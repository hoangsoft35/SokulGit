
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.IServices.Base;

namespace Hsp.GenericFramework.Services.Base
{
    public class BaseService: IBaseService
    {

        public BaseService()
        {
           
        }
        public UserProfileLogin CurrentUser { get; set; }
        public int LanguageId
        {
            get
            {
                return CurrentUser?.CurrentLanguageId ?? Consts.LangCultures.en_US; 
            }
            set
            {
            }
        }
    }
}
