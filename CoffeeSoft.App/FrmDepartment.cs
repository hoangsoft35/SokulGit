using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//
//using CoffeeSoft.Contract.Models;

namespace CoffeeSoft.App
{

    using CoffeeSoft.App.General;
    public partial class FrmDepartment : Form
    {
        //private DepartmentModel model = new DepartmentModel();
        //private IServices service;
        //public FrmDepartment()
        //{
        //    service = new Services();
        //    InitializeComponent();
        //}


        //private void UpdateModel()
        //{
        //    model.DepartmentId = int.Parse(txtDepartmentId.Text != "" ? txtDepartmentId.Text : "0");
        //    model.DepartmentName = txtDepartmentName.Text;
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;

        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgDepartment.DataSource = this.service.ListDepartment();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtDepartmentId.Text = "";
        //        txtDepartmentName.Text = "";
        //        txtDateCreate.Text = "";

        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {


        //        if (!Validator.IsNull(txtDepartmentName.Text))
        //        {
        //            MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
        //            return;
        //        }
        //        UpdateModel();
        //        model.EffectiveFromDate = DateTime.Now;
        //        model.DateCreate = DateTime.Now;
        //        model.DepartmentId = 0;
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateDepartment(this.model);
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
        //            if (model.DepartmentId > 0)
        //            {
        //                var result = service.DeleteDepartment(model);
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
        //            if (model.DepartmentId == 0)
        //            {
        //                MessageBox.Show("Chọn loại sản phẩm cần cập nhật");
        //                return;
        //            }
        //            if (!Validator.IsNull(txtDepartmentName.Text))
        //            {
        //                MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
        //                return;
        //            }

        //            UpdateModel();
        //            var result = service.SaveOrUpdateDepartment(model);


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

        //private void FrmDepartment_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "department_add"))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "department_edit"))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "department_delete"))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}
        //private void dtgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    try
        //    {
        //        model = (DepartmentModel)dtgDepartment.SelectedRows[0].DataBoundItem;


        //        txtDepartmentId.Text = model.DepartmentId.ToString();
        //        txtDepartmentName.Text = model.DepartmentName;
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
    }
}
