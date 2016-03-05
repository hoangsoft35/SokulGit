
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
using Hsp.GenericFramework.IUnitOfWorks;

namespace Hsp.GenericFramework.Services.Base
{
    public class BaseService: IBaseService
    {

        public BaseService(IUnitOfWork unitOfWork){
            UnitOfWork = unitOfWork;
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

        public IUnitOfWork UnitOfWork { get; set; }
    }
}
