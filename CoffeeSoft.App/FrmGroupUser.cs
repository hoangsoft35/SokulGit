using System;
using System.Windows.Forms;

using CoffeeSoft.App.General;
namespace CoffeeSoft.App
{
    public partial class FrmGroupUser : Form
    {
        // private GroupUserModel model = new GroupUserModel();

        //private IServices service;
        //public FrmGroupUser()
        //{
        //    InitializeComponent();
        //    service =new Services();
        //}


        //private void UpdateModel()
        //{
        //    model.GroupUserId = int.Parse(txtItemTypeId.Text !=""?txtItemTypeId.Text:"0");
        //    model.GroupUserName = txtItemTypeName.Text;
        //    model.GroupUserDescription = txtItemTypeDescription.Text;
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;

        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgItemType.DataSource = this.service.ListGroupUserWithoutAdministratorGroup();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
          




        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtItemTypeId.Text = "";
        //        txtItemTypeName.Text = "";
        //        txtDateCreate.Text = "";
        //        txtItemTypeDescription.Text = "";
        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {


        //        if (!Validator.IsNull(txtItemTypeName.Text))
        //        {
        //            MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
        //            return;
        //        }
        //        UpdateModel();
        //        model.EffectiveFromDate = DateTime.Now;
        //        model.DateCreate = DateTime.Now;
        //        model.GroupUserId = 0;
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateGroupUser(this.model);
        //        if (result != null)
        //        {

        //            MessageBox.Show("Thêm mới thành công", "Thông báo");

        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
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

        //    }
        //    else if (btnDelete.Text == "XÓA")
        //    {
        //        if (MessageBox.Show(general.delConfirmInfo, general.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            this.UpdateModel();
        //            if (model.GroupUserId > 0)
        //            {
        //                var result = service.DeleteGroupUser(model);
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


        //        }
        //        else if (btnUpdate.Text == "LƯU")
        //        {
        //            if (model.GroupUserId == 0)
        //            {
        //                MessageBox.Show("Chọn loại sản phẩm cần cập nhật");
        //                return;
        //            }
        //            if (!Validator.IsNull(txtItemTypeName.Text))
        //            {
        //                MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
        //                return;
        //            }

        //            UpdateModel();
        //            var result = service.SaveOrUpdateGroupUser(model);


        //            if (result != null)
        //            {
        //                MessageBox.Show("Cập nhật thành công", "Thông báo");
        //                this.LoadDataGrid();
        //                general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //            }
        //        }
        //        else
        //            MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");
        //}
        //private void dtgItemType_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        model = (GroupUserModel)dtgItemType.SelectedRows[0].DataBoundItem;


        //        txtItemTypeId.Text = model.GroupUserId.ToString();
        //        txtItemTypeName.Text = model.GroupUserName;
        //        txtItemTypeDescription.Text = model.GroupUserDescription;
                
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

        //private void FrmGroupUser_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "groupuser_add"))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "groupuser_edit"))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "groupuser_delete"))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}

       
    }
}
