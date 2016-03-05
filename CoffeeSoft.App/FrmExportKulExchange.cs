using System;
using System.Windows.Forms;
using CoffeeSoft.App.General;

namespace CoffeeSoft.App
{
    public partial class FrmExportKulExchange : Form
    {



        //private ExportKulExchangeModel model = new ExportKulExchangeModel();
        //private IServices service;
        //public FrmExportKulExchange()
        //{
        //    service = new Services();
        //    InitializeComponent();
        //}


        //private void UpdateModel()
        //{
        //    model.ExportKulExchangeId = int.Parse(txtExportKulExchangeId.Text != "" ? txtExportKulExchangeId.Text : "0");
        //    model.From = decimal.Parse(txtFrom.EditValue.ToString());
        //    model.To = decimal.Parse(txtTo.EditValue.ToString());
        //    model.KulValue = int.Parse(txtKulValue.EditValue.ToString());
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;

        //}

        //private bool ValidateForm()
        //{
        //    if (string.IsNullOrEmpty(txtFrom.EditValue.ToString()))
        //    {
        //        MessageBox.Show("Nhập số tiền giới hạn giá trị hóa đơn từ ...");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtTo.EditValue.ToString()))
        //    {
        //        MessageBox.Show("Nhập số tiền giới hạn giá trị hóa đơn đến ...");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtKulValue.Text))
        //    {
        //        MessageBox.Show("Nhập số lượng Kul được cộng vào khi hóa đơn mua hàng trong khoảng giới hạn ở trên");
        //        return false;
        //    }
        //    if (int.Parse(txtFrom.EditValue.ToString()) < 0 || int.Parse(txtTo.EditValue.ToString()) < 0 || int.Parse(txtFrom.EditValue.ToString()) >= int.Parse(txtTo.EditValue.ToString()))
        //    {
        //        MessageBox.Show("Số tiền từ.... đến... phải lớn hơn 0 và số tiền <từ> phải nhỏ nhơn số tiền <đến>");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtKulValue.Text) || int.Parse(txtKulValue.Text) < 0)
        //    {
        //        MessageBox.Show("SL Kul không đuợc nhỏ hơn 0");
        //        return false;
        //    }
        //    return true;
        //}
        //private void LoadDataGrid()
        //{
        //    this.dtgDepartment.DataSource = this.service.ListExportKulExchange();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtExportKulExchangeId.Text = "";
        //        txtTo.Text = "";
        //        txtFrom.Text = "";
        //        txtKulValue.Text = "";

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
        //        model.ExportKulExchangeId = 0;
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateExportKulExchange(this.model);
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
        //            if (model.ExportKulExchangeId > 0)
        //            {
        //                var result = service.DeleteExportKulExchange(model);
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
        //            var result = service.SaveOrUpdateExportKulExchange(model);


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

        //private void FrmExportKulExchange_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "kulexport_add"))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "kulexport_edit"))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "kulexport_delete"))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}
        //private void dtgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    try
        //    {
        //        model = (ExportKulExchangeModel)dtgDepartment.SelectedRows[0].DataBoundItem;


        //        txtExportKulExchangeId.Text = model.ExportKulExchangeId.ToString();
        //        txtTo.Text = model.To.ToString("N0");
        //        txtFrom.Text = model.From.ToString("N0");
        //        txtKulValue.Text = model.KulValue.ToString();
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
