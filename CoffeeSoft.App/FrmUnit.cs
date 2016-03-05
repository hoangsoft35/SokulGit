namespace CoffeeSoft.App
{
    using System;
    using System.Windows.Forms;

    using CoffeeSoft.App.General;
    

    public partial class FrmUnit : Form
    {
        //private UnitModel model = new UnitModel();

        //private IServices service;
        //public FrmUnit()
        //{
        //    this.InitializeComponent();
        //    this.service=new Services();
        //}

       
        //private void FrmUnit_Load(object sender, EventArgs e)
        //{
        //    //CheckRole();
        //    this.LoadDataGrid();
        //}
        //private void CheckRole()
        //{
        //    if (!this.service.R(general.groupUserId, "unit_add"))
        //    {
        //        this.btnAdd.Enabled = false;

        //    }
        //    if (!this.service.R(general.groupUserId, "unit_edit"))
        //    {
        //        this.btnUpdate.Enabled = false;

        //    }
        //    if (!this.service.R(general.groupUserId, "unit_delete"))
        //    {
        //        this.btnDelete.Enabled = false;

        //    }

        //}



        //private void UpdateModel()
        //{
        //    this.model.UnitId = int.Parse(this.txtUnitId.Text != "" ? this.txtUnitId.Text : "0");
        //    this.model.UnitName = this.txtUnitName.Text;
        //    this.model.UpdateBy = general.userName;
        //    this.model.LastUpdate = DateTime.Now;
        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgAgency.DataSource = this.service.ListUnit();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
           




        //    if (this.btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
           
        //        this.txtUnitId.Text = "";
        //        this.txtUnitName.Text = "";
        //        this.txtDateCreate.Text = "";

        //        this.txtLastUpdate.Text = "";
        //        this.txtUserCreate.Text = "";
        //        this.txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (this.btnAdd.Text == "LƯU")
        //    {


        //        if (!Validator.IsNull(this.txtUnitName.Text))
        //        {
        //            MessageBox.Show("Tên đơn vị tính không thể bỏ trống");
        //            return;
        //        }
        //        this.UpdateModel();
        //        this.model.EffectiveFromDate = DateTime.Now;
        //        this.model.DateCreate = DateTime.Now;
        //        this.model.UnitId = 0;
        //        this.model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateUnit(this.model);
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


        //    if (this.btnDelete.Text == "HỦY")
        //    {
        //        general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

        //    }
        //    else if (this.btnDelete.Text == "XÓA")
        //    {
        //        if (MessageBox.Show(general.delConfirmInfo, general.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            this.UpdateModel();
        //            if (this.model.UnitId > 0)
        //            {
        //                var result = this.service.DeleteUnit(this.model);
        //                if (result)
        //                {
        //                    general.ChangeButtonStatus("delete", this.btnAdd, this.btnUpdate, this.btnDelete);
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

        //    if (this.btnUpdate.Text == "CẬP NHẬT")
        //    {
        //        general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

        //        return;

        //    }
        //    else
        //        if (this.btnUpdate.Text == "HỦY")
        //        {
        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);


        //        }
        //        else if (this.btnUpdate.Text == "LƯU")
        //        {
        //            if (this.txtUnitId.Text== "")
        //            {
        //                MessageBox.Show("Chọn đơn vị tính cần cập nhật");
        //                return;
        //            }
        //            if (!Validator.IsNull(this.txtUnitName.Text))
        //            {
        //                MessageBox.Show("Tên đơn vị tính không thể bỏ trống");
        //                return;
        //            }

        //            this.UpdateModel();
        //            var result = this.service.SaveOrUpdateUnit(this.model);


        //            if (result != null)
        //            {
        //                MessageBox.Show("Cập nhật thành công", "Thông báo");
        //                this.LoadDataGrid();
        //                general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

        //            }
        //        }
        //        else
        //            MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");
        //}


        //private void dtgAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        this.model = (UnitModel)this.dtgAgency.SelectedRows[0].DataBoundItem;


        //        this.txtUnitId.Text = this.model.UnitId.ToString();
        //        this.txtUnitName.Text = this.model.UnitName;
        //        this.txtDateCreate.Text = this.model.DateCreate != null
        //                                 ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                     this.model.LastUpdate)
        //                                 : "";

        //        this.txtLastUpdate.Text = this.model.LastUpdate != null ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                    this.model.LastUpdate) :
        //        "";
        //        this.txtUserCreate.Text = this.model.UserCreate ?? "";
        //        this.txtUserUpdate.Text = this.model.UpdateBy ?? "";
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}

      
    }
}
