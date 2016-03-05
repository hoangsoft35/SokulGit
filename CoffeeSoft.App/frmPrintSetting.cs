using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CoffeeSoft.App.General;


namespace CoffeeSoft.App
{
    public partial class frmPrintSetting : DevExpress.XtraEditors.XtraForm
    {
        public frmPrintSetting()
        {
            InitializeComponent();
        }

        private void frmPrintSetting_Load(object sender, EventArgs e)
        {
            var listPrint=General.general.GetDefaultPrinter();
            glkBill.Properties.DataSource =listPrint ;
            glkReport.Properties.DataSource = listPrint;


            // load printer
            string pathPrinterSettingFile = general.GetStartupPath() + "PrinterSetting.xml";

            if (File.Exists(pathPrinterSettingFile))
            {
                FileStream fs = new FileStream(pathPrinterSettingFile, FileMode.Open);

                XmlSerializer _xSer = new XmlSerializer(typeof(PrinterSetting));

                var myObject = (PrinterSetting)_xSer.Deserialize(fs);

                glkBill.EditValue = myObject.PrinterBillName;
                glkReport.EditValue = myObject.PrinterReportName;
                fs.Close();
            }
           


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string pathPrinterSettingFile = general.GetStartupPath() + "\\PrinterSetting.xml";

                FileStream fs = new FileStream(pathPrinterSettingFile, FileMode.Create);
                PrinterSetting print = new PrinterSetting();
                print.PrinterBillName = glkBill.EditValue.ToString();
                print.PrinterReportName = glkReport.EditValue.ToString();
                XmlSerializer xSer = new XmlSerializer(typeof(PrinterSetting));
                xSer.Serialize(fs, print);
                fs.Close();
                general.PrinterBillName = glkBill.EditValue.ToString();
                general.PrinterReportName = glkReport.EditValue.ToString();
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            catch (Exception)
            {
                
                return;
            }
            
        }
    }
}