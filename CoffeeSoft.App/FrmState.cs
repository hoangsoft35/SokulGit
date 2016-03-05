using System;
using System.Windows.Forms;
using CoffeeSoft.App.General;

namespace CoffeeSoft.App
{
    

    public partial class FrmState : Form
    {
       

      
        //private StateModel model = new StateModel();
        //private IServices service;
        //public FrmState()
        //{
        //    service = new Services();
        //    InitializeComponent();
        //}


        //private void UpdateModel()
        //{
        //    model.StateId = txtStateId.Text;
        //    model.StateDescription = txtStateDes.Text;
            
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;

        //}

        //private bool ValidateForm()
        //{
        //    if (string.IsNullOrEmpty(txtStateId.EditValue.ToString()))
        //    {
        //        MessageBox.Show("Mã trạng thái không được bỏ trống.");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtStateDes.EditValue.ToString()))
        //    {
        //        MessageBox.Show("Mô tả cho trạng thái không được bỏ trống");
        //        return false;
        //    }
            
        //    return true;
        //}
        //private void LoadDataGrid()
        //{
        //    this.dtgDepartment.DataSource = this.service.ListState();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtStateId.Text = "";
        //        txtStateDes.Text = "";
        //        txtStateId.Enabled = true;

        //        txtDateCreate.Text = "";

        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";


        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {

        //        if (!ValidateForm())
        //        {
        //            return;
        //        }


        //        UpdateModel();
        //        model.EffectiveFromDate = DateTime.Now;
        //        model.DateCreate = DateTime.Now;
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateState(this.model,false);
        //        if (result != null)
        //        {

        //            MessageBox.Show("Thêm mới thành công", "Thông báo");

        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
        //            txtStateId.Enabled = false;
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
        //        txtStateId.Enabled = false;
        //    }
        //    else if (btnDelete.Text == "XÓA")
        //    {
        //        if (MessageBox.Show(general.delConfirmInfo, general.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            this.UpdateModel();
        //            if (model.StateId !="")
        //            {
        //                var result = service.DeleteState(model);
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

        //            if (!ValidateForm())
        //            {
        //                return;
        //            }

        //            UpdateModel();
        //            var result = service.SaveOrUpdateState(model,true);


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

   
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, Role.state_add))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.state_edit))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.state_delete))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}
        //private void dtgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    try
        //    {
        //        model = (StateModel)dtgDepartment.SelectedRows[0].DataBoundItem;


        //        txtStateId.Text = model.StateId;
        //        txtStateDes.Text = model.StateDescription;
              
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

        //private void FrmState_Load_1(object sender, EventArgs e)
        //{
        //     CheckRole();
        //    this.LoadDataGrid();
        //}
    }
}
