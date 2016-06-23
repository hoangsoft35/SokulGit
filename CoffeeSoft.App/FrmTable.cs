using System.Windows.Forms;


namespace CoffeeSoft.App
{
    public partial class FrmTable : Form
    {
        //private IServices service;
        //public FrmTable()
        //{
        //    InitializeComponent();
        //    service=new Services();
        //}

        //private void FrmTable_Load(object sender, EventArgs e)
        //{
        //    LoadArea();
        //    LoadDataTable();
        //}

      
        //private List<TableModel> ListTable= null;
        //private List<AreaModel> ListArea = null;
        
        
        //private void LoadArea()
        //{

        //    gridLookUpEdit1.Properties.DataSource = service.ListAllArea();
        //    gridLookUpEdit1.Properties.DisplayMember = "AreaName";
        //    gridLookUpEdit1.Properties.ValueMember = "AreaId";
        //}
      
        //private void LoadDataTable()
        //{
        //    try
        //    {
                

             
            

        //        ListTable = service.ListAllTable();
        //        dtTable.DataSource = ListTable;
        //        if (gridView1.RowCount > 0)
        //        {

        //            var table = (TableModel)gridView1.GetFocusedRow();
        //            txtTableID.Text = table.TableId.ToString();
        //            txtTableName.Text = table.TableName;
        //            txtAreaID.Text = table.AreaId;
        //            gridLookUpEdit1.EditValue = table.AreaName;

        //        }
        //    }
        //    catch (Exception)
        //    {


        //    }

        //}

        //void Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    if (gridLookUpEdit1.Properties.Buttons[1] == e.Button)
        //    {
               
        //        if (Application.OpenForms["FrmArea"] == null)
        //        {
        //            FrmArea area = new FrmArea();
        //            area.ShowDialog();
        //            LoadArea();
        //            return;
        //        }
        //        Application.OpenForms["FrmArea"].ShowDialog();
        //        LoadArea();
        //    }
        //}

        

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
                
        //        if (btnAdd.Text == "THÊM MỚI")
        //        {
        //            general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);
        //            txtTableName.Text = "";
        //            txtTableName.Enabled = true;
        //            gridLookUpEdit1.Enabled = true;
        //            return;

        //        }
        //        else if (btnAdd.Text == "LƯU")
        //        {
        //            if (gridLookUpEdit1.EditValue.ToString() == "")
        //            {
        //                MessageBox.Show("Chọn vực cần thêm bàn");
        //                return;
        //            }
        //            if (!Validator.IsNull(txtTableName.Text))
        //            {
        //                MessageBox.Show("Tên bàn không thể bỏ trống");
        //                return;
        //            }



        //            TableModel ent = new TableModel();
        //            ent.TableName = txtTableName.Text.TrimStart().TrimEnd();
        //            ent.AreaId = gridLookUpEdit1.EditValue.ToString();
        //            ent.AreaName = gridLookUpEdit1.Text;
        //            ent.TableId = 0;

        //            ent.EffectiveFromDate = DateTime.Now;
        //            ent.DateCreate = DateTime.Now;
        //            ent.UserCreate = general.userName;

        //            if (service.SaveOrUpdateTable(ent)!=null)
        //            {
        //                MessageBox.Show("Thêm mới thành công", "Thông báo");
        //                txtTableName.Enabled = false;
        //                gridLookUpEdit1.Enabled = false;
        //                ListTable.Add(ent);
        //                dtTable.RefreshDataSource();
        //                general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);
        //            }

        //        }
        //        else
        //            MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ");
        //    }
        //    catch (Exception)
        //    {
                    
                
        //    }
           
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
               
        //        if (btnUpdate.Text == "CẬP NHẬT")
        //        {
        //            general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
        //            txtTableName.Enabled = true;
        //            gridLookUpEdit1.Enabled = true;
        //            return;

        //        }
        //        else if (btnUpdate.Text == "HỦY")
        //        {
        //            general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
        //            txtTableName.Enabled = false;
        //            gridLookUpEdit1.Enabled = false;
        //            return;

        //        }
        //        else if (btnUpdate.Text == "LƯU")
        //        {

        //            if (!Validator.IsNull(txtTableName.Text))
        //            {
        //                MessageBox.Show("Tên bàn không thể bỏ trống");
        //                return;
        //            }

        //            if (ListTable.Exists(p => p.TableName.Equals(txtTableName.Text.TrimStart().TrimEnd()) && p.AreaId.Equals(txtAreaID.Text)))
        //            {
        //                MessageBox.Show("Tên bàn [" + txtTableName.Text + "] đã tồn tại vui lòng nhập tên khác", "Thông báo");
        //                return;
        //            }

        //            TableModel ent = new TableModel();
        //            ent.TableName = txtTableName.Text;
        //            ent.AreaId = txtAreaID.Text;
        //            ent.AreaName = gridLookUpEdit1.Text;
        //            ent.TableId = int.Parse(txtTableID.Text);

        //            ent.EffectiveFromDate = DateTime.Now;
        //            ent.DateCreate = DateTime.Now;
        //            ent.UserCreate = general.userName;
        //            if (service.SaveOrUpdateTable(ent)!=null)
        //            {
        //                MessageBox.Show("Cập nhật thành công");
        //                txtTableName.Enabled = false;
        //                gridLookUpEdit1.Enabled = false;
        //                LoadDataTable();
        //                general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //            }
        //        }
        //        else
        //            MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ");
        //    }
        //    catch (Exception)
        //    {
                    
                
        //    }
           
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
                
        //        if (btnDelete.Text == "HỦY")
        //        {
        //            general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
        //            txtTableName.Enabled = false;
        //            gridLookUpEdit1.Enabled = false;
        //        }
        //        else if (btnDelete.Text == "XÓA")
        //        {
        //            if (MessageBox.Show(MessageShow.delConfirmInfo, MessageShow.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //            {
        //                TableModel ent = new TableModel();
        //                ent.TableId = int.Parse(txtTableID.Text);
        //                service.DeleteTable(ent);
        //                LoadDataTable();
        //                general.ChangeButtonStatus("delete", btnAdd, btnUpdate, btnDelete);
        //            }
        //        }
        //        else
        //            return;
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
            
        //}
       
       

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        if (e.RowHandle >= 0)
        //        {
        //            TableModel table = (TableModel)gridView1.GetFocusedRow();
        //            txtTableID.Text = table.TableId.ToString() ;
        //            txtTableName.Text = table.TableName;
        //            txtAreaID.Text = table.AreaId;
        //            gridLookUpEdit1.EditValue = table.AreaId;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}
    }
}
