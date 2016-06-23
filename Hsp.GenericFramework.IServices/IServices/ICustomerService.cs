using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ICustomerService
    {
        CustomerModel GetCustomerByMemberCardNumber(string memberCardNumber);
        int GetDiscountMemberByCustomerId(int customerId);
    }
}
