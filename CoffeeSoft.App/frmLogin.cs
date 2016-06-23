using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Autofac;
using CoffeeSoft.App.General;
using CoffeeSoft.App.Service;
using Hsp.GenericFramework.Commons;


namespace CoffeeSoft.App
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly IServiceInstance service;
        public frmLogin(IServiceInstance serviceInstance)
        {
            service = serviceInstance;
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboCompany.SelectedText.ToString() == "Chọn chi nhánh")
            {
                MessageBox.Show("Bạn phải chọn chi nhánh làm việc", "Thông báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUserName.Text.ToLower().Trim()) || string.IsNullOrWhiteSpace(txtUserName.Text.ToLower().Trim()))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được bỏ trống", "Thông báo");
                return;
            }
            


            var result = service.AccountService.SignIn(txtUserName.Text.ToLower().Trim(), txtPassword.Text.Trim());


            //if (result != null && result.ObjectData.UserName == null)
            //{
            //    MessageBox.Show("Kết nối thất bại vui lòng kiểm tra lại server");
            //    if (Application.OpenForms["frmServerConfig"] == null)
            //    {
            //       var area = new frmServerConfig();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["frmServerConfig"].ShowDialog();

            //    return;

            //}

            if (!string.IsNullOrEmpty(result?.ObjectData?.UserName))
            {
                txtPassword.Text = "";
                general.userName = result.ObjectData.UserName;
                general.groupUserId = result.ObjectData.GroupUserId;
                general.CompanyId = (int) cboCompany.SelectedValue;
                general.UserKey = result.ObjectData.UserKey;

                if (general.userName.ToLower() == "hsproot")
                {
                    general.isAdministrator = true;
                }
                else
                {
                    general.isAdministrator = false;

                }
                // load printer , bill and shortcut setting

                // load printer
                string pathPrinterSettingFile = general.GetStartupPath() + "PrinterSetting.xml";

                if (File.Exists(pathPrinterSettingFile))
                {
                    FileStream fs = new FileStream(pathPrinterSettingFile, FileMode.Open);

                    XmlSerializer _xSer = new XmlSerializer(typeof(PrinterSetting));

                    try
                    {
                        var myObject = (PrinterSetting)_xSer.Deserialize(fs);
                        general.PrinterBillName = myObject.PrinterBillName;
                        general.PrinterReportName = myObject.PrinterReportName;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Không thể đọc file cấu hình của hóa đơn");
                        return;
                    }



                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(pathPrinterSettingFile, FileMode.Create);
                    PrinterSetting print = new PrinterSetting {PrinterBillName = "", PrinterReportName = ""};
                    XmlSerializer xSer = new XmlSerializer(typeof(PrinterSetting));
                    xSer.Serialize(fs, print);
                    fs.Close();
                }


                // load shortcut
                string pathShortcutSettingFile = general.GetStartupPath() + "ShortcutSetting.xml";

                if (File.Exists(pathShortcutSettingFile))
                {
                    FileStream fs = new FileStream(pathShortcutSettingFile, FileMode.Open);

                    XmlSerializer _xSer = new XmlSerializer(typeof(ShortcutSetting));

                    try
                    {
                        var myObject = (ShortcutSetting)_xSer.Deserialize(fs);
                        general.SLIPT = myObject.SLIPT;
                        general.JOIN = myObject.JOIN;
                        general.NEWTABLE = myObject.NEWTABLE;
                        general.PAID = myObject.PAID;
                        general.PRINTAGAIN = myObject.PRINTAGAIN;
                        general.PRINTNOTPAY = myObject.PRINTNOTPAY;
                        general.REPORT = myObject.REPORT;
                        general.CHANGEPASS = myObject.CHANGEPASS;
                        general.HELP = myObject.HELP;



                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Không thể đọc file cấu hình của hóa đơn");
                        return;
                    }



                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(pathShortcutSettingFile, FileMode.Create);
                    ShortcutSetting print = new ShortcutSetting();
                    print.SLIPT = "F1";
                    print.JOIN = "F2";
                    print.NEWTABLE = "F3";
                    print.PAID = "F4";
                    print.PRINTAGAIN = "F5";
                    print.PRINTNOTPAY = "F6";
                    print.REPORT = "F7";
                    print.CHANGEPASS = "F8";
                    print.HELP = "F9";

                    XmlSerializer xSer = new XmlSerializer(typeof(ShortcutSetting));
                    xSer.Serialize(fs, print);
                    fs.Close();
                }


                // load bill
                string pathBillSettingFile = general.GetStartupPath() + "BillSetting.xml";

                if (File.Exists(pathBillSettingFile))
                {

                    FileStream fs = new FileStream(pathBillSettingFile, FileMode.Open);
                    XmlSerializer _xSer;
                    try
                    {
                        _xSer = new XmlSerializer(typeof(BillSetting));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Không thể đọc file cấu hình của máy in");
                        return;
                    }



                    var myObject = (BillSetting)_xSer.Deserialize(fs);

                    general.titlePrint = myObject.titlePrint;
                    general.isTitlePrint = myObject.isTitlePrint;

                    general.logoTextPrint = myObject.logoTextPrint;
                    general.isLogoTextPrint = myObject.isLogoTextPrint;

                    general.isLogoImagePrint = myObject.isLogoImagePrint;

                    general.isDatePrint = myObject.isDatePrint;
                    general.isTimeInPrint = myObject.isTimeInPrint;
                    general.isTimeOutPrint = myObject.isTimeOutPrint;
                    general.isTablePrint = myObject.isTablePrint;
                    general.isExportIdPrint = myObject.isExportIdPrint;
                    general.isCustomerPrint = myObject.isCustomerPrint;
                    general.isTotalPrint = myObject.isTotalPrint;
                    general.isTotalDiscount = myObject.isTotalDiscount;
                    general.isTotalPayPrint = myObject.isTotalPayPrint;
                    general.isSayGoodByePrint = myObject.isSayGoodByePrint;
                    general.isSayGoodByeText1 = myObject.isSayGoodByeText1;
                    general.isSayGoodByeText2 = myObject.isSayGoodByeText2;
                    general.isWebsitePrint = myObject.isWebsitePrint;
                    general.isDiscountInfomationPrint = myObject.isDiscountInfomationPrint;

                    general.WebsitePrintTest = myObject.WebsitePrintTest;
                    general.DiscountInfomationPrintTest = myObject.DiscountInfomationPrintTest;
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(pathBillSettingFile, FileMode.Create);
                    BillSetting print = new BillSetting();
                    print.titlePrint = "Trà Sữa Trân Châu";
                    print.isTitlePrint = true;

                    print.logoTextPrint = "SOKUL";
                    print.isLogoTextPrint = false;

                    print.isLogoImagePrint = true;

                    print.isDatePrint = true;
                    print.isTimeInPrint = true;
                    print.isTimeOutPrint = true;
                    print.isTablePrint = true;
                    print.isExportIdPrint = true;
                    print.isCustomerPrint = true;
                    print.isTotalPrint = true;
                    print.isTotalDiscount = true;
                    print.isTotalPayPrint = true;
                    print.isSayGoodByePrint = true;
                    print.isSayGoodByeText1 = "Cảm ơn quý khách !";
                    print.isSayGoodByeText2 = "Hẹn gặp lại !";
                    print.isWebsitePrint = true;
                    print.isDiscountInfomationPrint = false;

                    print.WebsitePrintTest = "";
                    print.DiscountInfomationPrintTest = "";

                    XmlSerializer xSer = new XmlSerializer(typeof(BillSetting));
                    xSer.Serialize(fs, print);
                    fs.Close();
                }
                this.Hide();

                if (Application.OpenForms["frmControl"] == null)
                {
                    frmControl area = new frmControl(common.Autofac.Container.Resolve<IServiceInstance>());
                    area.Show();
                    return;

                }


                Application.OpenForms["frmControl"].Show();


            }
            else
                MessageBox.Show("Đăng nhập thất bại");
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
            txtUserName.Focus();

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmInfomation"] == null)
            {
                frmInfomation area = new frmInfomation();
                area.ShowDialog();
                return;
            }
            Application.OpenForms["frmInfomation"].ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var listCompany = service.CompanyService.GetAllCompanyByLanguageId(Consts.LangCultures.DefaultWinformAppLanguage);
            cboCompany.DataSource = listCompany;
            cboCompany.DisplayMember = "CompanyName";
            cboCompany.ValueMember = "CompanyId";

        }


    }
}