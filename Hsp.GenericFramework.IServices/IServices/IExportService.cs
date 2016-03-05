using System;
using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IExportService
    {
        bool InitUpdateExport(string exportId, int tableId, Guid userId, int itemId, int quantity, int companyId, int itemPriceId, decimal priceValue);
        string NewInvoiceNumber(string prefix);
        bool IsTableHaveGuest(int tableId);
        List<ExportDetailModel> GetDetailExportByTableId(int tableId);
        ExportModel GetExportByExportId(string exportId);
        bool UpdateServiceAndVat(ExportModel model);
        bool UpdateDiscountForItem(string exportId, int itemId, decimal itemDiscount);
        bool PaidBill(string expId, CustomerModel customer, bool isUseKul, decimal totalExportValue);
        void UpdateNoteForExportDetailItem(string exportId, int itemId, bool note);
        
    }
}
