using System.Windows.Forms;


namespace CoffeeSoft.App
{
    public partial class FrmMemberType : Form
    {


        //private MemberTypeModel model = new MemberTypeModel();
        //private IServices service;
        //public FrmMemberType()
        //{
        //    service = new Services();
        //    InitializeComponent();
        //}


        //private void UpdateModel()
        //{
        //    model.MemberTypeId = txtMemberTypeId.Text;
        //    model.MemberTypeName = txtMemberTypeName.Text;
        //    model.MemberTypeDescription = txtMemberTypeDes.Text;
        //    model.KulCoinToUpgrade = int.Parse(txtKulUpgrade.Text.Trim() != "" ? txtKulUpgrade.Text : "0");
        //    model.DiscountForThisType = int.Parse(txtDisCount.Text.Trim() != "" ? txtDisCount.Text : "0");
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;
            

        //}


        //private void LoadDataGrid()
        //{
        //    this.dtgDepartment.DataSource = this.service.ListMemberType();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{





        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtMemberTypeId.Text = "";
        //        txtDisCount.Text = "";
        //        txtMemberTypeName.Text = "";
        //        txtMemberTypeDes.Text = "";
        //        txtKulUpgrade.Text = "";
        //        txtDateCreate.Text = "";

        //        txtLastUpdate.Text = "";
        //        txtUserCreate.Text = "";
        //        txtUserUpdate.Text = "";

        //        txtMemberTypeId.Enabled = true;
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
              
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateMemberType(this.model,false);
        //        if (result != null)
        //        {

        //            MessageBox.Show("Thêm mới thành công", "Thông báo");

        //            general.ChangeButtonStatus("insert", this.btnAdd, this.btnUpdate, this.btnDelete);
        //            txtMemberTypeId.Enabled = false;
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
        //            if (model.MemberTypeId!="")
        //            {
        //                var result = service.DeleteMemberType(model);
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

        //private bool ValidateForm()
        //{
        //    if (string.IsNullOrEmpty(txtMemberTypeId.Text))
        //    {
        //        MessageBox.Show("Nhập mã loại thành viên");
        //            return false;
        //    }
        //    if (string.IsNullOrEmpty(txtMemberTypeName.Text))
        //    {
        //        MessageBox.Show("Nhập tên loại thành viên");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtMemberTypeDes.Text))
        //    {
        //        MessageBox.Show("Nhập mô tả cho loại thành viên");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtKulUpgrade.Text)||int.Parse(txtKulUpgrade.Text)<=0)
        //    {
        //        MessageBox.Show("Số lượng Kul dùng để nâng cấp thành viên phải lớn hơn 0");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtDisCount.Text) || int.Parse(txtDisCount.Text) < 0 || int.Parse(txtDisCount.Text) > 100)
        //    {
        //        MessageBox.Show("Chiết khấu giảm giá chỉ giới hạn từ 0 - 100");
        //        return false;
        //    }
        //    return true;
        //}
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{

        //    if (btnUpdate.Text == "CẬP NHẬT")
        //    {
        //        general.ChangeButtonStatus("update", btnAdd, btnUpdate, btnDelete);

         

        //    }
        //    else
        //        if (btnUpdate.Text == "HỦY")
        //        {
        //            general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);
        //            txtMemberTypeId.Enabled = false;

        //        }
        //        else if (btnUpdate.Text == "LƯU")
        //        {
        //            if (!ValidateForm())
        //            {
        //                return;
        //            }
              

        //            UpdateModel();
        //            var result = service.SaveOrUpdateMemberType(model,true);


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

        //private void FrmMemberType_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //}
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, Role.membertype_add))
        //    {
        //        btnAdd.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.membertype_edit))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.membertype_delete))
        //    {
        //        btnDelete.Enabled = false;

        //    }

        //}
        //private void dtgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    try
        //    {
        //        model = (MemberTypeModel)dtgDepartment.SelectedRows[0].DataBoundItem;


        //        txtMemberTypeId.Text = model.MemberTypeId;
        //        txtDisCount.Text = model.DiscountForThisType.ToString();
        //        txtMemberTypeName.Text = model.MemberTypeName;
        //        txtMemberTypeDes.Text =  model.MemberTypeDescription;
        //        txtKulUpgrade.Text = model.KulCoinToUpgrade.ToString();

        //        txtDateCreate.Text = "";
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
