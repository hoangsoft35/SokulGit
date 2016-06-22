using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class CustomerService : BaseService, ICustomerService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Customer> _customerRepository;
        readonly IGenericRepository<CustomerTranslation> _customerTranslationRepository;
        public UserProfileLogin _currentUser;
        public CustomerService(IUnitOfWork unitOfWork, IGenericRepository<Customer> customerRepository, IGenericRepository<CustomerTranslation> customerTranslationRepository, ILogManager<CustomerService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _customerRepository = customerRepository;
            _customerTranslationRepository = customerTranslationRepository;
            _unitOfWork = unitOfWork;
        }


        public CustomerModel GetCustomerByMemberCardNumber(string memberCardNumber)
        {
            var result = _customerTranslationRepository.Get().FirstOrDefault(x => x.Customer.MemberCardNumber == memberCardNumber);
            if (result != null)
            {
                return Mapper.Map<CustomerModel>(result);
            }
            return null;
        }
        public int GetDiscountMemberByCustomerId(int customerId)
        {
            var result = _customerRepository.Get(x => x.Id == customerId).FirstOrDefault();
            if (result != null)
            {
                return result.MemberType.DiscountForThisType;
            }
            return 0;
        }
    }
}