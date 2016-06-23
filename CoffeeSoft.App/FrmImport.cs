using System;
using System.Windows.Forms;

namespace CoffeeSoft.App
{
    public partial class FrmImport : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmImport
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FrmImport";
            this.Load += new System.EventHandler(this.FrmImport_Load);
            this.ResumeLayout(false);

        }

        private void FrmImport_Load(object sender, EventArgs e)
        {

        }
        // private IServices service;
        // private List<ImportDetailModel> listImportDetailModels;

        //public FrmImport()
        //{
        //  InitializeComponent();
        //  service = new Services();
        //  listImportDetailModels = new List<ImportDetailModel>();
        //    dtgDetailItems1.AutoGenerateColumns = false;
        //}

        //private void FrmImport_Load(object sender, EventArgs e)
        //{
        //  LoadMaterial();
        //}

        //private void LoadMaterial()
        //{

        //  var listMaterial = service.ListAllMaterial();
        //  ddlItem.Properties.DataSource = listMaterial.ToArray();
        //  ddlItem.Properties.DisplayMember = "MaterialName";
        //  ddlItem.Properties.ValueMember = "MaterialId";

        //}

        //private void rdbCurrent_CheckedChanged(object sender, EventArgs e)
        //{
        //  ShowHideDateTimePicker();
        //}

        //private void rdbPast_CheckedChanged(object sender, EventArgs e)
        //{
        //  ShowHideDateTimePicker();
        //}

        //private void ShowHideDateTimePicker()
        //{
        //  if (rdbCurrent.Checked)
        //  {
        //    lblDateCreate.Visible = false;
        //    dtpDateCreate.Visible = false;
        //    return;
        //  }

        //  lblDateCreate.Visible = true;
        //  dtpDateCreate.Visible = true;
        //}

        //private void btnCreateExport_Click(object sender, EventArgs e)
        //{
        //  if (btnCreateExport.Text == "Lập đơn hàng")
        //  {
        //      if (rdbPast.Checked)
        //      {
        //          if (dtpDateCreate.EditValue!=null&&dtpDateCreate.EditValue.ToString() == "" || DateTime.Parse(dtpDateCreate.EditValue.ToString()).Date >= DateTime.Now.Date)
        //          {
        //              MessageBox.Show("Ngày lập hóa đơn phải trong quá khứ");
        //              return;
        //          }
        //      }

        //      lblImportId.Text = service.GetImport();
        //      lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        //      lblEmployerName.Text = general.UserFullName;
        //      ddlItem.Enabled = true;
        //      txtQantity.Enabled = true;
        //      txtPrice.Enabled = true;
        //      btnCreateExport.Text = "Lưu";
        //      dtpDateCreate.Enabled = false;
        //      rdbPast.Enabled = false;


        //    return;
        //  }

        //  if (btnCreateExport.Text == "Lưu")
        //  {
        //    if (this.ValidateExport())
        //    {
        //      if (dtgDetailItems1.Rows.Count <= 0)
        //      {
        //        MessageBox.Show("Chưa có mặt hàng nào để bán");
        //        return;
        //      }
        //      if (this.ValidateExport())
        //      {

        //        this.SaveIxportAndIxportDetail();
        //        this.RefreshLabel();
        //        dtpDateCreate.Enabled = true;
        //        rdbPast.Enabled = true;

        //      }
        //    }

        //  }
        //}

        //private void SaveIxportAndIxportDetail()
        //{
        //  var importModel = new ImportModel();
        //  importModel.ImportId = this.lblImportId.Text;

        //  // date create
        //  if (this.rdbCurrent.Checked)
        //  {
        //    importModel.DateCreate = DateTime.Now;
        //  }
        //  else
        //  {
        //    importModel.DateCreate = DateTime.Parse(this.dtpDateCreate.EditValue.ToString());
        //  }

        //  importModel.UserCreate = general.userName;
        //  importModel.LastUpdate = DateTime.Now;
        //  importModel.UpdateBy = general.userName;
        //  importModel.UserName = general.userName;


        //  if (this.service.SaveImport(importModel))
        //  {
        //    if (this.service.SaveImportDetail(this.listImportDetailModels, importModel))
        //    {
        //      MessageBox.Show("Lưu thành công");
        //      this.listImportDetailModels = new List<ImportDetailModel>();
        //      this.ddlItem.Enabled = false;
        //      this.txtQantity.Enabled = false;
        //      txtPrice.Enabled = false;
        //      this.dtgDetailItems1.DataSource = this.listImportDetailModels;
        //      this.btnCreateExport.Text = "Lập đơn hàng";

        //      return;
        //    }
        //    else
        //    {
        //      MessageBox.Show("Có vấn đề xảy ra khi lưu dữ liệu. Xin vui lòng thử lại");
        //      return;
        //    }
        //  }
        //  MessageBox.Show("Có vấn đề xảy ra khi lưu dữ liệu. Xin vui lòng thử lại");
        //}

        //private bool ValidateExport()
        //{
        //  for (int i = 0; i < dtgDetailItems1.Rows.Count; i++)
        //  {
        //    var newQuantity = int.Parse(dtgDetailItems1.Rows[i].Cells["Quantity"].Value.ToString());

        //    if (newQuantity <= 0)
        //    {
        //      return false;
        //    }

        //  }


        //  if (rdbPast.Checked)
        //  {
        //    // export for past
        //    if (dtpDateCreate.EditValue == null || dtpDateCreate.Text == "")
        //    {
        //      MessageBox.Show("Chọn ngày lập hóa đơn");
        //      return false;
        //    }

        //    if (DateTime.Parse(dtpDateCreate.EditValue.ToString()).Date >= DateTime.Now.Date)
        //    {
        //      MessageBox.Show("Chỉ được chọn ngày trong quá khứ");
        //      return false;
        //    }

        //  }



        //  return true;

        //}

        //private void RefreshLabel()
        //{

        //  lblDate.Text = "";
        //  lblEmployerName.Text = "";
        //  lblImportId.Text = "";


        //}

        //private void dtgDetailItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //  try
        //  {
        //    var itemId = int.Parse(dtgDetailItems1.Rows[e.RowIndex].Cells["MaterialId1"].Value.ToString());
        //    var newQuantity = int.Parse(dtgDetailItems1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
        //    if (itemId > 0)
        //    {
        //      foreach (var item in listImportDetailModels)
        //      {
        //        if (item.MaterialId == itemId)
        //        {
        //          if (newQuantity == 0)
        //          {
        //            MessageBox.Show("Số lượng và Đơn giá phải lớn hơn 0");
        //            this.RefreshGridItemDetail();
        //            return;
        //          }
        //          var newTotal = item.Price * newQuantity;
        //          item.Total = newTotal;
        //          item.Quantity = newQuantity;
        //          dtgDetailItems1.Refresh();
        //          //CanculateTotal();
        //          return;
        //        }
        //      }
        //    }
        //  }
        //  catch (Exception)
        //  {


        //  }
        //}

        //private void ddlItem_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        //{
        //  txtQantity.Focus();
        //}

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //  if (MessageBox.Show(
        //            "Bạn có chắc là muốn làm lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        //            == DialogResult.Yes)
        //  {
        //    this.btnCreateExport.Text = "Lập đơn hàng";
        //    this.RefreshLabel();
        //    ddlItem.Enabled = false;
        //    txtQantity.Enabled = false;
        //    txtPrice.Enabled = false;
        //    dtpDateCreate.Enabled = true;
        //    rdbPast.Enabled = true;
        //    this.listImportDetailModels.Clear();
        //    this.dtgDetailItems1.DataSource = this.listImportDetailModels.ToArray();
        //  }
        //}


        //private void AddItemToGridDetail()
        //{
        //  if (rdbPast.Checked)
        //  {
        //    if (this.dtpDateCreate.Text == "" || dtpDateCreate.EditValue == null)
        //    {
        //      MessageBox.Show("Bạn phải chọn ngày lập hóa đơn");
        //      return;
        //    }
        //    if (DateTime.Parse(dtpDateCreate.EditValue.ToString()) >= DateTime.Now)
        //    {
        //      MessageBox.Show("Chỉ lập hóa đơn cho những ngày trong quá khứ");
        //      return;
        //    }
        //    if (this.ddlItem.Text == "")
        //    {
        //      MessageBox.Show("Bạn phải chọn mặt hàng để bán");
        //      this.ddlItem.ShowPopup();
        //      return;
        //    }
        //    if (this.txtQantity.Text == "" || int.Parse(this.txtQantity.Text) <= 0)
        //    {
        //      MessageBox.Show("Bạn phải nhập số lượng cần bán");
        //      this.txtQantity.Focus();
        //      this.txtQantity.SelectAll();
        //      return;
        //    }
        //    if (this.txtPrice.Text == "" || int.Parse(this.txtPrice.Text) <= 0)
        //    {
        //      MessageBox.Show("Bạn phải nhập đơn giá");
        //      this.txtPrice.Focus();
        //      this.txtPrice.SelectAll();
        //      return;
        //    }

        //    var material = (MaterialModel)
        //        this.ddlItem.Properties.View.GetRow(
        //            this.ddlItem.Properties.GetIndexByKeyValue(this.ddlItem.EditValue));
        //    // get price at date selected


        //    var importDetail = new ImportDetailModel();
        //    importDetail.ImportId = this.lblImportId.Text;
        //    importDetail.MaterialId = material.MaterialId;
        //    importDetail.Price = double.Parse(txtPrice.Text);
        //    importDetail.Quantity = int.Parse(this.txtQantity.Text);
        //    importDetail.MaterialName = material.MaterialName;
        //    importDetail.Total = importDetail.Quantity * importDetail.Price;
        //    // add to list

        //    // check exist in datagrid if exist only update 

        //    var isExists = this.listImportDetailModels.Any(x => x.MaterialId == importDetail.MaterialId);

        //    if (isExists)
        //    {
        //      MessageBox.Show("Sản phẩm này đã có");
        //      return;
        //    }

        //    this.listImportDetailModels.Add(importDetail);
        //    this.dtgDetailItems1.DataSource = this.listImportDetailModels.ToArray();
        //   // this.gridItems.DataSource = this.listImportDetailModels.ToArray();

        //    //CanculateTotal();
        //    ReCanculateSTT();
        //    ddlItem.ShowPopup();
        //  }




        //  if (rdbCurrent.Checked)
        //  {
        //    if (this.ddlItem.Text == "")
        //    {
        //      MessageBox.Show("Bạn phải chọn mặt hàng để bán");
        //      this.ddlItem.ShowPopup();
        //      return;
        //    }
        //    if (this.txtQantity.Text == "" || int.Parse(this.txtQantity.Text) <= 0)
        //    {
        //      MessageBox.Show("Bạn phải nhập số lượng cần bán");
        //      this.txtQantity.Focus();
        //      this.txtQantity.SelectAll();
        //      return;
        //    }



        //        var material =(MaterialModel)
        //        this.ddlItem.Properties.View.GetRow(
        //            this.ddlItem.Properties.GetIndexByKeyValue(this.ddlItem.EditValue));

        //    var importDetail = new ImportDetailModel();
        //    importDetail.ImportId = this.lblImportId.Text;
        //    importDetail.MaterialId = material.MaterialId;
        //    importDetail.UnitId = material.UnitId;
        //    importDetail.Quantity = int.Parse(this.txtQantity.Text);
        //    importDetail.MaterialName = material.MaterialName;
        //    importDetail.Price = double.Parse(txtPrice.Text);
        //    importDetail.Total = importDetail.Quantity * importDetail.Price;

        //    // add to list

        //    // check exist in datagrid if exist only update 

        //    var isExists = this.listImportDetailModels.Any(x => x.MaterialId == importDetail.MaterialId);

        //    if (isExists)
        //    {
        //      MessageBox.Show("Sản phẩm này đã có");

        //      return;
        //    }


        //      this.listImportDetailModels.Add(importDetail);

        //    this.RefreshGridItemDetail();
        //    CanculateTotal();
        //   // ReCanculateSTTForDevExpressGridControl();
        //    ddlItem.ShowPopup();
        //  }
        //}

        //private void RefreshGridItemDetail()
        //{
        //  this.dtgDetailItems1.DataSource = this.listImportDetailModels.ToArray();
        //  //gridite.DataSource = this.listImportDetailModels.ToArray();
        //  this.ReCanculateSTT();
        //}


        //private void ReCanculateSTT()
        //{
        //  for (int i = 0; i < dtgDetailItems1.Rows.Count; i++)
        //  {
        //    dtgDetailItems1.Rows[i].Cells["STT"].Value = i + 1;
        //  }

        //}

        //private void txtQantity_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //  {
        //    e.Handled = true;
        //  }

        //  if ((Keys)e.KeyChar == Keys.Enter)
        //  {
        //    txtPrice.Focus();
        //    txtPrice.SelectAll();
        //  }
        //}

        //private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //  {
        //    e.Handled = true;
        //  }

        //  if ((Keys)e.KeyChar == Keys.Enter)
        //  {
        //    this.AddItemToGridDetail();
        //  }
        //}


        //private void CanculateTotal()
        //{
        //    double total = 0;
        //    if (listImportDetailModels.Count > 0)
        //    {
        //        foreach (var item in listImportDetailModels)
        //        {
        //            total = total + item.Total;
        //        }
        //        //lblTotal.Text = string.Format("{0:N0}", total);
        //    }
        //}

        ////private void ReCanculateSTTForDevExpressGridControl()
        ////{
        ////    for (int i = 0; i < gridView2.RowCount; i++)
        ////    {
        ////        gridView2.SetRowCellValue(i, "Stt", i + 1);
        ////    }

        ////}
    }
}
