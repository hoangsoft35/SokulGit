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
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace CoffeeSoft.App
{
    public partial class FrmJoinTable : DevExpress.XtraEditors.XtraForm
    {
       
        private List<AreaTranslationModel> listAreaModel;
        private List<ExportDetailModel> listExp;

        private IServiceInstance service;
        public FrmJoinTable(IServiceInstance serviceInstance)
        {
            InitializeComponent();
            listAreaModel = new List<AreaTranslationModel>();
            service = serviceInstance;
            listExp = new List<ExportDetailModel>();

        }
        
        private void frmJoinTable_Load(object sender, EventArgs e)
        {
            listAreaModel = service.AreaService.GetAllAreaByCompany(Consts.LangCultures.DefaultWinformAppLanguage, General.general.CompanyId);
            glkAreaNew.Properties.DataSource = listAreaModel;
            glkAreaNew.Properties.DisplayMember = "AreaName";
            glkAreaNew.Properties.ValueMember = "Id";

            glkAreaOld.Properties.DataSource = listAreaModel;
            glkAreaOld.Properties.DisplayMember = "AreaName";
            glkAreaOld.Properties.ValueMember = "Id";



        }

        private void glkAreaOld_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                glkTableOld.Properties.DataSource = service.TableService.ListTableHaveGuestByAreaId(int.Parse(glkAreaOld.EditValue.ToString()), Consts.LangCultures.DefaultWinformAppLanguage);
                glkTableOld.Properties.DisplayMember = "TableName";
                glkTableOld.Properties.ValueMember = "Id";}
            catch (Exception ex)
            {
                return;
            }

        }

        private void glkAreaNew_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                glkTableNew.Properties.DataSource =
                    service.TableService.ListTableHaveGuestByAreaId(int.Parse(glkAreaNew.EditValue.ToString()), Consts.LangCultures.DefaultWinformAppLanguage);
                glkTableNew.Properties.DisplayMember = "TableName";
                glkTableNew.Properties.ValueMember = "Id";
            }
            catch (Exception)
            {

                return;
            }
        }

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
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        private List<ExportDetailModel> listFlag = new List<ExportDetailModel>();

        private int quantityPart = 0;

        private int quantityPart1 = 0;

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {

        }


        private void gridListItemNew_DoubleClick(object sender, EventArgs e)
        {


        }

        private void btnSlipt_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(glkTableNew.EditValue.ToString()) == int.Parse(glkTableOld.EditValue.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn 2 bàn khác nhau mới có thể tiến hành ghép được", "Thông báo");
                    return;
                }
                var expId = listExp[0].ExportId;

                foreach (var ExportDetailModel in listFlag)
                {
                    service.ExportService.InitUpdateExport(expId, general.TableId, general.UserKey,
                        ExportDetailModel.ItemId, (int) (ExportDetailModel.Quantity), general.CompanyId,
                        ExportDetailModel.ItemPriceId, (decimal) ExportDetailModel.Price);

                    service.ExportService.InitUpdateExport(ExportDetailModel.ExportId, general.TableId, general.UserKey,
                        ExportDetailModel.ItemId, (int) -(ExportDetailModel.Quantity), general.CompanyId,
                        ExportDetailModel.ItemPriceId, (decimal) ExportDetailModel.Price);
                }

                var table = int.Parse(glkTableOld.EditValue.ToString());
                general.tableIdJoinOrSplit = int.Parse(glkTableNew.EditValue.ToString());
                if (table != null)
                {
                    general.TableId = table;
                }

                MessageBox.Show("Ghép bàn thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        private void glkTableNew_EditValueChanged(object sender, EventArgs e)
        {
            try
            {


                listFlag = service.ExportService.GetDetailExportByTableId(int.Parse(glkTableNew.EditValue.ToString()));
                gridListItemNew.DataSource = listFlag;
                gridListItemNew.RefreshDataSource();

                if (gridView5.RowCount > 0)
                {
                    gridView5.FocusedRowHandle = gridView5.RowCount - 1;
                    gridView5.Focus();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}