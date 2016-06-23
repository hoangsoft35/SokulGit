using Hsp.GenericFramework.IServices.IServices;

namespace CoffeeSoft.App.Service
{
    public interface IServiceInstance
    {
        ILanguageService LanguageService { get; set; }
        IAccountService AccountService { get; set; }
        ICompanyService CompanyService { get; set; }
        IAreaService AreaService { get; set; }
        ITableService TableService { get; set; }
        IItemService ItemService { get; set; }
        IExportService ExportService { get; set; }
        ICustomerService CustomerService { get; set; }
    }
}
