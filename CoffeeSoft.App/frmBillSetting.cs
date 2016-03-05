using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CoffeeSoft.App.General;
using CoffeeSoft.App.Properties;

namespace CoffeeSoft.App
{
    public partial class frmBillSetting : DevExpress.XtraEditors.XtraForm
    {
        public frmBillSetting()
        {
            InitializeComponent();
        }

       
        private void chktitle_CheckedChanged(object sender, EventArgs e)
        {
            if (chktitle.Checked)
            {
                lbltitle.Text = txtTitle.Text;
                lbltitle.Visible = true;
                txtTitle.Enabled = true;
                return;
            }
            lbltitle.Visible = false;
            txtTitle.Enabled = false;
        }

        private void txtDiscountText_TextChanged(object sender, EventArgs e)
        {
            lblDiscountTest.Text = txtDiscountText.Text;
        }

        private string oldUrl = "";
        private string newUrl = "";
        private void btnloadimage_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = Resources.ImageFilter;
            open.ShowDialog();
            picLogo.ImageLocation = open.FileName;
            pictureBox2.ImageLocation = open.FileName;
            oldUrl = open.FileName;
            newUrl = General.general.GetStartupPath() + "img\\logo.png";


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            File.Copy(oldUrl,newUrl,true);
            MessageBox.Show("Lưu thành công","Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (rdblogoimage.Checked && oldUrl!=null &&newUrl !=null && oldUrl.Trim()!= newUrl.Trim())
                {
                    Image img = Image.FromFile(oldUrl);
                    if (img.Width > 190 || img.Height > 95)
                    {
                        MessageBox.Show(
                            "Kích thước logo không đúng chiều rộng và chiều cao phải nhỏ hơn hoặc bằng 190 và 95 pixel xin vui lòng kiểm tra lại",
                            "Lỗi");
                        return;
                    }
                    if (File.Exists(newUrl))
                    {
                        if (MessageBox.Show("Đã tồn tại logo bạn có muốn ghi đè lên file cũ ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            File.Delete(newUrl);
                            img.Save(newUrl, ImageFormat.Png);
                        }
                    }
                    img.Save(newUrl, ImageFormat.Png);
                }
               


                string pathPrinterSettingFile = general.GetStartupPath() + "BillSetting.xml";
                try
                {
                    File.Delete(pathPrinterSettingFile);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
                var fs = new FileStream(pathPrinterSettingFile, FileMode.OpenOrCreate);
                var print = new BillSetting();

                general.titlePrint = txtTitle.Text;
                general.isTitlePrint = chktitle.Checked;


                general.logoTextPrint = txtLogoText.Text;
                general.isLogoTextPrint = rdblogotext.Checked;

                general.isLogoImagePrint = rdblogoimage.Checked;
                general.isDatePrint = chkExportDate.Checked;
                general.isTimeInPrint = chkTimein.Checked;
                general.isTimeOutPrint = chkTimeOut.Checked;
                general.isTablePrint = chkTable.Checked;
                general.isExportIdPrint = chkExportDate.Checked;
                //general.isCustomerPrint;
                general.isTotalPrint = chkTotal.Checked;
                general.isTotalDiscount = chkDiscount.Checked;
                general.isTotalPayPrint = chkTotalPay.Checked;

                general.isSayGoodByePrint = chkSayGoodbyle.Checked;
                general.isSayGoodByeText1 = txtGoodbyeTop.Text;
                general.isSayGoodByeText2 = txtGoodbyeBot.Text;
                //general.isWebsitePrint;
                general.isDiscountInfomationPrint = chkDiscountinfomation.Checked;
                // general.WebsitePrintTest;
                general.DiscountInfomationPrintTest = txtDiscountText.Text;





                print.titlePrint = txtTitle.Text;
                print.isTitlePrint = chktitle.Checked;


                print.logoTextPrint = txtLogoText.Text;
                print.isLogoTextPrint = rdblogotext.Checked;

                print.isLogoImagePrint = rdblogoimage.Checked;
                print.isDatePrint = chkExportDate.Checked;
                print.isTimeInPrint = chkTimein.Checked;
                print.isTimeOutPrint = chkTimeOut.Checked;
                print.isTablePrint = chkTable.Checked;
                print.isExportIdPrint = chkExportNum.Checked;
                //print.isCustomerPrint;
                print.isTotalPrint = chkTotal.Checked;
                print.isTotalDiscount = chkDiscount.Checked;
                print.isTotalPayPrint = chkTotalPay.Checked;

                print.isSayGoodByePrint = chkSayGoodbyle.Checked;
                print.isSayGoodByeText1 = txtGoodbyeTop.Text;
                print.isSayGoodByeText2 = txtGoodbyeBot.Text;
                //print.isWebsitePrint;
                print.isDiscountInfomationPrint = chkDiscountinfomation.Checked;
                // print.WebsitePrintTest;
                print.DiscountInfomationPrintTest = txtDiscountText.Text;





                XmlSerializer xSer = new XmlSerializer(typeof(BillSetting));
                xSer.Serialize(fs, print);
                fs.Close();
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void rdblogotext_CheckedChanged(object sender, EventArgs e)
        {
            if (rdblogotext.Checked)
            {
                lblLogoText.Text = txtLogoText.Text;
                lblLogoText.Visible = true;
                picLogo.Visible = false;
                txtLogoText.Enabled = true;
                
            }
            
        }

        private void rdblogoimage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdblogoimage.Checked == true)
            {
                lblLogoText.Visible = false;
                txtLogoText.Enabled = false;
                picLogo.Visible = true;
                btnloadimage.Enabled = true;
                return;
                
            }
            btnloadimage.Enabled = false;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lbltitle.Text = txtTitle.Text;
        }

        private void txtLogoText_TextChanged(object sender, EventArgs e)
        {
            lblLogoText.Text = txtLogoText.Text;
        }

        private void chkExportDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExportDate.Checked)
            {
                lblDateExp.Visible = true;
                return;
            }
            lblDateExp.Visible = false;
        }

        private void chkTimein_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimein.Checked)
            {
                lblTimein.Visible = true;
                return;
            }
            lblTimein.Visible = false;
        }

        private void chkTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeOut.Checked)
            {
                lblTimeOut.Visible = true;
                return;
            }
            lblTimeOut.Visible = false;
        }

        private void chkTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTable.Checked)
            {
                lblTable.Visible = true;
                return;
            }
            lblTable.Visible = false;
        }

        private void chkExportNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExportNum.Checked)
            {
                lblExpNum.Visible = true;
                return;
            }
            lblExpNum.Visible = false;
        }

        private void chkTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTotal.Checked)
            {
                lblTotal.Visible = true;
                lblTotal1.Visible = true;
                return;
            }
            lblTotal.Visible = false;
            lblTotal1.Visible = false;
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount.Checked)
            {
                lblDiscount.Visible = true;
                return;
            }
            lblDiscount.Visible = false;
        }

        private void chkTotalPay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTotalPay.Checked)
            {
                lblTotalPay.Visible = true;
                lblTotalPay1.Visible = true;
                return;
            }
            lblTotalPay.Visible = false;
            lblTotalPay1.Visible = false;
        }

        private void chkSayGoodbyle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSayGoodbyle.Checked)
            {
                lblSayGoodbyebot.Text = txtGoodbyeBot.Text;
                lblSayGoodbyetop.Text = txtGoodbyeTop.Text;
                lblSayGoodbyebot.Visible = true;
                lblSayGoodbyetop.Visible = true;
                txtGoodbyeBot.Enabled = true;
                txtGoodbyeTop.Enabled = true;
                return;
            }
            lblSayGoodbyebot.Visible = false;
            lblSayGoodbyetop.Visible = false;
            txtGoodbyeBot.Enabled = false;
            txtGoodbyeTop.Enabled = false;
        }

        private void chkDiscountinfomation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscountinfomation.Checked)
            {
                lblDiscountTest.Text = txtDiscountText.Text;
                lblDiscountTest.Visible = true;
                txtDiscountText.Enabled = true;
                return;
            }
            lblDiscountTest.Visible = false;
            txtDiscountText.Enabled = false;
        }

        private void txtGoodbyeTop_TextChanged(object sender, EventArgs e)
        {
            lblSayGoodbyetop.Text = txtGoodbyeTop.Text;
        }

        private void txtGoodbyeBot_TextChanged(object sender, EventArgs e)
        {
            lblSayGoodbyebot.Text = txtGoodbyeBot.Text;
        }

        private void frmBillSetting_Load(object sender, EventArgs e)
        {
            var imgUrl = General.general.GetStartupPath() + "img\\logo.png";

            if (File.Exists(imgUrl))
            {
                picLogo.ImageLocation = imgUrl;
                pictureBox2.ImageLocation = imgUrl;
                this.oldUrl = imgUrl;
                this.newUrl = General.general.GetStartupPath() + "img\\logo.png";
            }

            // load printer
            string pathBillSettingFile = general.GetStartupPath() + "BillSetting.xml";

            if (File.Exists(pathBillSettingFile))
            {
                var fs = new FileStream(pathBillSettingFile, FileMode.Open);

                var _xSer = new XmlSerializer(typeof(BillSetting));

                var myObject = (BillSetting)_xSer.Deserialize(fs);

                this.txtTitle.Text = myObject.titlePrint;
                this.chktitle.Checked = myObject.isTitlePrint;
                this.txtLogoText.Text = myObject.logoTextPrint;
                this.rdblogotext.Checked = myObject.isLogoTextPrint;
                this.rdblogoimage.Checked = myObject.isLogoImagePrint;
                this.chkExportDate.Checked = myObject.isDatePrint;
                this.chkTimein.Checked = myObject.isTimeInPrint;
                this.chkTimeOut.Checked = myObject.isTimeOutPrint;
                this.chkTable.Checked = myObject.isTablePrint;
                this.chkExportNum.Checked = myObject.isExportIdPrint;

                // myObject.isCustomerPrint;
                this.chkTotal.Checked = myObject.isTotalPrint;
                this.chkDiscount.Checked = myObject.isTotalDiscount;
                this.chkTotalPay.Checked = myObject.isTotalPayPrint;
                this.chkSayGoodbyle.Checked = myObject.isSayGoodByePrint;
                this.txtGoodbyeTop.Text = myObject.isSayGoodByeText1;
                this.txtGoodbyeBot.Text = myObject.isSayGoodByeText2;

                // myObject.isWebsitePrint;
                this.chkDiscountinfomation.Checked = myObject.isDiscountInfomationPrint;

                // myObject.WebsitePrintTest;
                this.txtDiscountText.Text = myObject.DiscountInfomationPrintTest;
                fs.Close();
            }
        }
    }
}