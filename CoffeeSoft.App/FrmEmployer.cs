using System;
using System.Windows.Forms;


namespace CoffeeSoft.App
{
    //using CoffeeSoft.Contract.Models;
    //using CoffeeSoft.Contract.Services;
    //using CoffeeSoft.Service.Services;
    using CoffeeSoft.App.General;
    using DevExpress.XtraEditors;
    public partial class FrmEmployer : Form
    {
        //private EmployerModel model = new EmployerModel();

        //private IServices service;
        //public FrmEmployer()
        //{
        //    service=new Services();
        //    InitializeComponent();
        //}

        //private void FrmEmployer_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //    LoadDataDepartment();

        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "emp_add"))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "emp_edit"))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "emp_delete"))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}
        //private void LoadDataDepartment()
        //{
        //    ddlDepartment.Properties.DataSource = service.ListDepartment();
        //    ddlDepartment.Properties.ValueMember = "DepartmentId";
        //    ddlDepartment.Properties.DisplayMember = "DepartmentName";
        //}
        //private void UpdateModel()
        //{
        //    model.EmployerId = int.Parse(txtEmployerId.Text != "" ? txtEmployerId.Text : "0");
        //    model.FirstName = txtFirstName.Text;
        //    model.LastName = txtLastName.Text;
        //    model.MiddleName = txtMiddleName.Text;
        //    model.FullName = txtLastName.Text + " " + txtMiddleName.Text + " " + txtFirstName.Text;
        //    model.Address = txtAdrress.Text;
        //    model.IdCard = txtIdCard.Text;
        //    model.Mobile = txtMobile.Text;
        //    model.Phone = txtMobile.Text;
        //    model.Dob = DateTime.Parse(dtpDob.EditValue.ToString());
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;
        //    model.DepartmentId = int.Parse(ddlDepartment.EditValue.ToString());
        //    model.DateWork = DateTime.Parse(dtpDateWork.EditValue.ToString());

        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgEmployer.DataSource = this.service.ListEmployer();;
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtEmployerId.Text = "";
        //        txtFirstName.Text = "";
        //        txtLastName.Text = "";
        //        txtMiddleName.Text = "";
        //        txtFirstName.Text = "";
        //        txtAdrress.Text = "";
        //        txtIdCard.Text = "";
        //        dtpDob.Text = "";
        //        txtMobile.Text = "";
        //        txtPhone.Text = "";
        //        dtpDateWork.EditValue = null;
        //        ddlDepartment.EditValue = null;


        //        txtDateCreate.Text = "";

        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {


        //        if (!Validator.IsNull(txtFirstName.Text) || !Validator.IsNull(txtMiddleName.Text) || !Validator.IsNull(txtLastName.Text))
        //        {
        //            MessageBox.Show("Tên Khách hàng không thể bỏ trống");
        //            return;
        //        }

        //        if (ddlDepartment.EditValue==null || ddlDepartment.Text =="")
        //        {
        //            MessageBox.Show("Bạn chưa chọn phòng ban");
        //            return;
        //        }
        //        if (dtpDateWork.EditValue == null || dtpDateWork.Text == "")
        //        {
        //            MessageBox.Show("Bạn chưa chọn ngày vào làm");
        //            return;
        //        }

        //        UpdateModel();
        //        model.EffectiveFromDate = DateTime.Now;
        //        model.DateCreate = DateTime.Now;
        //        model.EmployerId = 0;
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateEmployer(this.model);
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
        //            if (model.EmployerId > 0)
        //            {
        //                var result = service.DeleteEmployer(model);
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
        //            if (model.EmployerId == 0)
        //            {
        //                MessageBox.Show("Chọn khách hàng cần cập nhật");
        //                return;
        //            }
        //            if (!Validator.IsNull(txtFirstName.Text) || !Validator.IsNull(txtMiddleName.Text) || !Validator.IsNull(txtLastName.Text))
        //            {
        //                MessageBox.Show("Tên Khách hàng không thể bỏ trống");
        //                return;
        //            }
        //            if (ddlDepartment.EditValue == null || ddlDepartment.Text == "")
        //            {
        //                MessageBox.Show("Bạn chưa chọn phòng ban");
        //                return;
        //            }
        //            if (dtpDateWork.EditValue == null || dtpDateWork.Text == "")
        //            {
        //                MessageBox.Show("Bạn chưa chọn ngày vào làm");
        //                return;
        //            }
        //            UpdateModel();
        //            var result = service.SaveOrUpdateEmployer(model);


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

        //private void dtgEmployer_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        model = (EmployerModel)dtgEmployer.SelectedRows[0].DataBoundItem;


        //        txtEmployerId.Text = model.EmployerId.ToString();
        //        txtFirstName.Text = model.FirstName;
        //        txtLastName.Text = model.LastName;
        //        ddlDepartment.EditValue = model.DepartmentId;
        //        txtMiddleName.Text = model.MiddleName;

        //        txtFirstName.Text = model.FirstName;
        //        txtAdrress.Text = model.Address;
        //        txtIdCard.Text = model.IdCard;
        //        dtpDob.EditValue = model.Dob;
        //        txtMobile.Text = model.Mobile;
        //        txtPhone.Text = model.Phone;
        //        dtpDateWork.EditValue = model.DateWork;
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

        //private void dtpDateWork_EditValueChanged(object sender, EventArgs e)
        //{

        //}
    }
}
