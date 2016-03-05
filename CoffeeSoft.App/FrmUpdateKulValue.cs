using System;
using System.Windows.Forms;
using CoffeeSoft.App.General;

namespace CoffeeSoft.App
{
    public partial class FrmUpdateKulValue : Form
    {
        //private IServices service;
       
        //public FrmUpdateKulValue()
        //{
        //    service=new Services();
        //    InitializeComponent();
        //}

        //private KulExchangeModel result;
        //private void FrmUpdateKulValue_Load(object sender, EventArgs e)
        //{
        //    LoadDataKul();
        //}

        //private void LoadDataKul()
        //{
        //    result = service.GetCurrentKulExchange();
        //    if (result != null)
        //    {
        //        txtKulId.Text = result.KulId;
        //        txtKulDes.Text = result.KulDescription;
        //        txtKulName.Text = result.KulName;
        //        txtCurrentKul.Text = result.Value.ToString("N0");
        //        txtNewKul.Text = result.Value.ToString("N0");
        //    }
        //}

        //private void btnChange_Click(object sender, EventArgs e)
        //{
        //    if (txtKulName.Text.Trim() =="")
        //    {
        //        MessageBox.Show("Tên không được để trống");
        //        return;
        //    }
        //    if (txtKulDes.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Mô tả không được để trống");
        //        return;
        //    }
        //    if (txtNewKul.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Giá trị mới cho Kul không được để trống");
        //        return;
        //    }

        //    if (int.Parse(txtNewKul.Text.Trim())<=0)
        //    {
        //        MessageBox.Show("Giá trị mới cho Kul không được là số âm và phải lớn hơn 0");
        //        return;
        //    }
        //    result.KulDescription = txtKulDes.Text;
        //    result.KulName = txtKulName.Text;
        //    result.Value = int.Parse(txtNewKul.Text);
        //    result.LastUpdate = DateTime.Now;
        //    result.UpdateBy = general.userName;
        //    var final=service.UpdateKulValue(result);
        //    if (final!=null)
        //    {
        //        MessageBox.Show("Thay đổi thành công");
        //        LoadDataKul();
        //        return;
        //    }
        //    MessageBox.Show("Thay đổi thất bại, đã có lỗi xãy ra");
            
        //}

        //private void txtNewKul_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar)
        //&& !char.IsDigit(e.KeyChar)
        //&& e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
