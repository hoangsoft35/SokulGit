// --------------------------------------------------------------------------------------------------------------------
// <copyright file="frmSplitTable.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the frmSplitTable type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeSoft.App.General;

namespace CoffeeSoft.App
{
    public partial class FrmJoinTable : DevExpress.XtraEditors.XtraForm
    {
        //private List<AreaModel> listAreaModel;

      

        //private List<ExportDetailModel> listExp;

        //private IServices service;
        //public FrmJoinTable()
        //{
        //    InitializeComponent();
        //    listAreaModel = new List<AreaModel>();
        //   service=new Services();
        //    listExp = new List<ExportDetailModel>();
      
        //}


        //private void frmSplitTable_Load(object sender, EventArgs e)
        //{
        //    listAreaModel = service.ListAllArea();
        //    glkAreaNew.Properties.DataSource = listAreaModel;
        //    glkAreaNew.Properties.DisplayMember = "AreaName";
        //    glkAreaNew.Properties.ValueMember = "AreaId";

        //    glkAreaOld.Properties.DataSource = listAreaModel;
        //    glkAreaOld.Properties.DisplayMember = "AreaName";
        //    glkAreaOld.Properties.ValueMember = "AreaId";



        //}

        //private void glkAreaOld_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        glkTableOld.Properties.DataSource = service.ListTableHaveGuestByAreaId(glkAreaOld.EditValue.ToString());
        //        glkTableOld.Properties.DisplayMember = "TableName";
        //        glkTableOld.Properties.ValueMember = "TableId";
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }

        //}

        //private void glkAreaNew_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        glkTableNew.Properties.DataSource =
        //            service.ListTableHaveGuestByAreaId(glkAreaNew.EditValue.ToString());
        //        glkTableNew.Properties.DisplayMember = "TableName";
        //        glkTableNew.Properties.ValueMember = "TableId";
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}

        //private void glkTableOld_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.listFlag.Clear();
        //        gridListItemNew.RefreshDataSource();

                
        //        listExp = service.GetDetailExportByTableId(int.Parse(glkTableOld.EditValue.ToString()));
        //        gridListItemOld.DataSource = listExp;
        //        gridListItemOld.RefreshDataSource();
        //        if (gridView3.RowCount > 0)
        //        {
        //            gridView3.FocusedRowHandle = gridView3.RowCount - 1;
        //            gridView3.Focus();

        //        }
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}

        //private List<ExportDetailModel> listFlag = new List<ExportDetailModel>();

        //private int quantityPart = 0;

        //private int quantityPart1 = 0;

        //private void gridView3_DoubleClick(object sender, EventArgs e)
        //{
           
        //}

        
        //private void gridListItemNew_DoubleClick(object sender, EventArgs e)
        //{
            
           
        //}

        //private void btnSlipt_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        if (int.Parse(glkTableNew.EditValue.ToString())== int.Parse(glkTableOld.EditValue.ToString()))
        //        {
        //            MessageBox.Show("Vui lòng chọn 2 bàn khác nhau mới có thể tiến hành ghép được", "Thông báo");
        //            return;
        //        }
        //        var expId = listExp[0].ExportId;

        //        foreach (var ExportDetailModel in listFlag)
        //        {
        //            service.AddItemToTable(expId, ExportDetailModel.ItemId, (int)(ExportDetailModel.Quantity));
        //            service.AddItemToTable(ExportDetailModel.ExportId, ExportDetailModel.ItemId, (int)-(ExportDetailModel.Quantity));
                
        //        }
                
        //        var table = int.Parse(glkTableOld.EditValue.ToString());
        //        general.tableIdJoin = int.Parse(glkTableNew.EditValue.ToString());
        //        if (table != null)
        //        {
        //            general.TableId = table;
        //        }
               
        //        MessageBox.Show("Ghép bàn thành công", "Thông báo");
        //        this.Close();
        //    }
        //    catch (Exception)
        //    {
                    
                
        //    }

        //}

        //private void glkTableNew_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {

               
        //        listFlag = service.GetDetailExportByTableId(int.Parse(glkTableNew.EditValue.ToString()));
        //        gridListItemNew.DataSource = listFlag;
        //        gridListItemNew.RefreshDataSource();

        //        if (gridView5.RowCount > 0)
        //        {
        //            gridView5.FocusedRowHandle = gridView5.RowCount - 1;
        //            gridView5.Focus();

        //        }
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}




    }
}