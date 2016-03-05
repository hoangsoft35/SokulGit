using System;
using System.Windows.Forms;
using CoffeeSoft.App.General;


namespace CoffeeSoft.App
{
    public partial class FrmMemberCard : Form
    {


        //private MemberCardModel model = new MemberCardModel();
        //private IServices service;
        //public FrmMemberCard()
        //{
        //    service = new Services();
        //    InitializeComponent();
        //}


        //private void UpdateModel()
        //{
        //    model.MemberCardId = int.Parse(txtMemberCardId.Text != "" ? txtMemberCardId.Text : "0");
        //    model.MemberCardNumber = txtMemberCardNumber.Text.Trim();
        //    model.StateId = glkState.EditValue.ToString().Trim();
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;

        //}

        //private bool ValidateForm()
        //{
        //    if (string.IsNullOrEmpty(txtMemberCardNumber.Text))
        //    {
        //        MessageBox.Show("Mã số thành viên không được bỏ trống");
        //        return false;
        //    }
        //    if (glkState.EditValue==null||string.IsNullOrEmpty(glkState.EditValue.ToString()))
        //    {
        //        MessageBox.Show("Chọn trạng thái cho mã số thành viên này");
        //        return false;
        //    }

           

        //    return true;
        //}

        //private void LoadDataGrid()
        //{
        //    this.gridControl1.DataSource = this.service.ListMemberCard();
        //}
        //private void LoadDataDropdown()
        //{
        //    this.glkState.Properties.DataSource = this.service.ListState();
        //    this.glkState.Properties.DisplayMember = "StateDescription";
        //    this.glkState.Properties.ValueMember = "StateId";
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtMemberCardId.Text = "";
        //        txtMemberCardNumber.Text = "";
        //        txtDateCreate.Text = "";

        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";

        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {
        //        if (!ValidateForm())
        //        {
        //            return;
        //        }

        //        UpdateModel();
        //        model.EffectiveFromDate = DateTime.Now;
        //        model.DateCreate = DateTime.Now;
        //        model.MemberCardId = 0;
        //        model.UserCreate = general.userName;

        //        if (service.IsMemberCardNumberExists(txtMemberCardNumber.Text, model.MemberCardId))
        //        {
        //            MessageBox.Show("Mã số thành viên này đã có vui lòng kiểm tra lại");
        //            return;
        //        }
        //        var result = this.service.SaveOrUpdateMemberCard(this.model);
        //        if (result != null)
        //        {

        //            MessageBox.Show("Thêm mới thành công", "Thông báo");

        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
        //            this.LoadDataGrid();
        //        }
        //    }
        //    else
        //        MessageBox.Show("Thêm mới thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");


        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{


        //    if (btnDelete.Text == "HỦY")
        //    {
        //        general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //    }
        //    else if (btnDelete.Text == "XÓA")
        //    {
        //        if (MessageBox.Show(general.delConfirmInfo, general.delConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            this.UpdateModel();
        //            if (model.MemberCardId > 0)
        //            {
        //                var result = service.DeleteMemberCard(model);
        //                if (result)
        //                {
        //                    general.ChangeButtonStatus("delete", btnAdd, btnUpdate, btnDelete);
        //                    MessageBox.Show("Xóa thành công", "Thông báo");
        //                    this.LoadDataGrid();
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

        //    if (btnUpdate.Text == "CẬP NHẬT")
        //    {
        //        general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //        return;

        //    }
        //    else
        //        if (btnUpdate.Text == "HỦY")
        //        {
        //            general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);


        //        }
        //        else if (btnUpdate.Text == "LƯU")
        //        {
        //            if (!ValidateForm())
        //            {
        //                return;
        //            }
        //            UpdateModel();

        //            if (service.IsMemberCardNumberExists(txtMemberCardNumber.Text, model.MemberCardId))
        //            {
        //                MessageBox.Show("Mã số thành viên này đã có vui lòng kiểm tra lại");
        //                return;
        //            }
        //            var result = service.SaveOrUpdateMemberCard(model);


        //            if (result != null)
        //            {
        //                MessageBox.Show("Cập nhật thành công", "Thông báo");
        //                this.LoadDataGrid();
        //                general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

        //            }
        //        }
        //        else
        //            MessageBox.Show("Cập nhật thất bại vui lòng kiểm tra lại dữ liệu ", "Thông báo");
        //}

        //private void FrmMemberCard_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //    LoadDataDropdown();
        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, Role.membercard_add))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.membercard_edit))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.membercard_delete))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}
       

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        model = (MemberCardModel)gridView1.GetFocusedRow();


        //        txtMemberCardId.Text = model.MemberCardId.ToString();
        //        txtMemberCardNumber.Text = model.MemberCardNumber;
        //        glkState.EditValue = model.StateId;
        //        txtDateCreate.Text = model.DateCreate != null
        //                                 ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                     model.LastUpdate)
        //                                 : "";

        //        txtLastUpdate.Text = model.LastUpdate != null ? string.Format(
        //                                     "{0:dd-MM-yyyy}",
        //                                    model.LastUpdate) :
        //        "";
        //        txtUserCreate.Text = this.model.UserCreate ?? "";
        //        txtUserUpdate.Text = this.model.UpdateBy ?? "";
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}

      
    }
}
