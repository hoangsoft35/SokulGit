namespace CoffeeSoft.App
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FrmPermit : Form
    {
        

        //private IServices service;

        //private List<DetailGroupUserRoleModel> listRole;

        //public FrmPermit()
        //{
            
        //    this.service = new Services();
        //    this.InitializeComponent();
          
        //}

        //private void FrmPermit_Load(object sender, EventArgs e)
        //{
        //    this.LoadGroupUserWithoutAdministrator();
        //}

        //private void LoadGroupUserWithoutAdministrator()
        //{
        //    this.glkGroupUser.Properties.DataSource = this.service.ListGroupUserWithoutAdministratorGroup();
        //    this.glkGroupUser.Properties.ValueMember = "GroupUserId";
        //    this.glkGroupUser.Properties.DisplayMember = "GroupUserName";
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.gridView1.DataRowCount > 0)
        //        {
        //            List<DetailGroupUserRoleModel> listModel= new List<DetailGroupUserRoleModel>();
        //            if (this.service.DeleteAllRoleByGroupUserId(int.Parse(this.glkGroupUser.EditValue.ToString())))
        //            {

        //                for (int i = 0; i < this.gridView1.DataRowCount; i++)
        //                {
        //                    var newRecord = new DetailGroupUserRoleModel();
                            
        //                    newRecord.GroupUserId =
        //                        int.Parse(this.gridView1.GetRowCellValue(i, "GroupUserId").ToString());
        //                    newRecord.RoleId = this.gridView1.GetRowCellValue(i, "RoleId").ToString();
        //                    newRecord.Permit = bool.Parse(
        //                        this.gridView1.GetRowCellValue(i, "Permit").ToString());
                         
        //                    listModel.Add(newRecord);

        //                }

        //                if (this.service.SaveListRoleForGroupUser(listModel))
        //                {
        //                      MessageBox.Show("Lưu thành công", "Thông báo");
        //                    return;
        //                }

        //                  MessageBox.Show("Xãy ra lỗi khi lưu", "Thông báo");
                      


        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Xãy ra lỗi khi lưu", "Thông báo");
        //    }
        //}

        //private void glkGroupUser_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
                
        //        LoadRoleByGroupUserId();
        //    }
        //    catch (Exception)
        //    {


        //    }
        //}

        //private void LoadRoleByGroupUserId()
        //{
        //    listRole = this.service.GetDetailRoleByGroupUserId(int.Parse(this.glkGroupUser.EditValue.ToString()));
        //    this.gridListRole.DataSource = listRole.ToArray();
               
        //}

        //private void btnReset_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
                
        //        var groupUserId= int.Parse(this.glkGroupUser.EditValue.ToString());

        //        if (groupUserId!=null && groupUserId > 0 )
        //        {
        //            if (service.DeleteAllRoleByGroupUserId(groupUserId))
        //            {
        //                service.UpdateAndResetRoleForGroupUser(groupUserId);
        //                MessageBox.Show("Làm mới dữ liệu thành công");
        //                LoadRoleByGroupUserId();
                        
        //                return;
        //            }
        //        }
            
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Làm mới dữ liệu thất bại");
        //        throw ex;
        //        return;

        //    }

            
        //}

        //private void chkAll_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkAll.Checked)
        //    {
        //        if (listRole!=null && listRole.Count>0)
        //        {
        //            foreach (var item in listRole)
        //            {
        //                item.Permit = true;
        //            }

        //            this.gridListRole.DataSource = listRole.ToArray();
        //            return;
        //        }
               
        //    }
        //    else
        //    {
        //        if (listRole != null && listRole.Count > 0)
        //        {
        //            foreach (var item in listRole)
        //            {
        //                item.Permit = false;
        //            }

        //            this.gridListRole.DataSource = listRole.ToArray();
        //        }

        //    }
          

        //}
    }
}
