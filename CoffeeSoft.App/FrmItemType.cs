namespace CoffeeSoft.App
{
    using System.Windows.Forms;


    public partial class FrmItemType : Form
    {
        //private ItemTypeModel model = new ItemTypeModel();

        //private IServices service;
        //public FrmItemType()
        //{
        //    this.InitializeComponent();
        //    this.service =new Services();
        //}


        //private void UpdateModel()
        //{
        //    this.model.ItemTypeId = int.Parse(this.txtItemTypeId.Text !=""?this.txtItemTypeId.Text:"0");
        //    this.model.ItemTypeName = this.txtItemTypeName.Text;
       
        //    this.model.UpdateBy = general.userName;
        //    this.model.LastUpdate = DateTime.Now;

        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgItemType.DataSource = this.service.ListItemType();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
          




        //    if (this.btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);

        //        this.txtItemTypeId.Text = "";
        //        this.txtItemTypeName.Text = "";
        //        this.txtDateCreate.Text = "";

        //        this.txtLastUpdate.Text = "";
        //        this.txtUserCreate.Text = "";
        //        this.txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (this.btnAdd.Text == "LƯU")
        //    {


        //        if (!Validator.IsNull(this.txtItemTypeName.Text))
        //        {
        //            MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
        //            return;
        //        }
        //        this.UpdateModel();
        //        this.model.EffectiveFromDate = DateTime.Now;
        //        this.model.DateCreate = DateTime.Now;
        //        this.model.ItemTypeId = 0;
              
        //        this.model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateItemType(this.model);
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
        //            if (this.model.ItemTypeId > 0)
        //            {
        //                var result = this.service.DeleteItemType(this.model);
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
        //            if (this.model.ItemTypeId == 0)
        //            {
        //                MessageBox.Show("Chọn loại sản phẩm cần cập nhật");
        //                return;
        //            }
        //            if (!Validator.IsNull(this.txtItemTypeName.Text))
        //            {
        //                MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
        //                return;
        //            }

        //            this.UpdateModel();
        //            var result = this.service.SaveOrUpdateItemType(this.model);


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
        //private void dtgItemType_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        this.model = (ItemTypeModel)this.dtgItemType.SelectedRows[0].DataBoundItem;


        //        this.txtItemTypeId.Text = this.model.ItemTypeId.ToString();
        //        this.txtItemTypeName.Text = this.model.ItemTypeName;
              
                
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

        //private void FrmItemType_Load(object sender, EventArgs e)
        //{
        //    //this.CheckRole();
        //    this.LoadDataGrid();
        //}
        //private void CheckRole()
        //{
        //    if (!this.service.R(general.groupUserId, "itemtype_add"))
        //    {
        //        this.btnAdd.Enabled = false;

        //    }
        //    if (!this.service.R(general.groupUserId, "itemtype_edit"))
        //    {
        //        this.btnUpdate.Enabled = false;

        //    }
        //    if (!this.service.R(general.groupUserId, "itemtype_delete"))
        //    {
        //        this.btnDelete.Enabled = false;

        //    }

        //}
    }
}
