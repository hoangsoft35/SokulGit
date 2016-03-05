using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.IUnitOfWorks;

namespace Hsp.GenericFramework.IServices.Base
{
    public interface IBaseService
    {
        UserProfileLogin CurrentUser { get; set; }
        int LanguageId { get; set; }
        IUnitOfWork UnitOfWork { get; set; }
    }
}
