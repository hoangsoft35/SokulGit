namespace CoffeeSoft.App
{
    using System;
    using System.Windows.Forms;

    using CoffeeSoft.App.General;


    public partial class FrmChangePassword : Form
    {
       
        //  private IServices service;
        //  public FrmChangePassword()
        //{
        //    this.service=new Services();
        //    this.InitializeComponent();
        //}


        //private void btnChange_Click(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrEmpty(this.txtOld.Text))
        //    {
        //        MessageBox.Show("Nhập mật khẩu hiện tại");
        //        return;
        //    }
        //    if (string.IsNullOrEmpty(this.txtNew.Text))
        //    {
        //        MessageBox.Show("Nhập mật khẩu mới");
        //        return;
        //    }
        //    if (this.txtNew.Text!=this.txtConfirmNew.Text)
        //    {
        //        MessageBox.Show("Mật khẩu xác nhận không khớp");
        //        return;
        //    }
        //    if (this.txtOld.Text == this.txtConfirmNew.Text)
        //    {
        //        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ");
        //        return;
        //    }
        //    if (
        //        MessageBox.Show("Bạn có chắc là muốn đặt lại mật khẩu cho tài khoản này ?", "Thông báo",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

        //    {
        //        if (this.service.ChangePassword(general.userName, this.txtOld.Text,this.txtConfirmNew.Text))
        //        {
        //            MessageBox.Show("Đổi mật khẩu thành công");
        //            this.Close();
        //            return;
        //        }
        //        MessageBox.Show("Đổi mật khẩu thất bại. vui lòng thử lại sau");
        //    }
        //}

        //private void FrmChangePassword_Load(object sender, EventArgs e)
        //{

        //}
    }
}
