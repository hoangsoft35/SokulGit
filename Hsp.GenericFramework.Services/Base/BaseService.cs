using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.IServices.Base;
using Hsp.GenericFramework.IUnitOfWorks;
using log4net;

namespace Hsp.GenericFramework.Services.Base
{
    public class BaseService: IBaseService
    {

        public BaseService(IUnitOfWork unitOfWork, ILog log){
            UnitOfWork = unitOfWork;
            _log = log;
        }
        public ILog _log;
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
