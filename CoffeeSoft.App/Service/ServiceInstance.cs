using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.IServices.IServices;

namespace CoffeeSoft.App.Service
{
    public class ServiceInstance : IServiceInstance
    {
        public ServiceInstance(ILanguageService languageService, IAccountService accountService, ICompanyService companyService, IAreaService areaService, ITableService tableService, IItemService itemService, IExportService exportService, ICustomerService customerService)
        {
            LanguageService = languageService;
            AccountService = accountService;
            CompanyService = companyService;
            AreaService = areaService;
            TableService = tableService;
            ItemService = itemService;
            ExportService = exportService;
            CustomerService = customerService;
        }
        public ILanguageService LanguageService { get; set; }
        public IAccountService AccountService { get; set; }
        public ICompanyService CompanyService { get; set; }
        public IAreaService AreaService { get; set; }
        public ITableService TableService { get; set; }
        public IItemService ItemService { get; set; }
        public IExportService ExportService { get; set; }
        public ICustomerService CustomerService { get; set; }

    }
}
