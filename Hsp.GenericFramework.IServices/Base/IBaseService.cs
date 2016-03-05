using Hsp.GenericFramework.Commons.Security;

namespace Hsp.GenericFramework.IServices.Base
{
    public interface IBaseService
    {
        UserProfileLogin CurrentUser { get; set; }
        int LanguageId { get; set; }
    }
}
