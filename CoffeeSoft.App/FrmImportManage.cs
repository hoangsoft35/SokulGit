using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeSoft.App.General;

namespace CoffeeSoft.App
{
    public partial class FrmImportManage : Form
    {
        //public FrmImportManage()
        //{
        //    service=new Services();
        //    InitializeComponent();
        //}

       
        // private IServices service;

        //private List<ImportDetailModel> listImportDetailModels;


        //private void FrmImportManage_Load(object sender, EventArgs e)
        //{
        //    this.RefreshLabel();
        //    gridListHd.DataSource = service.ListAllImport().ToArray();
        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "exporthistory_editquantity"))
        //    {
        //        btnEdit.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "exporthistory_printagain"))
        //    {
        //        btn.Enabled = false;

        //    }


        //}

      
        //private void RefreshLabel()
        //{
        //    lblDate.Text = "";
        //    lblEmployerName.Text = "";
        //    lblImportId.Text = "";
    
        //}

        //private ImportModel modelImport;
        //private void gridView1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        modelImport = (ImportModel)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
        //        if (modelImport != null)
        //        {
        //            lblDate.Text = modelImport.DateCreate.ToString("dd/MM/yyyy");
        //            lblEmployerName.Text = modelImport.FullName;
        //            lblImportId.Text = modelImport.ImportId;
        //            LoadDataItemByImportId(modelImport.ImportId);
        //        }
        //    }
        //    catch (Exception)
        //    {
                
                
        //    }
         
        //}

        //private void LoadDataItemByImportId(string importId)
        //{
        //    gridItems.DataSource=service.ListItemByImportId(importId).ToArray();
        //    ReCanculateSTT();
        //}

        //private void ReCanculateSTT()
        //{
        //    for (int i = 0; i < gridView2.RowCount; i++)
        //    {
        //        gridView2.SetRowCellValue(i,"Stt",i + 1);
        //    }

        //}

        //private ImportDetailModel modelDetail;
        //private void gridView2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        modelDetail = (ImportDetailModel)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
        //        if (modelDetail != null)
        //        {
        //            txtQantityOgrinal.Text = modelDetail.Quantity.ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {
                
                
        //    }
            
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (txtQantityOgrinal.Text == "" || int.Parse(txtQantityOgrinal.Text) <= 0)
        //    {
        //        MessageBox.Show("Chọn sản phẩm cần chỉnh sữa");
        //        return;
        //    }

        //    if (btnEdit.Text == "Chỉnh sữa hóa đơn")
        //    {
        //        txtQuantityChange.Enabled = true;
        //        gridItems.Enabled = false;
        //        gridListHd.Enabled = false;
        //        btnEdit.Text = "Lưu";
        //        return;
        //    }
        //    if (btnEdit.Text == "Lưu")
        //    {
        //        if (txtQuantityChange.Text.Trim()=="" || int.Parse(txtQuantityChange.Text)<=0)
        //        {
        //            MessageBox.Show("Số lượng muốn thay đổi phải lớn hơn 0");
        //            return;
        //        }

              

        //        var newQuantity = int.Parse(txtQuantityChange.Text);
                
        //            if (service.UpdateQuantityInImported(modelDetail.ImportId,modelDetail.MaterialId,newQuantity))
        //            {
        //                txtQuantityChange.Enabled = false;
        //                gridItems.Enabled = true;
        //                gridListHd.Enabled = true;
        //                btnEdit.Text = "Chỉnh sữa hóa đơn";
        //                MessageBox.Show("Đã sữa hóa đơn thành công");
        //                LoadDataItemByImportId(modelImport.ImportId);
        //                return;
        //            }
        //            MessageBox.Show("Lỗi thiết bị không thể sữa hóa đơn này");
        //            return;
        //        }
        //        MessageBox.Show("Số lượng hàng trong kho không đủ");
                
              
            
            

        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    txtQuantityChange.Enabled = false;
        //    gridItems.Enabled = true;
        //    gridListHd.Enabled = true;
        //    btnEdit.Text = "Chỉnh sữa hóa đơn";
        //}

        //private void btn_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có thực sự muốn xóa dòng dữ liệu này khỏi phiếu xuất", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        service.DeleteImportDetailById(modelDetail.ImportId, modelDetail.MaterialId);
        //        gridItems.DataSource = service.ListItemByImportId(modelDetail.ImportId).ToArray();
        //        ReCanculateSTT();
        //    }
        //}

    }
    
}
