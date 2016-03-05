using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CoffeeSoft.App.General;


namespace CoffeeSoft.App
{
    public partial class frmShortcutSetting : DevExpress.XtraEditors.XtraForm
    {
        public frmShortcutSetting()
        {
            InitializeComponent();
        }
        string pathShortcutSettingFile = general.GetStartupPath() + "ShortcutSetting.xml";

        private void frmShortcutSetting_Load(object sender, EventArgs e)
        {

            if (File.Exists(pathShortcutSettingFile))
            {
                FileStream fs = new FileStream(pathShortcutSettingFile, FileMode.Open);

                XmlSerializer _xSer = new XmlSerializer(typeof(ShortcutSetting));

                try
                {
                    var myObject = (ShortcutSetting)_xSer.Deserialize(fs);
                    cbosplit.Text = myObject.SLIPT;
                    cbojoin.Text = myObject.JOIN;
                    cbonewtable.Text = myObject.NEWTABLE;
                    cbopaid.Text = myObject.PAID;
                    cboprintagain.Text = myObject.PRINTAGAIN;
                    cboprintnotpay.Text = myObject.PRINTNOTPAY;
                    cboreport.Text = myObject.REPORT;
                    cbochangepass.Text = myObject.CHANGEPASS;
                    cbohelp.Text = myObject.HELP;



                }
                catch (Exception)
                {

                    MessageBox.Show("Không thể đọc file cấu hình của hóa đơn");
                    return;
                }



                fs.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbochangepass.Text==cbohelp.Text
                    ||cbochangepass.Text==cbojoin.Text
                ||cbochangepass.Text==cbonewtable.Text
                ||cbochangepass.Text==cbopaid.Text
                ||cbochangepass.Text==cboprintagain.Text
               || cbochangepass.Text==cboprintnotpay.Text
               || cbochangepass.Text==cboreport.Text
                ||cbochangepass.Text==cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }
                if (cbohelp.Text == cbochangepass.Text
                   || cbohelp.Text == cbojoin.Text
               || cbohelp.Text == cbonewtable.Text
               || cbohelp.Text == cbopaid.Text
               || cbohelp.Text == cboprintagain.Text
              || cbohelp.Text == cboprintnotpay.Text
              || cbohelp.Text == cboreport.Text
               || cbohelp.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cbojoin.Text == cbohelp.Text
                   || cbojoin.Text == cbochangepass.Text
               || cbojoin.Text == cbonewtable.Text
               || cbojoin.Text == cbopaid.Text
               || cbojoin.Text == cboprintagain.Text
              || cbojoin.Text == cboprintnotpay.Text
              || cbojoin.Text == cboreport.Text
               || cbojoin.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cbonewtable.Text == cbohelp.Text
                   || cbonewtable.Text == cbojoin.Text
               || cbonewtable.Text == cbochangepass.Text
               || cbonewtable.Text == cbopaid.Text
               || cbonewtable.Text == cboprintagain.Text
              || cbonewtable.Text == cboprintnotpay.Text
              || cbonewtable.Text == cboreport.Text
               || cbonewtable.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cbopaid.Text == cbohelp.Text
                   || cbopaid.Text == cbojoin.Text
               || cbopaid.Text == cbonewtable.Text
               || cbopaid.Text == cbochangepass.Text
               || cbopaid.Text == cboprintagain.Text
              || cbopaid.Text == cboprintnotpay.Text
              || cbopaid.Text == cboreport.Text
               || cbopaid.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cboprintagain.Text == cbohelp.Text
                   || cboprintagain.Text == cbojoin.Text
               || cboprintagain.Text == cbonewtable.Text
               || cboprintagain.Text == cbopaid.Text
               || cboprintagain.Text == cbochangepass.Text
              || cboprintagain.Text == cboprintnotpay.Text
              || cboprintagain.Text == cboreport.Text
               || cboprintagain.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cboprintnotpay.Text == cbohelp.Text
                   || cboprintnotpay.Text == cbojoin.Text
               || cboprintnotpay.Text == cbonewtable.Text
               || cboprintnotpay.Text == cbopaid.Text
               || cboprintnotpay.Text == cboprintagain.Text
              || cboprintnotpay.Text == cbochangepass.Text
              || cboprintnotpay.Text == cboreport.Text
               || cboprintnotpay.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cboreport.Text == cbohelp.Text
                   || cboreport.Text == cbojoin.Text
               || cboreport.Text == cbonewtable.Text
               || cboreport.Text == cbopaid.Text
               || cboreport.Text == cboprintagain.Text
              || cboreport.Text == cboprintnotpay.Text
              || cboreport.Text == cbochangepass.Text
               || cboreport.Text == cbosplit.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }

                if (cbosplit.Text == cbohelp.Text
                   || cbosplit.Text == cbojoin.Text
               || cbosplit.Text == cbonewtable.Text
               || cbosplit.Text == cbopaid.Text
               || cbosplit.Text == cboprintagain.Text
              || cbosplit.Text == cboprintnotpay.Text
              || cbosplit.Text == cboreport.Text
               || cbosplit.Text == cbochangepass.Text)
                {
                    MessageBox.Show("Phím tắt không thể trùng nhau");
                    return;
                }
                FileStream fs = new FileStream(pathShortcutSettingFile, FileMode.Create);
                ShortcutSetting print = new ShortcutSetting();

                general.SLIPT = cbosplit.Text;
                general.JOIN = cbojoin.Text;
                general.NEWTABLE = cbonewtable.Text;
                general.PAID = cbopaid.Text;
                general.PRINTAGAIN = cboprintagain.Text;
                general.PRINTNOTPAY = cboprintnotpay.Text;
                general.REPORT = cboreport.Text;
                general.CHANGEPASS = cbochangepass.Text;
                general.HELP = cbohelp.Text;


                print.SLIPT = cbosplit.Text;
                print.JOIN = cbojoin.Text;
                print.NEWTABLE = cbonewtable.Text;
                print.PAID = cbopaid.Text;
                print.PRINTAGAIN = cboprintagain.Text;
                print.PRINTNOTPAY = cboprintnotpay.Text;
                print.REPORT = cboreport.Text;
                print.CHANGEPASS = cbochangepass.Text;
                print.HELP = cbohelp.Text;
                XmlSerializer xSer = new XmlSerializer(typeof(ShortcutSetting));
                xSer.Serialize(fs, print);
                fs.Close();
               
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}