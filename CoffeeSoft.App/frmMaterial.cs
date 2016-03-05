using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeSoft.App.General;


namespace CoffeeSoft.App
{
    public partial class frmMaterial : Form
  {
    

     //private IServices service;
     //public frmMaterial()
     //   {
     //       InitializeComponent();
     //       service=new Services();
     //   }

     //private void frmMaterial_Load(object sender, EventArgs e)
     //   {
     //       LoadArea();
     //       LoadDataTable();
     //   }

      
     //   private List<MaterialModel> ListMaterial= null;
     //   private List<UnitModel> ListUnit = null;
        
        
     //   private void LoadArea()
     //   {

     //       ddlGridUnit.Properties.DataSource = service.ListUnit();
     //       ddlGridUnit.Properties.DisplayMember = "UnitName";
     //       ddlGridUnit.Properties.ValueMember = "UnitId";
     //   }
      
     //   private void LoadDataTable()
     //   {
     //       try
     //       {
                

             
            

     //           ListMaterial = service.ListAllMaterial();
     //           dtgMaterial.DataSource = ListMaterial;
     //           if (gridView1.RowCount > 0)
     //           {

     //               var table = (MaterialModel)gridView1.GetFocusedRow();
     //               txtMaterialId.Text = table.MaterialId.ToString();
     //               txtMaterialName.Text = table.MaterialName;
     //               txtMaterialId.Text = table.UnitId.ToString();
     //               ddlGridUnit.EditValue = table.UnitName;

     //           }
     //       }
     //       catch (Exception)
     //       {


     //       }

     //   }

     //   void Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
     //   {
     //       if (ddlGridUnit.Properties.Buttons[1] == e.Button)
     //       {
               
     //           if (Application.OpenForms["FrmUnit"] == null)
     //           {
     //             FrmUnit area = new FrmUnit();
     //               area.ShowDialog();
     //               LoadArea();
     //               return;
     //           }
     //           Application.OpenForms["FrmUnit"].ShowDialog();
     //           LoadArea();
     //       }
     //   }

        

     //   private void btnAdd_Click(object sender, EventArgs e)
     //   {
     //       try
     //       {
                
     //           if (btnAdd.Text == "THÊM MỚI")
     //           {
     //               general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);
     //               txtMaterialName.Text = "";
     //               txtMaterialName.Enabled = true;
     //               ddlGridUnit.Enabled = true;
     //               return;

     //           }
     //           else if (btnAdd.Text == "LƯU")
     //           {
     //               if (ddlGridUnit.EditValue.ToString() == "")
     //               {
     //                   MessageBox.Show("Chọn đơn vị cần thêm nguyên liệu");
     //                   return;
     //               }
     //               if (!Validator.IsNull(txtMaterialName.Text))
     //               {
     //                   MessageBox.Show("Tên nguyên liệu không thể bỏ trống");
     //                   return;
     //               }



     //               var ent = new MaterialModel();
     //               ent.MaterialName= txtMaterialName.Text.TrimStart().TrimEnd();
     //               ent.UnitId = int.Parse(ddlGridUnit.EditValue.ToString());
     //               ent.UnitName = ddlGridUnit.Text;
     //               ent.MaterialId = 0;

     //               ent.EffectiveFromDate = DateTime.Now;
     //               ent.DateCreate = DateTime.Now;
     //               ent.UserCreate = general.userName;
     //             var entSaved = service.SaveOrUpdateMaterial(ent);
     //             if (entSaved != null)
     //               {
     //                   MessageBox.Show("Thêm mới thành công", "Thông báo");
     //                   txtMaterialName.Enabled = false;
     //                   ddlGridUnit.Enabled = false;
     //                   ListMaterial.Add(entSaved);
                      
                      
     //                   dtgMaterial.RefreshDataSource();
     //                   general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);
     //               }

     //           }
     //           else
     //               MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ");
     //       }
     //       catch (Exception)
     //       {
                    
                
     //       }
           
     //   }

     //   private void btnUpdate_Click(object sender, EventArgs e)
     //   {
     //       try
     //       {
               
     //           if (btnUpdate.Text == "CẬP NHẬT")
     //           {
     //               general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
     //               txtMaterialName.Enabled = true;
     //               ddlGridUnit.Enabled = true;
     //               return;

     //           }
     //           else if (btnUpdate.Text == "HỦY")
     //           {
     //               general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
     //               txtMaterialName.Enabled = false;
     //               ddlGridUnit.Enabled = false;
     //               return;

     //           }
     //           else if (btnUpdate.Text == "LƯU")
     //           {

     //               if (!Validator.IsNull(txtMaterialName.Text))
     //               {
     //                   MessageBox.Show("Tên nguyên liệu không thể bỏ trống");
     //                   return;
     //               }

     //               if (ListMaterial.Exists(p => p.MaterialName.Equals(txtMaterialName.Text.TrimStart().TrimEnd()) && p.MaterialId.Equals(txtMaterialId.Text)))
     //               {
     //                   MessageBox.Show("Tên nguyên liệu [" + txtMaterialName.Text + "] đã tồn tại vui lòng nhập tên khác", "Thông báo");
     //                   return;
     //               }

     //               MaterialModel ent = new MaterialModel();
     //               ent.MaterialName = txtMaterialName.Text;
     //               ent.UnitId = int.Parse(ddlGridUnit.EditValue.ToString());
     //               ent.UnitName = ddlGridUnit.Text;
     //               ent.MaterialId = int.Parse(txtMaterialId.Text);

     //               ent.EffectiveFromDate = DateTime.Now;
     //               ent.DateCreate = DateTime.Now;
     //               ent.UserCreate = general.userName;
     //             ent.UpdateBy = general.userName;
     //             ent.LastUpdate = DateTime.Now;
     //               if (service.SaveOrUpdateMaterial(ent)!=null)
     //               {
     //                   MessageBox.Show("Cập nhật thành công");
     //                   txtMaterialName.Enabled = false;
     //                   ddlGridUnit.Enabled = false;
     //                   LoadDataTable();
     //                   general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

     //               }
     //           }
     //           else
     //               MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ");
     //       }
     //       catch (Exception)
     //       {
                    
                
     //       }
           
     //   }

     //   private void btnDelete_Click(object sender, EventArgs e)
     //   {
     //       try
     //       {
                
     //           if (btnDelete.Text == "HỦY")
     //           {
     //               general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);
     //               txtMaterialName.Enabled = false;
     //               ddlGridUnit.Enabled = false;
     //           }
     //           else if (btnDelete.Text == "XÓA")
     //           {
     //               if (MessageBox.Show(MessageShow.delConfirmInfo, MessageShow.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
     //               {
     //                   MaterialModel ent = new MaterialModel();
     //                   ent.MaterialId = int.Parse(txtMaterialId.Text);
     //                   service.DeleteMaterial(ent);
     //                   LoadDataTable();
     //                   general.ChangeButtonStatus("delete", btnAdd, btnUpdate, btnDelete);
     //               }
     //           }
     //           else
     //               return;
     //       }
     //       catch (Exception)
     //       {

     //           return;
     //       }
            
     //   }
       
       

     //   private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
     //   {
     //       try
     //       {
     //           if (e.RowHandle >= 0)
     //           {
     //               MaterialModel table = (MaterialModel)gridView1.GetFocusedRow();
     //               txtMaterialId.Text = table.MaterialId.ToString() ;
     //               txtMaterialName.Text = table.MaterialName;
     //               ddlGridUnit.EditValue = table.UnitId;
     //               txtDateCreate.Text = table.DateCreate != null
     //                                      ? string.Format(
     //                                          "{0:dd-MM-yyyy}",
     //                                          table.LastUpdate)
     //                                      : "";

     //               txtLastUpdate.Text = table.LastUpdate != null ? string.Format(
     //                                            "{0:dd-MM-yyyy}",
     //                                           table.LastUpdate) :
     //               "";
     //               txtUserCreate.Text = table.UserCreate ?? "";
     //               txtUserUpdate.Text = table.UpdateBy ?? "";
     //           }
     //       }
     //       catch (Exception)
     //       {

     //           return;
     //       }
     //   }

      
  }
}
