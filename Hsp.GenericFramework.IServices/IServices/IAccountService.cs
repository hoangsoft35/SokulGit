using Hsp.GenericFramework.Commons.Dtos;
using Hsp.GenericFramework.Commons.Security;
using System.Security.Cryptography.X509Certificates;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IAccountService
    {
        ErrorModel<UserProfileLogin> SignIn(string userName, string password);
    }
}
