using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeSoft.App.General
{
    public class BillSetting
    {
        #region Print Setting Bill
        public string titlePrint = "Trà Sữa Trân Châu";
        public bool isTitlePrint = true;

        public string logoTextPrint = "SOKUL";
        public bool isLogoTextPrint = false;

        public bool isLogoImagePrint = true;

        public bool isDatePrint = true;
        public bool isTimeInPrint = true;
        public bool isTimeOutPrint = true;
        public bool isTablePrint = true;
        public bool isExportIdPrint = true;
        public bool isCustomerPrint = true;
        public bool isTotalPrint = true;
        public bool isTotalDiscount = true;
        public bool isTotalPayPrint = true;
        public bool isSayGoodByePrint = true;
        public string isSayGoodByeText1 = "Cảm ơn quý khách !";
        public string isSayGoodByeText2 = "Hẹn gặp lại !";
        public bool isWebsitePrint = true;
        public bool isDiscountInfomationPrint = false;

        public string WebsitePrintTest = "";
        public string DiscountInfomationPrintTest = "";


        #endregion
    }
}