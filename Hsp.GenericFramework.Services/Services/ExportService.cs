using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class ExportService : BaseService, IExportService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Export> _exportRepository;
        readonly IGenericRepository<ExportDetail> _exportDetailRepository;
        readonly IGenericRepository<KulExchangeDetailExport> _kulExchangeDetailExportRepository;
        readonly IGenericRepository<Customer> _customerRepository;
        public UserProfileLogin _currentUser;
        public ExportService(IUnitOfWork unitOfWork, IGenericRepository<Export> exportRepository, IGenericRepository<ExportDetail> exportDetailRepository, IGenericRepository<KulExchangeDetailExport> kulExchangeDetailExportRepository, IGenericRepository<Customer> customerRepository) : base(unitOfWork)
        {
            _exportRepository = exportRepository;
            _exportDetailRepository = exportDetailRepository;
            _kulExchangeDetailExportRepository = kulExchangeDetailExportRepository;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        // return IsHaveGuest status;
       
        public bool InitUpdateExport(string exportId, int tableId, Guid userId, int itemId, int quantity, int companyId, int itemPriceId, decimal priceValue)
        {
            var isHaveGuest = IsTableHaveGuest(tableId);
            if (isHaveGuest)
            {
                AddItemToTable(exportId, itemId, quantity, companyId, itemPriceId, priceValue, true, tableId, userId);
            }
            else
            {
                if (quantity < 0)
                {
                    return false;
                }
                AddItemToTable(NewInvoiceNumber("HDX"), itemId, quantity, companyId, itemPriceId, priceValue, false,tableId, userId);
            }
            var a = UnitOfWork.SaveChanges();
            return IsTableHaveGuest(tableId);}
        public string NewInvoiceNumber(string prefix)
        {
            const string baseString = "0000000000";
            var newInvoiceNumber = string.Format("{0}0000000001", prefix);
            var latestInvoice = _exportRepository.Get(x => x.StatusId != (int)Consts.Status.Deleted)
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();
            if (latestInvoice != null)
            {
                var tempIncreaseNum = int.Parse(latestInvoice.Id.Substring(3)) + 1;
                newInvoiceNumber = string.Format("{0}{1}{2}", prefix,
                    baseString.Substring(tempIncreaseNum.ToString().Length), tempIncreaseNum);
            }
             
            return newInvoiceNumber;
        }
        public List<ExportDetailModel> GetDetailExportByTableId(int tableId)
        {
            var listResult = _exportDetailRepository.Get(x=>!x.Export.IsPayAll && x.Export.TableId == tableId);

            if (listResult.Any())
            {
                return new List<ExportDetailModel>(listResult.Select(x => new ExportDetailModel
                {
                    Price = x.Price,
                    ExportId = x.ExportId,
                    IsItemPay = (bool)x.IsItemPay,
                    ItemDiscount = x.ItemDiscount,
                    ItemId = x.ItemId,
                    ItemName = x.Item.ItemTranslations.FirstOrDefault(c=>c.LanguageId == Consts.LangCultures.DefaultWinformAppLanguage).ItemName,
                    Quantity = (int?) x.Quantity,
                    Service = x.Export.Service,
                    TableDiscount = x.Export.TableDiscount,
                    Stt = 0,
                    Total =  ((x.Quantity * (double) x.Price) - ((x.Quantity * (double) x.Price * (double) x.ItemDiscount)/100)),
                    Vat = x.Export.Vat,
                    Created = x.Created,
                    KulQuantity = x.Export.KulQuantity,
                    MoneyExchangeByKul = x.Export.MoneyExchangeByKul,
                    Note = x.Note,
                    ItemPriceId = x.ItemPriceId}));
            }
            return null;
        }

        public ExportModel GetExportByExportId(string exportId)
        {
            var result =
                _exportRepository.Get(x =>x.Id == exportId)
                    .ToList()
                    .Select(c => new ExportModel
                    {
                        Id = c.Id,
                        TableId = c.TableId,
                        TableName = c.Table.TableTranslations.FirstOrDefault(t => t.LanguageId == Consts.LangCultures.DefaultWinformAppLanguage)?.TableName,
                        //EmployerId = c.EmployerId,
                        //EmployerName = c.Employer.FullName,
                        TableDiscount = c.TableDiscount,
                        Created = c.Created,
                        IsPayAll = (bool) c.IsPayAll,
                        Vat = c.Vat,
                        Service = c.Service,
                        DatePaid = c.DatePaid,
                        AreaName = c.Table.Area.AreaTranslations.FirstOrDefault(t=>t.LanguageId == Consts.LangCultures.DefaultWinformAppLanguage)?.AreaName,
                        KulQuantity = c.KulQuantity,
                        MoneyExchangeByKul = c.MoneyExchangeByKul

                    });
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new ExportModel();
        }

        public bool UpdateServiceAndVat(ExportModel model)
        {
            var export = _exportRepository.Find(model.Id);
            if (export != null)
            {
                export.Vat = model.Vat;
                export.Service = model.Service;
                export.TableDiscount = model.TableDiscount;
                _exportRepository.Update(export);
            }
            return UnitOfWork.SaveChanges() > 0;
        }

        public bool UpdateDiscountForItem(string exportId, int itemId, decimal itemDiscount)
        {
            var exportDetail =
                _exportDetailRepository.Get(x => x.ExportId == exportId && x.ItemId == itemId).FirstOrDefault();
            if (exportDetail != null)
            {
                exportDetail.ItemDiscount = itemDiscount;
                _exportDetailRepository.Update(exportDetail);
               return UnitOfWork.SaveChanges() > 0;
            }
            return false;
        }

        public bool PaidBill(string expId, CustomerModel customer, bool isUseKul, decimal totalExportValue)
        {
            var export = _exportRepository.Find(expId);
            if (export != null)
            {
                export.IsPayAll = true;
                export.DatePaid = DateTimeOffset.UtcNow;
            }
            if (customer != null && isUseKul)
            {


                var kulBonus = GetKulByTotalExportValue(totalExportValue);
                var cus = _customerRepository.Find(customer.Id);
                cus.KulPoint += kulBonus;
                cus.TotalKulPoint += kulBonus;
                _customerRepository.Update(cus);

            }
            return UnitOfWork.SaveChanges() > 0;
        }

        public void UpdateNoteForExportDetailItem(string exportId, int itemId, bool note)
        {
            var detail = _exportDetailRepository.Get(x => x.ExportId == exportId && x.ItemId == itemId).FirstOrDefault();
            if (detail != null)
            {
                detail.Note = note;
                UnitOfWork.SaveChanges();
            }

        }
        

        #region private methods

        private int GetKulByTotalExportValue(decimal totalExportValue)
        {
            var result =
                _kulExchangeDetailExportRepository.Get(
                    x => totalExportValue >= x.TotalBillFrom && totalExportValue <= x.TotalBillTo).FirstOrDefault();
            if (result != null)
            {
                return result.KulBonusValue;
            }
            return 0;
        }
        public bool IsTableHaveGuest(int tableId)
        {
            var result = _exportRepository.Get().FirstOrDefault(x => x.TableId == tableId && x.IsPayAll == false);
            return result != null;
        }
        private void AddItemToTable(string exportId, int itemId, int quantity, int companyId, int itemPriceId, decimal priceValue, bool isHaveGuest, int tableId, Guid userId)
        {
            var isDeleteItem = false;
            var isItemNotInTable = true;
            if (isHaveGuest)
            {
                // get detail item in export
                var detailExports = _exportDetailRepository.Get(x => x.ExportId == exportId);
                
                // increate or decrease quantity
                foreach (var item in detailExports)
                {
                    if (item.ItemId == itemId)
                    {
                        item.Quantity += quantity;
                        isDeleteItem = item.Quantity <= 0;
                        isItemNotInTable = false;
                        break;
                    }
                }
                if (isItemNotInTable)
                {
                    if (quantity > 0)
                    {
                        var exportDetail = new ExportDetail
                        {
                            ExportId = exportId,
                            ItemId = itemId,
                            Quantity = quantity,
                            Price = priceValue,
                            ItemDiscount = 0,
                            IsItemPay = false,
                            ItemPriceId = itemPriceId,
                            Note = false,
                            StatusId = (int)Consts.Status.Created,
                            CreatedBy = userId,
                            Created = DateTimeOffset.UtcNow
                        };
                        _exportDetailRepository.Add(exportDetail);
                    }
                   
                }
                // check if quantity = 0 we will delete that recore in export detail
                if (isDeleteItem)
                {
                    var item = _exportDetailRepository.Get(x => x.ExportId == exportId && x.ItemId == itemId).FirstOrDefault();
                    _exportDetailRepository.Delete(item);
                    // if no item in export detail, delete exportdetail and export
                    if (!(_exportDetailRepository.Get(x => x.ExportId == exportId).Count() > 1))
                    {
                        _exportRepository.Delete(exportId);
                    }
                }
                

            }
            else
            {
                var export =new  Export
                {
                    Id = exportId,
                    TableId = tableId,
                    TableDiscount = 0,
                    IsPayAll = false,
                    Vat = 0,
                    Service = 0,
                    KulQuantity = 0,
                    MoneyExchangeByKul = 0,
                    StatusId = (int) Consts.Status.Created,
                    CompanyId = companyId,
                    CreatedBy = userId,
                    Created = DateTimeOffset.UtcNow

                };
                _exportRepository.Add(export);
                var exportDetail = new ExportDetail
                {
                    ExportId = exportId,
                    ItemId = itemId,
                    Quantity = quantity,
                    Price = priceValue,
                    ItemDiscount = 0,
                    IsItemPay = false,
                    ItemPriceId = itemPriceId,
                    Note = false,
                    StatusId = (int) Consts.Status.Created,
                    CreatedBy = userId,
                    Created = DateTimeOffset.UtcNow
                };
                _exportDetailRepository.Add(exportDetail);
            }

            }


        #endregion

    }
}