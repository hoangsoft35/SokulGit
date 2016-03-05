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
using CoffeeSoft.App.Service;
using DevExpress.Utils;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace CoffeeSoft.App
{
    public partial class frmSplitTable : DevExpress.XtraEditors.XtraForm
    {


        private List<AreaTranslationModel> listAreaModel;



        private List<ExportDetailModel> listExp;

        private IServiceInstance service;
        public frmSplitTable(IServiceInstance serviceInstance)
        {
            InitializeComponent();
            listAreaModel = new List<AreaTranslationModel>();
            listExp = new List<ExportDetailModel>();
            service = serviceInstance;
        }


        private void frmSplitTable_Load(object sender, EventArgs e)
        {
            listAreaModel = service.AreaService.GetAllAreaByCompany(Consts.LangCultures.DefaultWinformAppLanguage ,general.CompanyId);
            glkAreaNew.Properties.DataSource = listAreaModel;
            glkAreaNew.Properties.DisplayMember = "AreaName";
            glkAreaNew.Properties.ValueMember = "AreaId";

            glkAreaOld.Properties.DataSource = listAreaModel;
            glkAreaOld.Properties.DisplayMember = "AreaName";
            glkAreaOld.Properties.ValueMember = "AreaId";



        }

        private void glkAreaOld_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                glkTableOld.Properties.DataSource = service.TableService.ListTableHaveGuestByAreaId(Convert.ToInt32(glkAreaOld.EditValue.ToString()), Consts.LangCultures.DefaultWinformAppLanguage);
                glkTableOld.Properties.DisplayMember = "TableName";
                glkTableOld.Properties.ValueMember = "Id";
            }
            catch (Exception)
            {

                return;
            }

        }

        private void glkAreaNew_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                glkTableNew.Properties.DataSource =
                    service.TableService.ListTableNotHaveGuestByAreaId(Convert.ToInt32(glkAreaNew.EditValue.ToString()), Consts.LangCultures.DefaultWinformAppLanguage);
                glkTableNew.Properties.DisplayMember = "TableName";
                glkTableNew.Properties.ValueMember = "Id";
            }
            catch (Exception)
            {

                return;
            }}

        private void glkTableOld_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.listFlag.Clear();
                gridListItemNew.RefreshDataSource();

                listExp = service.ExportService.GetDetailExportByTableId(int.Parse(glkTableOld.EditValue.ToString()));
                gridListItemOld.DataSource = listExp;
                gridListItemOld.RefreshDataSource();
                if (gridView3.RowCount > 0)
                {
                    gridView3.FocusedRowHandle = gridView3.RowCount - 1;
                    gridView3.Focus();

                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private List<ExportDetailModel> listFlag = new List<ExportDetailModel>();

        private int QuantityPart = 0;

        private int QuantityPart1 = 0;

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Left
                && (e as DXMouseEventArgs).Clicks == 2)
            {
                if (gridView3.RowCount == 1)
                {
                    if (int.Parse(gridView3.GetFocusedRowCellValue("Quantity").ToString()) > 1)
                    {
                        var itemFindNewList =
                            this.listFlag.Find(
                                f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));

                        if (itemFindNewList == null)
                        {
                            var resultOld =
                                this.listExp.Find(
                                    f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));

                            var newRecord = new ExportDetailModel();
                            newRecord.AreaName = resultOld.AreaName;
                            newRecord.Created = resultOld.Created;
                            newRecord.DatePaid = resultOld.DatePaid;
                            //newRecord.e = resultOld.EmployerId;
                            //newRecord.EmployerName = resultOld.EmployerName;
                            newRecord.ExportId = resultOld.ExportId;
                            newRecord.IsItemPay = resultOld.IsItemPay;
                            newRecord.ItemDiscount = resultOld.ItemDiscount;
                            newRecord.ItemId = resultOld.ItemId;
                            newRecord.ItemName = resultOld.ItemName;

                            newRecord.Price = resultOld.Price;
                            newRecord.Quantity = 1;
                            newRecord.Service = resultOld.Service;
                            newRecord.TableId = resultOld.TableId;
                            newRecord.TableName = resultOld.TableName;
                            newRecord.Total = resultOld.Total;
                            newRecord.Vat = resultOld.Vat;
                            newRecord.ItemPriceId = resultOld.ItemPriceId;
                            listFlag.Add(newRecord);
                            gridListItemNew.DataSource = listFlag;
                            gridListItemNew.RefreshDataSource();
                            if (resultOld.Quantity == 1)
                            {
                                gridView3.DeleteRow(gridView3.GetFocusedDataSourceRowIndex());
                                return;
                            }
                            resultOld.Quantity--;
                            gridListItemOld.RefreshDataSource();
                            return;
                        }
                        var resultOld1 =
                            this.listExp.Find(
                                f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));
                        itemFindNewList.Quantity++;
                        gridListItemNew.DataSource = listFlag;
                        gridListItemNew.RefreshDataSource();
                        if (resultOld1.Quantity == 1)
                        {
                            gridView3.DeleteRow(gridView3.GetFocusedDataSourceRowIndex());
                            return;
                        }
                        resultOld1.Quantity--;
                        gridListItemOld.RefreshDataSource();
                        return;

                    }
                    else
                    {
                        MessageBox.Show("Không thể chuyển hết món ăn qua bàn mới vui lòng kiểm tra lại", "Thông báo");
                        return;
                    }
                }


                if (gridView3.RowCount >= 1)
                {

                    var itemFindNewList =
                        this.listFlag.Find(
                            f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));

                    if (itemFindNewList == null)
                    {
                        var resultOld =
                            this.listExp.Find(
                                f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));

                        var newRecord = new ExportDetailModel();
                        newRecord.AreaName = resultOld.AreaName;
                        newRecord.Created = resultOld.Created;
                        newRecord.DatePaid = resultOld.DatePaid;
                        //newRecord.EmployerId = resultOld.EmployerId;
                        //newRecord.EmployerName = resultOld.EmployerName;
                        newRecord.ExportId = resultOld.ExportId;
                        newRecord.IsItemPay = resultOld.IsItemPay;
                        newRecord.ItemDiscount = resultOld.ItemDiscount;
                        newRecord.ItemId = resultOld.ItemId;
                        newRecord.ItemName = resultOld.ItemName;
                        newRecord.IsItemPay = resultOld.IsItemPay;
                        newRecord.Price = resultOld.Price;
                        newRecord.Quantity = 1;
                        newRecord.Service = resultOld.Service;
                        newRecord.TableId = resultOld.TableId;
                        newRecord.TableName = resultOld.TableName;
                        newRecord.Total = resultOld.Total;
                        newRecord.Vat = resultOld.Vat;
                        newRecord.ItemPriceId = resultOld.ItemPriceId;
                        listFlag.Add(newRecord);
                        gridListItemNew.DataSource = listFlag;
                        gridListItemNew.RefreshDataSource();
                        if (resultOld.Quantity == 1)
                        {
                            gridView3.DeleteRow(gridView3.GetFocusedDataSourceRowIndex());
                            return;
                        }
                        resultOld.Quantity--;
                        gridListItemOld.RefreshDataSource();
                        return;
                    }
                    var resultOld1 =
                        this.listExp.Find(
                            f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));
                    itemFindNewList.Quantity++;
                    gridListItemNew.DataSource = listFlag;
                    gridListItemNew.RefreshDataSource();
                    if (resultOld1.Quantity == 1)
                    {
                        gridView3.DeleteRow(gridView3.GetFocusedDataSourceRowIndex());
                        return;
                    }
                    resultOld1.Quantity--;
                    gridListItemOld.RefreshDataSource();
                    return;
                }
            }

            if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Right
                && (e as DXMouseEventArgs).Clicks == 2)
            {

                var itemFindNewList =
                    this.listFlag.Find(
                        f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));

                if (itemFindNewList == null)
                {

                    return;
                }
                var resultOld1 =
                    this.listExp.Find(f => f.ItemId == int.Parse(gridView3.GetFocusedRowCellValue("ItemId").ToString()));
                if (resultOld1 != null)
                {

                    if (itemFindNewList.Quantity == 1)
                    {
                        gridView5.DeleteRow(gridView5.GetFocusedDataSourceRowIndex());
                        gridListItemNew.RefreshDataSource();
                        resultOld1.Quantity++;


                        return;
                    }
                    itemFindNewList.Quantity--;
                    gridListItemNew.DataSource = listFlag;
                    gridListItemNew.RefreshDataSource();
                    resultOld1.Quantity++;
                    gridListItemOld.RefreshDataSource();
                    return;
                }
                var newRecord = new ExportDetailModel();
                newRecord.AreaName = itemFindNewList.AreaName;
                newRecord.Created = itemFindNewList.Created;
                newRecord.DatePaid = itemFindNewList.DatePaid;
                //newRecord.EmployerId = itemFindNewList.EmployerId;
                //newRecord.EmployerName = itemFindNewList.EmployerName;
                newRecord.ExportId = itemFindNewList.ExportId;
                newRecord.IsItemPay = itemFindNewList.IsItemPay;
                newRecord.ItemDiscount = itemFindNewList.ItemDiscount;
                newRecord.ItemId = itemFindNewList.ItemId;
                newRecord.ItemName = itemFindNewList.ItemName;
                newRecord.IsItemPay = itemFindNewList.IsItemPay;
                newRecord.Price = itemFindNewList.Price;
                newRecord.Quantity = 1;
                newRecord.Service = itemFindNewList.Service;
                newRecord.TableId = itemFindNewList.TableId;
                newRecord.TableName = itemFindNewList.TableName;
                newRecord.Total = itemFindNewList.Total;
                newRecord.Vat = itemFindNewList.Vat;
                newRecord.ItemPriceId = itemFindNewList.ItemPriceId;
                listExp.Add(newRecord);
                gridListItemOld.RefreshDataSource();
                return;
            }

        }


        private void gridListItemNew_DoubleClick(object sender, EventArgs e)
        {

            if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Right
             && (e as DXMouseEventArgs).Clicks == 2)
            {

                var itemFindNewList =
                    this.listFlag.Find(
                        f => f.ItemId == int.Parse(gridView5.GetFocusedRowCellValue("ItemId").ToString()));

                if (itemFindNewList == null)
                {

                    return;
                }
                var resultOld1 =
                    this.listExp.Find(f => f.ItemId == int.Parse(gridView5.GetFocusedRowCellValue("ItemId").ToString()));
                if (resultOld1 != null)
                {

                    if (itemFindNewList.Quantity == 1)
                    {
                        gridView5.DeleteRow(gridView5.GetFocusedDataSourceRowIndex());
                        gridListItemNew.RefreshDataSource();
                        resultOld1.Quantity++;

                        gridListItemOld.RefreshDataSource();
                        return;
                    }
                    itemFindNewList.Quantity--;
                    gridListItemNew.DataSource = listFlag;
                    gridListItemNew.RefreshDataSource();
                    resultOld1.Quantity++;
                    gridListItemOld.RefreshDataSource();
                    return;
                }
                var newRecord = new ExportDetailModel();newRecord.AreaName = itemFindNewList.AreaName;
                newRecord.Created = itemFindNewList.Created;
                newRecord.DatePaid = itemFindNewList.DatePaid;
                //newRecord.EmployerId = itemFindNewList.EmployerId;
                //newRecord.EmployerName = itemFindNewList.EmployerName;
                newRecord.ExportId = itemFindNewList.ExportId;
                newRecord.IsItemPay = itemFindNewList.IsItemPay;
                newRecord.ItemDiscount = itemFindNewList.ItemDiscount;
                newRecord.ItemId = itemFindNewList.ItemId;
                newRecord.ItemName = itemFindNewList.ItemName;
                newRecord.IsItemPay = itemFindNewList.IsItemPay;
                newRecord.Price = itemFindNewList.Price;
                newRecord.Quantity = 1;
                newRecord.Service = itemFindNewList.Service;
                newRecord.TableId = itemFindNewList.TableId;
                newRecord.TableName = itemFindNewList.TableName;
                newRecord.Total = itemFindNewList.Total;
                newRecord.Vat = itemFindNewList.Vat;
                newRecord.ItemPriceId = itemFindNewList.ItemPriceId;
                listExp.Add(newRecord);
                gridListItemOld.RefreshDataSource();



                if (itemFindNewList.Quantity == 1)
                {
                    gridView5.DeleteRow(gridView5.GetFocusedDataSourceRowIndex());
                    gridListItemNew.RefreshDataSource();

                    gridListItemOld.RefreshDataSource();
                    return;
                }
                itemFindNewList.Quantity--;
                gridListItemNew.RefreshDataSource();
                return;
            }
        }

        private void btnSlipt_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridView5.DataRowCount <= 0)
                {
                    MessageBox.Show("Bàn mới chưa có món nào");
                    return;}
                foreach (var exportDetail in listFlag)
                {
                    service.ExportService.InitUpdateExport(exportDetail.ExportId, Convert.ToInt32(glkTableOld.EditValue.ToString()), general.UserKey,
                       exportDetail.ItemId, (int)(-(exportDetail.Quantity)), general.CompanyId,
                       exportDetail.ItemPriceId, (decimal)exportDetail.Price);

                   // service.AddItemToTable(ExportDetailModel.ExportId, ExportDetailModel.ItemId, (int)(-(ExportDetailModel.Quantity)));
                }
                //var expId = service.ExportService.ge(int.Parse(glkTableNew.EditValue.ToString()), general.userName);
                var table = int.Parse(glkTableNew.EditValue.ToString());
                if (table != null)
                {
                    general.tableIdJoinOrSplit = table;
                }
                var expId = service.ExportService.NewInvoiceNumber("HDX");
                foreach (var item in listFlag)
                {
                    //service.AddItemToTable(expId, item.ItemId, (int)(item.Quantity));
                    service.ExportService.InitUpdateExport(expId, general.tableIdJoinOrSplit, general.UserKey,
                       item.ItemId, (int)(item.Quantity), general.CompanyId,item.ItemPriceId, (decimal)item.Price);
                }MessageBox.Show("Tách thành công", "Thông báo");
                general.SuccessFlag = true;
                this.Close();
               }
            catch (Exception ex)
            {
                throw ex;}
        }

        private void frmSplitTable_FormClosing(object sender, FormClosingEventArgs e)
        {
           // general.SuccessFlag = false;
        }




    }
}