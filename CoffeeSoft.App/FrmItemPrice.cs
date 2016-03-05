namespace CoffeeSoft.App
{
    using System;
    using System.Windows.Forms;

    using CoffeeSoft.App.General;
   

    public partial class FrmItemPrice : Form
    {
        //private ItemModel model = new ItemModel();
        //private ItemPriceModel modelPrice = new ItemPriceModel();
        //private IServices service;
        //public FrmItemPrice()
        //{
        //    this.service=new Services();
        //    this.InitializeComponent();
        //}

        //private void FrmItemPrice_Load(object sender, EventArgs e)
        //{
        //    //this.CheckRole();
        //    this.LoadItem();
        //}
        //private void CheckRole()
        //{
        //    if (!this.service.R(general.groupUserId, "itemprice_add"))
        //    {
        //        this.btnAdd.Enabled = false;

        //    }
        //    if (!this.service.R(general.groupUserId, "itemprice_edit"))
        //    {
        //        this.btnUpdate.Enabled = false;

        //    }
        //    if (!this.service.R(general.groupUserId, "itemprice_delete"))
        //    {
        //        this.btnDelete.Enabled = false;

        //    }

        //}
        //private void LoadItem()
        //{
        //    this.gridItem.DataSource = this.service.ListItem();
        //}

        //private void gridItem_DoubleClick(object sender, EventArgs e)
        //{
           
        //    var row = (ItemModel)this.gridView1.GetRow(this.gridView1.GetSelectedRows()[0]);
        //    if (row !=null)
        //    {
        //        this.txtItemId.Text = row.ItemId.ToString();
        //        this.txtItemName.Text = row.ItemName;
        //        this.LoadItemPriceByItemId(row.ItemId);
        //    }
        //}

        //private void LoadItemPriceByItemId(int itemId)
        //{
        //    this.gridItemPrice.DataSource = this.service.ListItemPriceByItemId(itemId);
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (this.btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);


        //        this.dtpEffectiveFrom.Text = "";
        //        this.dtpEffectiveTo.Text = "";
        //        this.txtDateCreate.Text = "";
        //        this.txtPrice.Text = "";
        //        this.txtLastUpdate.Text = "";
        //        this.txtUserCreate.Text = "";
        //        this.txtUserUpdate.Text = "";
                

        //        return;
        //    }
        //    if (this.btnAdd.Text == "LƯU")
        //    {

        //        if (this.dtpEffectiveFrom.Text == "")
        //        {
        //            MessageBox.Show("Bạn chưa chọn ngày bắt đầu cho giá này");
        //            return;
        //        }
        //        if (this.txtItemId.Text =="")
        //        {
        //            MessageBox.Show("Bạn chưa chọn sản phẩm để nhập giá vui lòng double click để chọn sản phẩm");
        //            return;
        //        }
        //        if (this.dtpEffectiveFrom.Text=="")
        //        {
        //            MessageBox.Show("Chọn ngày bắt đầu cho giá của sản phẩm này");
        //            return;
        //        }

        //        if (this.txtPrice.Text == "")
        //        {
        //            MessageBox.Show("Bạn chưa nhập giá");
        //            return;
        //        }
              
             
        //        this.UpdateModel();

               
        //        this.modelPrice.UserCreate = general.userName;
        //        this.modelPrice.ItemPriceId = 0;

        //        if (!this.service.IsCheckOverLapItemPrice(this.modelPrice.ItemPriceId, this.modelPrice.EffectiveFromDate, this.modelPrice.EffectiveToDate, this.modelPrice.ItemId))
        //        {
        //            MessageBox.Show("Giá này đã trùng lập với giá khác vui lòng kiểm tra lại");
        //            return;
        //        }
        //        var result = this.service.SaveOrUpdateItemPrice(this.modelPrice);
        //        if (result != null)
        //        {

        //            MessageBox.Show("Thêm mới thành công", "Thông báo");

        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
        //            this.LoadItemPriceByItemId(int.Parse(this.txtItemId.Text!=""?this.txtItemId.Text:"0"));
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
        //            if (this.modelPrice.ItemPriceId > 0)
        //            {
        //                var result = this.service.DeleteItemPrice(this.modelPrice);
        //                if (result)
        //                {
        //                    general.ChangeButtonStatus("delete", this.btnAdd, this.btnUpdate, this.btnDelete);
        //                    MessageBox.Show("Xóa thành công", "Thông báo");
        //                    this.LoadItemPriceByItemId(int.Parse(this.txtItemId.Text != "" ? this.txtItemId.Text : "0"));
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

                    
                   
        //            if (this.dtpEffectiveFrom.Text == "")
        //            {
        //                MessageBox.Show("Bạn chưa chọn ngày bắt đầu cho giá này");
        //                return;
        //            }
        //            if (this.txtItemId.Text == "")
        //            {
        //                MessageBox.Show("Bạn chưa chọnsản phẩm");
        //                return;
        //            }

                  

        //            this.UpdateModel();
        //            if (!this.service.IsCheckOverLapItemPrice(this.modelPrice.ItemPriceId, this.modelPrice.EffectiveFromDate, this.modelPrice.EffectiveToDate,this.modelPrice.ItemId))
        //            {
        //                MessageBox.Show("Giá này đã trùng lập với giá khác vui lòng kiểm tra lại");
        //                return;
        //            }
        //            var result = this.service.SaveOrUpdateItemPrice(this.modelPrice);


        //            if (result != null)
        //            {
        //                MessageBox.Show("Cập nhật thành công", "Thông báo");
        //                this.LoadItemPriceByItemId(int.Parse(this.txtItemId.Text != "" ? this.txtItemId.Text : "0"));
        //                general.ChangeButtonStatus("update", this.btnAdd, this.btnUpdate, this.btnDelete);

        //            }
        //        }
        //        else
        //            MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");
        //}
        //private void UpdateModel()
        //{
        //    this.modelPrice.ItemId = int.Parse(this.txtItemId.Text != "" ? this.txtItemId.Text : "0");
           
        //    if (this.chkIsCurrentPrice.Checked)
        //    {
        //        this.modelPrice.IsCurrentPrice = true;
        //    }
        //    else
        //    {
        //        this.modelPrice.IsCurrentPrice = false;
        //    }
        //    this.modelPrice.Value = decimal.Parse(this.txtPrice.Text!="" ? this.txtPrice.Text:"0");

        //    this.modelPrice.EffectiveFromDate = DateTime.Parse(this.dtpEffectiveFrom.EditValue.ToString());
        //    if (this.dtpEffectiveTo.Text !="")
        //    {
        //        this.modelPrice.EffectiveToDate = DateTime.Parse(this.dtpEffectiveTo.EditValue.ToString());
        //    }
        //    else
        //    {
        //        this.modelPrice.EffectiveToDate = null;

        //    }
        //    this.modelPrice.DateCreate = DateTime.Now;
        //    this.modelPrice.UpdateBy = general.userName;
        //    this.modelPrice.LastUpdate = DateTime.Now;

        //}

        //private void gridItemPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        this.modelPrice = (ItemPriceModel)this.gridItemPrice.SelectedRows[0].DataBoundItem;
        //        if (this.modelPrice.IsCurrentPrice)
        //        {
        //            this.chkIsCurrentPrice.Checked = true;
        //        }
        //        else
        //        {
        //            this.chkIsCurrentPrice.Checked = false;

        //        }

        //        this.txtItemPriceId.Text = this.modelPrice.ItemPriceId.ToString();
        //        this.txtPrice.Text = this.modelPrice.Value.ToString();
        //        this.dtpEffectiveFrom.EditValue = this.modelPrice.EffectiveFromDate;
        //        if (this.modelPrice.EffectiveToDate !=null)
        //        {
        //            this.dtpEffectiveTo.EditValue = this.modelPrice.EffectiveToDate;
        //        }
        //        else
        //        {
        //            this.dtpEffectiveTo.EditValue = null;
        //        }
        //        if ((DateTime)this.dtpEffectiveTo.EditValue == null)
        //        {
        //            this.dtpEffectiveTo.Text = "";
        //        }
        //        this.txtDateCreate.Text = this.modelPrice.DateCreate != null
        //                            ? string.Format(
        //                                "{0:dd-MM-yyyy}",
        //                                this.modelPrice.DateCreate)
        //                            : "";

        //        this.txtLastUpdate.Text = this.model.LastUpdate != null ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                    this.model.LastUpdate) :
        //        "";
        //        this.txtUserCreate.Text = this.model.UserCreate ?? "";
        //        this.txtUserUpdate.Text = this.model.UpdateBy ?? "";
        //    }
        //    catch (Exception)
        //    {
                
                
        //    }
        
        //}
    }
}
