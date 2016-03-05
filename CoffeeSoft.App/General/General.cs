using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CoffeeSoft.App.General
{
    public class general
    {

        public static bool isAdministrator=false;

        public static int TableId;
        public static string MemberCardNumberActive="";
        public static int itemId;
        public static int itemPriceId;
        public static decimal currentPriceValue;
        public static string userName = "admin";
        public static int empId = 1;
        public static string ExportId;

        public static int tableIdJoinOrSplit;
        public static DateTimeOffset DateCreate;
        public static DateTimeOffset? DatePaid;
        public static string tableName;
        public static string areaName;
        public static int groupUserCode;

        public static bool SuccessFlag = false;

        #region Print Setting
        public static string PrinterBillName = "POS-58";
        public static string PrinterReportName = "";
        #endregion
        #region Print Setting Bill
        public static string titlePrint = "Trà Sữa Trân Châu";
        public static bool isTitlePrint = true;

        public static string logoTextPrint = "SOKUL";
        public static bool isLogoTextPrint = false;

        public static bool isLogoImagePrint = true;

        public static bool isDatePrint = true;
        public static bool isTimeInPrint = true;
        public static bool isTimeOutPrint = true;
        public static bool isTablePrint = true;
        public static bool isExportIdPrint = true;
        public static bool isCustomerPrint = true;
        public static bool isTotalPrint = true;
        public static bool isTotalDiscount = true;
        public static bool isTotalPayPrint = true;
        public static bool isSayGoodByePrint = true;
        public static string isSayGoodByeText1 = "Cảm ơn quý khách !";
        public static string isSayGoodByeText2 = "Hẹn gặp lại !";
        public static bool isWebsitePrint = false;
        public static bool isDiscountInfomationPrint = false;
        public static string WebsitePrintTest = "";
        public static string DiscountInfomationPrintTest = "";

        public static int CompanyId;
        public static Guid UserKey;
        #endregion

        #region shortcut
        public static string  SLIPT="";
                public static string  JOIN="";
        public static string  NEWTABLE="";
        public static string  PAID="";
        public static string  PRINTAGAIN="";
        public static string  PRINTNOTPAY="";
        public static string  REPORT="";
        public static string  CHANGEPASS="";
        public static string  HELP="";
        #endregion


        public static string GetStartupPath()
        {
            return Application.StartupPath.Remove(Application.StartupPath.Length - 9, 9);
   
        }
   

        public static DataTable GetDefaultPrinter()
        {
            var dt = new DataTable();
            DataColumn printerName = new DataColumn("PrinterName");
            dt.Columns.Add(printerName);
            DataRow r;
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                r = dt.NewRow();
                r["PrinterName"] = printer;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public static string delConfirmInfo = "Bạn có thực sự muốn xóa dữ liệu này";
        public static string delConfirmCaption = "Thông báo";

       

        public static bool isAdmin = false;

        public static Guid groupUserId;

        public static int KulValue=0;

        public static decimal TotalExportValue=0;


        public static decimal TableDiscount = 0;

        public static string UserFullName = "";
        public static decimal addPaidAmount = 0;

        #region Print Debt

        public static DateTime? DebtDateFrom = null;

        public static DateTime? DebtDateTo = null;

        public static decimal TotalFromTo = 0;

        public static decimal TotalOldDebt = 0;

        public static decimal TotalOldAndNew = 0;

        public static decimal TotalPaid = 0;

        public static decimal TotalDebt = 0;




        #endregion

        public static void ChangeButtonStatus(string ActionName, object btninsertName, object btnUpdateName, object btndelname)
        {
            if (ActionName == "insert" && ((Button)btninsertName).Text == "THÊM MỚI")
            {
                ((Button)btninsertName).Text = "LƯU";
                ((Button)btnUpdateName).Text = "HỦY";
                ((Button)btndelname).Enabled = false;
                return;
                ;
            }
            else if (ActionName == "insert" && ((Button)btninsertName).Text == "LƯU")
            {
                ((Button)btninsertName).Text = "THÊM MỚI";
                ((Button)btnUpdateName).Text = "CẬP NHẬT";
                ((Button)btndelname).Enabled = true;
                return;
            }
            else if (ActionName == "update" && ((Button)btnUpdateName).Text == "HỦY")
            {
                ((Button)btninsertName).Text = "THÊM MỚI";
                ((Button)btnUpdateName).Text = "CẬP NHẬT";
                ((Button)btndelname).Enabled = true;
                return;
            }
            else if (ActionName == "update" && ((Button)btnUpdateName).Text == "CẬP NHẬT")
            {
                ((Button)btninsertName).Enabled = false;
                ((Button)btnUpdateName).Text = "LƯU";
                ((Button)btndelname).Text = "HỦY";
                return;
            }
            else if (ActionName == "update" && ((Button)btnUpdateName).Text == "LƯU")
            {
                ((Button)btninsertName).Enabled = true;
                ((Button)btnUpdateName).Text = "CẬP NHẬT";
                ((Button)btndelname).Text = "XÓA";
                return;
            }
            else if (ActionName == "delete" && ((Button)btndelname).Text == "HỦY")
            {
                ((Button)btninsertName).Enabled = true;
                ((Button)btnUpdateName).Text = "CẬP NHẬT";
                ((Button)btndelname).Text = "XÓA";
                return;
            }
            else if (ActionName == "insert" && ((Button)btndelname).Text == "HỦY")
            {
                return;
            }


        }


        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }


        private static string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }


        private static string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }


            return Ktach;

        }

        public static string DetachMoney(double gNum)
        {
            if (gNum == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

            return lso_chu.ToString().Trim();

        }
    }
}
