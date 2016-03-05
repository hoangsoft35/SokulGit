using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ICustomerService
    {
        CustomerModel GetCustomerByMemberCardNumber(string memberCardNumber);
        int GetDiscountMemberByCustomerId(int customerId);
    }
}
