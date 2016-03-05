using System;
using System.Windows.Forms;
using CoffeeSoft.App.General;


namespace CoffeeSoft.App
{
    public partial class FrmUserAccount : Form
    {
        //private UserAccountModel model = new UserAccountModel();

        //private IServices service;
        //public FrmUserAccount()
        //{
        //    service=new Services();
        //    InitializeComponent();
        //}

        //private void FrmUserAccount_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //    LoadDataGroupUser();

        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "user_add"))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "user_edit"))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "user_delete"))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //    if (!service.R(general.groupUserId, "reset_pass"))
        //    {
        //        btnResetPassword.Enabled = false;

        //    }

        //}

        //private void LoadDataGroupUser()
        //{
        //    gridGroupUser.Properties.DataSource = service.ListGroupUser();
        //    gridGroupUser.Properties.ValueMember = "GroupUserId";
        //    gridGroupUser.Properties.DisplayMember = "GroupUserName";
        //}
        //private void UpdateModel()
        //{
        //    model.UserName = txtUserName.Text;
        //    model.FirstName = txtFirstName.Text;
        //    model.LastName = txtLastName.Text;
        //    model.MiddleName = txtMiddleName.Text;
        //    model.FullName = txtLastName.Text + " " + txtMiddleName.Text + " " + txtFirstName.Text;
           
        //    model.IdCard = txtIdCard.Text;
        //    model.MobilePhone = txtMobile.Text;
        //    model.HomePhone = txtMobile.Text;
        //    model.Dob = DateTime.Parse(dtpDob.EditValue.ToString());
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;
        //    model.GroupUserId = int.Parse(gridGroupUser.EditValue.ToString());
        //    model.IsAdmin = chkIsAdmin.Checked;
        //    model.Password = txtPassword.Text;
        //    model.Email = txtEmail.Text;



        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgUserAccount.DataSource = this.service.ListUserAccountWithoutAdministrator();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtUserName.Text = "";
        //        txtFirstName.Text = "";
        //        txtLastName.Text = "";
        //        txtMiddleName.Text = "";
        //        txtFirstName.Text = "";
        //        txtEmail.Text = "";
        //        txtIdCard.Text = "";
        //        dtpDob.Text = "";
        //        txtMobile.Text = "";
        //        txtPhone.Text = "";
        //        txtEmail.Text = "";
        //        gridGroupUser.EditValue = null;

        //        txtPassword.Enabled = true;
        //        txtPasswordConfirm.Enabled = true;
        //        txtUserName.Enabled = true;

        //        txtDateCreate.Text = "";

        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {
        //        if (string.IsNullOrEmpty(txtUserName.Text))
        //        {
        //            MessageBox.Show("Nhập tên tài khoản");
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(txtPassword.Text))
        //        {
        //            MessageBox.Show("Nhập mật khẩu");
        //            return;
        //        }

        //        if (txtPassword.Text!=txtPasswordConfirm.Text)
        //        {
        //            MessageBox.Show("Mật khẩu xác nhận không đúng");
        //            return;
        //        }
        //        if (dtpDob.EditValue == null || dtpDob.EditValue == "")
        //        {
        //            MessageBox.Show("Chưa chọn ngày tháng năm sinh");
        //            return;
        //        }


        //        if (!Validator.IsNull(txtFirstName.Text) || !Validator.IsNull(txtMiddleName.Text) || !Validator.IsNull(txtLastName.Text))
        //        {
        //            MessageBox.Show("Tên người dùng không thể bỏ trống");
        //            return;
        //        }

        //        if (gridGroupUser.EditValue==null || gridGroupUser.Text =="")
        //        {
        //            MessageBox.Show("Bạn chưa chọn nhóm người dùng");
        //            return;
        //        }
                

        //        UpdateModel();
              
        //        model.DateCreate = DateTime.Now;
               
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateUserAccount(this.model,true);
        //        if (result != null)
        //        {

        //            MessageBox.Show("Thêm mới thành công", "Thông báo");

        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
        //            txtPassword.Enabled = false;
        //            txtPasswordConfirm.Enabled = false;
        //            txtUserName.Enabled = false;
        //            this.LoadDataGrid();
        //        }
        //    }
        //    else
        //        MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");


        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{


        //    if (btnDelete.Text == "HỦY")
        //    {
        //        general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
        //        txtPassword.Enabled = false;
        //        txtPasswordConfirm.Enabled = false;
        //        txtUserName.Enabled = false;
        //    }
        //    else if (btnDelete.Text == "XÓA")
        //    {
        //        if (MessageBox.Show(general.delConfirmInfo, general.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            this.UpdateModel();
        //            if (!string.IsNullOrEmpty(model.UserName))
        //            {
        //                var result = service.DeleteUserAccount(model);
        //                if (result)
        //                {
        //                    general.ChangeButtonStatus("delete", btnAdd, btnUpdate, btnDelete);
        //                    MessageBox.Show("Xóa thành công", "Thông báo");
        //                    this.LoadDataGrid();
        //                    return;
        //                }
        //                MessageBox.Show("Xóa thất bại", "Thông báo");

        //            }
        //        }
        //    }
        //    else return;
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{

        //    if (btnUpdate.Text == "CẬP NHẬT")
        //    {
        //        general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //        return;

        //    }
        //    else
        //        if (btnUpdate.Text == "HỦY")
        //        {
        //            general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);
        //            txtPassword.Enabled = false;
        //            txtPasswordConfirm.Enabled = false;
        //            txtUserName.Enabled = false;

        //        }
        //        else if (btnUpdate.Text == "LƯU")
        //        {
        //            if (string.IsNullOrEmpty(model.UserName))
        //            {
        //                MessageBox.Show("Chọn người dùng cần cập nhật");
        //                return;
        //            }
        //            if (!Validator.IsNull(txtFirstName.Text) || !Validator.IsNull(txtMiddleName.Text) || !Validator.IsNull(txtLastName.Text))
        //            {
        //                MessageBox.Show("Tên người dùng không thể bỏ trống");
        //                return;
        //            }
        //            if (gridGroupUser.EditValue == null || gridGroupUser.Text == "")
        //            {
        //                MessageBox.Show("Bạn chưa chọn nhóm người dùng");
        //                return;
        //            }
        //            if (dtpDob.EditValue == null)
        //            {
        //                MessageBox.Show("Chưa chọn ngày tháng năm sinh");
        //                return;
        //            }


        //            UpdateModel();
        //            var result = service.SaveOrUpdateUserAccount(model,false);


        //            if (result != null)
        //            {
        //                MessageBox.Show("Cập nhật thành công", "Thông báo");
        //                txtPassword.Enabled = false;
        //                txtPasswordConfirm.Enabled = false;
        //                txtUserName.Enabled = false;
        //                this.LoadDataGrid();
        //                general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //            }
        //        }
        //        else
        //            MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");
        //}

        //private void dtgUserAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        model = (UserAccountModel)dtgUserAccount.SelectedRows[0].DataBoundItem;


        //        txtUserName.Text = model.UserName.ToString();
        //        txtFirstName.Text = model.FirstName;
        //        txtLastName.Text = model.LastName;
        //        gridGroupUser.EditValue = model.GroupUserId;
        //        txtMiddleName.Text = model.MiddleName;

        //        txtFirstName.Text = model.FirstName;
        //        txtEmail.Text = model.Email;
        //        txtIdCard.Text = model.IdCard;
        //        dtpDob.EditValue = model.Dob;
        //        txtMobile.Text = model.MobilePhone;
        //        txtPhone.Text = model.HomePhone;
        //        chkIsAdmin.Checked = model.IsAdmin;
        //        txtDateCreate.Text = model.DateCreate != null
        //                                 ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                     model.LastUpdate)
        //                                 : "";

        //        txtLastUpdate.Text = model.LastUpdate != null ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                    model.LastUpdate) :
        //        "";
        //        txtUserCreate.Text = this.model.UserCreate ?? "";
        //        txtUserUpdate.Text = this.model.UpdateBy ?? "";
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}

        //private void btnResetPassword_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc là muốn đặt lại mật khẩu cho tài khoản này ?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
        //    {
        //       try
        //        {
        //            model = (UserAccountModel)dtgUserAccount.SelectedRows[0].DataBoundItem;
        //            if (model!=null)
        //            {
        //                var result = service.ResetPasswordByUserName(model.UserName);
        //                if (result!="")
        //                {
        //                    MessageBox.Show("Mặc định mật khẩu mới của tài khoản " + model.UserName + " là : " + result+". Vui lòng thay đổi mật khẩu sau khi đăng nhập.");
        //                    return;
        //                }
        //            }
        //            MessageBox.Show("Có lỗi khi đặt lại mật khẩu");
        //        }
        //       catch (Exception)
        //       {

        //           MessageBox.Show("Có lỗi khi đặt lại mật khẩu");
        //       }
                
        //    }
        //}

       
    }
}

