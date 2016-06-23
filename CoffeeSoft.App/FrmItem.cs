namespace CoffeeSoft.App
{
    using System.Windows.Forms;


    public partial class FrmItem : Form
    {
    //    private ItemModel model = new ItemModel();

    //    private IServices service;
    //    public FrmItem()
    //    {
           
    //        this.InitializeComponent();
    //        this.service=new Services();

    //    }

    //    private void FrmItem_Load(object sender, EventArgs e)
    //    {
    //        //this.CheckRole();
    //        this.LoadDataGrid();
    //        this.LoadDataDropdowList();
    //    }
    //    private void CheckRole()
    //    {
    //        if (!this.service.R(general.groupUserId, "item_add"))
    //        {
    //            this.btnAdd.Enabled = false;

    //        }
    //        if (!this.service.R(general.groupUserId, "item_edit"))
    //        {
    //            this.btnUpdate.Enabled = false;

    //        }
    //        if (!this.service.R(general.groupUserId, "item_delete"))
    //        {
    //            this.btnDelete.Enabled = false;

    //        }

    //    }

    //    private void UpdateModel()
    //    {
    //        this.model.ItemId = int.Parse(this.txtItemId.Text != "" ? this.txtItemId.Text : "0");
    //        this.model.ItemName = this.txtItemName.Text;
    //        this.model.Shortcut = this.txtShortcut.Text;
    //        this.model.ItemTypeId = this.ddlItemType.SelectedItem != null ? (int)this.ddlItemType.SelectedValue : 0;
    //        this.model.UnitId = this.ddlUnit.SelectedValue != null ? (int)this.ddlUnit.SelectedValue : 0;
    //        this.model.IsDrink = chkIsDrink.Checked;
    //        this.model.UpdateBy = general.userName;
    //        this.model.LastUpdate = DateTime.Now;

    //    }


    //    private void LoadDataGrid()
    //    {
    //        this.dtgItem.DataSource = this.service.ListItem();

    //    }
    //    private void LoadDataDropdowList()
    //    {
    //        // itemtype
    //        this.ddlItemType.DisplayMember = "ItemTypeName";
    //        this.ddlItemType.ValueMember = "ItemTypeId";
    //        this.ddlItemType.DataSource = this.service.ListItemType();
          

    //        // unit
    //        this.ddlUnit.DisplayMember = "UnitName";
    //        this.ddlUnit.ValueMember = "UnitId";
    //        this.ddlUnit.DataSource = this.service.ListUnit();
          


    //    }
    //    private void btnAdd_Click(object sender, EventArgs e)
    //    {
           




    //        if (this.btnAdd.Text == "THÊM MỚI")
    //        {
    //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);

    //            this.txtItemId.Text = "";
    //            this.txtItemName.Text = "";
    //            this.txtDateCreate.Text = "";
    //            this.txtShortcut.Text = "";
    //            this.txtLastUpdate.Text = "";
    //            this.txtUserCreate.Text = "";
    //            this.txtUserUpdate.Text = "";

    //            return;
    //        }
    //        if (this.btnAdd.Text == "LƯU")
    //        {

    //            if (this.ddlItemType.SelectedIndex < 0)
    //            {
    //                MessageBox.Show("Bạn chưa chọn loại sản phẩm cho sản phẩm này");
    //                return;
    //            }
    //            if (this.ddlUnit.SelectedIndex < 0)
    //            {
    //                MessageBox.Show("Bạn chưa chọn đơn vị tính cho sản phẩm này");
    //                return;
    //            }

    //            if (!Validator.IsNull(this.txtItemName.Text))
    //            {
    //                MessageBox.Show("Tên sản phẩm không thể bỏ trống");
    //                return;
    //            }
    //            this.UpdateModel();
    //            this.model.EffectiveFromDate = DateTime.Now;
    //            this.model.DateCreate = DateTime.Now;
    //            this.txtItemId.Text = "";
    //            this.model.UserCreate = general.userName;
    //            var result = this.service.SaveOrUpdateItem(this.model);
    //            if (result != null)
    //            {

    //                MessageBox.Show("Thêm mới thành công", "Thông báo");

    //                general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
    //                this.LoadDataGrid();
    //            }
    //        }
    //        else
    //            MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");


    //    }

    //    private void btnDelete_Click(object sender, EventArgs e)
    //    {


    //        if (this.btnDelete.Text == "HỦY")
    //        {
    //            general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

    //        }
    //        else if (this.btnDelete.Text == "XÓA")
    //        {
    //            if (MessageBox.Show(general.delConfirmInfo, general.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
    //            {
    //                this.UpdateModel();
    //                if (this.model.ItemId > 0)
    //                {
    //                    var result = this.service.DeleteItem(this.model);
    //                    if (result)
    //                    {
    //                        general.ChangeButtonStatus("delete", this.btnAdd, this.btnUpdate, this.btnDelete);
    //                        MessageBox.Show("Xóa thành công", "Thông báo");
    //                        this.LoadDataGrid();
    //                        return;
    //                    }
    //                    MessageBox.Show("Xóa thất bại", "Thông báo");

    //                }
    //            }
    //        }
    //        else return;
    //    }

    //    private void btnUpdate_Click(object sender, EventArgs e)
    //    {

    //        if (this.btnUpdate.Text == "CẬP NHẬT")
    //        {
    //            general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

    //            return;

    //        }
    //        else
    //            if (this.btnUpdate.Text == "HỦY")
    //            {
    //                general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);


    //            }
    //            else if (this.btnUpdate.Text == "LƯU")
    //            {
                   
    //                if (this.txtItemId.Text == "")
    //                {
    //                    MessageBox.Show("Chọn loại sản phẩm cần cập nhật");
    //                    return;
    //                }
    //                if (!Validator.IsNull(this.txtItemName.Text))
    //                {
    //                    MessageBox.Show("Tên loại sản phẩm không thể bỏ trống");
    //                    return;
    //                }
    //                if (this.ddlItemType.SelectedIndex  < 0)
    //                {
    //                    MessageBox.Show("Bạn chưa chọn loại sản phẩm cho sản phẩm này");
    //                    return;
    //                }
    //                if (this.ddlUnit.SelectedIndex < 0)
    //                {
    //                    MessageBox.Show("Bạn chưa chọn đơn vị tính cho sản phẩm này");
    //                    return;
    //                }

    //                this.UpdateModel();
    //                var result = this.service.SaveOrUpdateItem(this.model);


    //                if (result != null)
    //                {
    //                    MessageBox.Show("Cập nhật thành công", "Thông báo");
    //                    this.LoadDataGrid();
    //                    general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

    //                }
    //            }
    //            else
    //                MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");
    //    }

    //    private void dtgItem_CellClick(object sender, DataGridViewCellEventArgs e)
    //    {
    //        try
    //        {
    //            this.model = (ItemModel)this.dtgItem.SelectedRows[0].DataBoundItem;

    //            this.ddlItemType.SelectedValue = this.model.ItemTypeId;
    //            this.ddlUnit.SelectedValue = this.model.UnitId;
    //            this.txtItemId.Text = this.model.ItemId.ToString();
    //            this.txtItemName.Text = this.model.ItemName;
    //            this.chkIsDrink.Checked = model.IsDrink;
    //            this.txtShortcut.Text = this.model.Shortcut;
    //            this.txtDateCreate.Text = this.model.DateCreate != null
    //                                     ? string.Format(
    //                                         "{0:dd-MM-yyyy}",
    //                                         this.model.LastUpdate)
    //                                     : "";

    //            this.txtLastUpdate.Text = this.model.LastUpdate != null ? string.Format(
    //                                         "{0:dd-MM-yyyy}",
    //                                        this.model.LastUpdate) :
    //            "";
    //            this.txtUserCreate.Text = this.model.UserCreate ?? "";
    //            this.txtUserUpdate.Text = this.model.UpdateBy ?? "";
    //        }
    //        catch (Exception)
    //        {
                
                
    //        }
         
               
            
          
    //    }
    }
}
