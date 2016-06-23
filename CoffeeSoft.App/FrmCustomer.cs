using System.Windows.Forms;


namespace CoffeeSoft.App
{
    //using CoffeeSoft.Contract.Consts;

    public partial class FrmCustomer : Form
    {
        //private CustomerModel model = new CustomerModel();

        //private IServices service;
        //public FrmCustomer()
        //{
        //    service=new Services();
        //    InitializeComponent();
        //}

        //private void UpdateModel()
        //{
        //    model.CustomerId = int.Parse(txtCustomerId.Text != "" ? txtCustomerId.Text : "0");
        //    model.FirstName = txtFirstName.Text;
        //    model.LastName = txtLastName.Text;
        //    model.MiddleName = txtMiddleName.Text;
        //    model.FullName = txtLastName.Text + " " + txtMiddleName.Text + " " + txtFirstName.Text;
        //    model.Address = txtAdrress.Text;
        //    model.IdCard = txtIdCard.Text;
        //    model.Mobile = txtMobile.Text;
        //    model.Phone = txtMobile.Text;
        //    model.Dob = DateTime.Parse(dtpDob.EditValue.ToString());
        //    model.UpdateBy = general.userName;
        //    model.LastUpdate = DateTime.Now;
            

        //}


        //private void LoadDataGrid()
        //{
        //    this.gridCustomer.DataSource = this.service.ListCustomer();
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
            


        //    if (btnAdd.Text == "THÊM MỚI")
        //    {
        //        general.ChangeButtonStatus("insert", btnAdd, btnUpdate, btnDelete);

        //        txtCustomerId.Text = "";
        //        txtFirstName.Text = "";
        //        txtLastName.Text = "";
        //        txtMiddleName.Text = "";
        //        txtFirstName.Text = "";
        //        txtAdrress.Text = "";
        //        txtIdCard.Text = "";
        //        dtpDob.Text = "";
        //        txtMobile.Text = "";
        //        txtPhone.Text = "";




        //        return;
        //    }
        //    if (btnAdd.Text == "LƯU")
        //    {
               
        //        UpdateModel();
        //        model.EffectiveFromDate = DateTime.Now;
        //        model.DateCreate = DateTime.Now;
        //        model.CustomerId = 0;
        //        model.IsActiveCard = false;
        //        model.KulPoint = 0;
        //        model.TotalKulPoint = 0;
        //        model.TotalLost = 0;
        //        model.MemberCardNumber = "";
        //        model.MemberTypeId = Consts.MemberTypeStandard;
        //        model.UserCreate = general.userName;
        //        var result = this.service.SaveOrUpdateCustomer(this.model);
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
        //            if (model.CustomerId > 0)
        //            {
        //                var result = service.DeleteCustomer(model);
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
        //    if (dtpDob.EditValue == null || dtpDob.Text == "")
        //    {
        //        MessageBox.Show("Chọn ngày, tháng, năm sinh");
        //        return false;
        //    }

        //    if (!Validator.IsNull(txtFirstName.Text) || !Validator.IsNull(txtMiddleName.Text) || !Validator.IsNull(txtLastName.Text))
        //    {
        //        MessageBox.Show("Tên Khách hàng không thể bỏ trống");
        //        return false;
        //    }

           

        //    return true;
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

        //            if (model.CustomerId == 0)
        //            {
        //                MessageBox.Show("Chọn khách hàng cần cập nhật");
        //                return;
        //            }
          
        //            UpdateModel();
        //            var result = service.SaveOrUpdateCustomer(model);


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

        //private void FrmCustomer_Load(object sender, EventArgs e)
        //{
        //    CheckRole();
        //    this.LoadDataGrid();
        //}

       
        //private void CheckRole()
        //{
        //    if (!service.R(general.groupUserId, "customer_edit"))
        //    {
        //        btnUpdate.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "customer_delete"))
        //    {
        //        btnDelete.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, "customer_add"))
        //    {
        //        btnAdd.Enabled = false;

        //    }

        //    if (!service.R(general.groupUserId, Role.customer_active))
        //    {
        //        btnActive.Enabled = false;

        //    }
        //    if (!service.R(general.groupUserId, Role.customer_lost))
        //    {
        //        btnLost.Enabled = false;

        //    }

        //    if (!service.R(general.groupUserId, Role.customer_upgrade))
        //    {
        //        btnUpgrade.Enabled = false;

        //    }

        //    if (!service.R(general.groupUserId, Role.customer_activenewcardlost))
        //    {
        //        btnNewCardNumber.Enabled = false;

        //    }

        //    if (!service.R(general.groupUserId, Role.membercard_read))
        //    {
        //        btnMemberCard.Enabled = false;

        //    }

        //}

        //private void label16_Click(object sender, EventArgs e)
        //{

        //}

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        model = (CustomerModel)gridView1.GetFocusedRow();


        //        txtCustomerId.Text = model.CustomerId.ToString();
        //        txtFirstName.Text = model.FirstName;
        //        txtLastName.Text = model.LastName;

        //        txtMiddleName.Text = model.MiddleName;

        //        txtFirstName.Text = model.FirstName;
        //        txtAdrress.Text = model.Address;
        //        txtIdCard.Text = model.IdCard;
        //        dtpDob.EditValue = model.Dob;
        //        txtMobile.Text = model.Mobile;
        //        txtPhone.Text = model.Phone;
        //        txtMemberCardNumber.Text = model.MemberCardNumber;
        //        txtDateActive.Text =model.DateActiveCard !=null ?model.DateActiveCard.Value.ToString("dd/MM/yyyy"):"";
        //        lblMemberTypeName.Text = model.MemberTypeName;
        //        lblKulPoint.Text = model.KulPoint+"   kul";
        //        lblTotalKul.Text = model.TotalKulPoint + "   kul";
        //        lblTotalLost.Text = model.TotalLost + "   kul";
        //        chkIsLock.Checked = model.IsCustomerLock;

        //        if (model.IsActiveCard)
        //        {
        //            lblIsActive.Text = "Tài khoản đã kích hoạt";
        //        }
        //        else
        //        {
        //            lblIsActive.Text = "Tài khoản chưa kích hoạt";
        //        }

        //        if (model.IsCustomerLock)
        //        {
        //            btnNewCardNumber.Enabled = true;
        //        }
        //        else
        //        {
        //            btnNewCardNumber.Enabled = false;
        //        }



        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
        //}

        //private void btnActive_Click(object sender, EventArgs e)
        //{
        //    //if (service.R(general.groupUserId, Role.print_setting))
        //    //{
        //    if (!string.IsNullOrEmpty(txtMemberCardNumber.Text))
        //    {
        //        MessageBox.Show("Khách hàng này đã được kích hoạt, vui lòng kiểm tra lại hệ thống");
        //        return;
        //    }
        //    if (Application.OpenForms["FrmAcviteCustomer"] == null)
        //        {
        //            FrmAcviteCustomer area = new FrmAcviteCustomer();
        //            area.ShowDialog();
        //            if (general.MemberCardNumberActive != "" && model != null && model.CustomerId > 0)
        //            {
        //                model.MemberCardNumber = general.MemberCardNumberActive;
        //                model.IsActiveCard = true;
        //                model.IsCustomerLock = false;
        //                model.DateActiveCard = DateTime.Now;
        //                if (service.SaveOrUpdateCustomer(model).CustomerId > 0)
        //                {
        //                    MessageBox.Show("Kích hoạt tài khoản thành công");
        //                    service.UpdateStateOfVipCard(State.CardCurrentUse, model.MemberCardNumber);
        //                    if (model.IsActiveCard)
        //                    {
        //                        lblIsActive.Text = "Tài khoản đã kích hoạt";
        //                    }
        //                    else
        //                    {
        //                        lblIsActive.Text = "Tài khoản chưa kích hoạt";
        //                    }

        //                    txtDateActive.Text = model.DateActiveCard != null ? model.DateActiveCard.Value.ToString("dd/MM/yyyy") : "";
        //                    txtMemberCardNumber.Text = model.MemberCardNumber;
        //                    if (model.IsCustomerLock)
        //                    {
        //                        btnNewCardNumber.Enabled = true;
        //                    }
        //                    else
        //                    {
        //                        btnNewCardNumber.Enabled = false;
        //                    }
        //                    this.LoadDataGrid();
        //                    return;
        //                }
        //                MessageBox.Show("Kích hoạt tài khoản thất bại");
        //            }
        //            return;

        //        }
        //        Application.OpenForms["FrmAcviteCustomer"].ShowDialog();
        //        if (general.MemberCardNumberActive != "" && model != null && model.CustomerId > 0)
        //        {
        //            model.MemberCardNumber = general.MemberCardNumberActive;
        //            model.IsActiveCard = true;
        //            model.IsCustomerLock = false;
        //            model.DateActiveCard = DateTime.Now;
        //            if (service.SaveOrUpdateCustomer(model).CustomerId > 0)
        //            {
        //                MessageBox.Show("Kích hoạt tài khoản thành công");
        //                if (model.IsActiveCard)
        //                {
        //                    lblIsActive.Text = "Tài khoản đã kích hoạt";
        //                }
        //                else
        //                {
        //                    lblIsActive.Text = "Tài khoản chưa kích hoạt";
        //                }

        //                txtDateActive.Text = model.DateActiveCard != null ? model.DateActiveCard.Value.ToString("dd/MM/yyyy") : "";
        //                txtMemberCardNumber.Text = model.MemberCardNumber;
        //                if (model.IsCustomerLock)
        //                {
        //                    btnNewCardNumber.Enabled = true;
        //                }
        //                else
        //                {
        //                    btnNewCardNumber.Enabled = false;
        //                }
        //                this.LoadDataGrid();
        //                return;
        //            }
        //            MessageBox.Show("Kích hoạt tài khoản thất bại");
        //        }
                
        //    //}
        //    //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
        //}

        //private void btnLost_Click(object sender, EventArgs e)
        //{
        //    if (model.CustomerId <= 0)
        //    {
        //        MessageBox.Show("Chưa có khách hàng nào được chọn");
        //        return;
        //    }
        //    if (MessageBox.Show("Bạn có chắc là muốn báo mất thẻ. nếu báo mất thẻ thì tài khoản của bạn sẽ bị khóa cho tới khi tìm lại thẻ hoặc có thẻ mới bạn có đồng ý không","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
        //    {
            
        //        if (model.CustomerId > 0)
        //        {
        //            model.IsCustomerLock = true;
        //            service.SaveOrUpdateCustomer(model);

        //            service.UpdateStateOfVipCard(State.CardLost, model.MemberCardNumber);
        //            MessageBox.Show("Đã ghi nhận mất");
        //            if (model.IsCustomerLock)
        //            {
        //                btnNewCardNumber.Enabled = true;
        //            }
        //            else
        //            {
        //                btnNewCardNumber.Enabled = false;
        //            }
        //            chkIsLock.Checked = true;
        //            this.LoadDataGrid();
        //            return;
        //        }
        //        MessageBox.Show("Báo mất thất bại vui lòng thử lại");
        //    }
        //}

        //private void btnLock_Click(object sender, EventArgs e)
        //{
        //    if (model.CustomerId <= 0)
        //    {
        //        MessageBox.Show("Chưa có khách hàng nào được chọn");
        //        return;
        //    }
        //    if (MessageBox.Show("Bạn có chắc là muốn khóa tài khoản của khách hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {

        //        if (model.CustomerId > 0)
        //        {
        //            model.IsCustomerLock = true;
        //            service.SaveOrUpdateCustomer(model);

                  
        //            MessageBox.Show("Tài khoản đã bị khóa");
        //            chkIsLock.Checked = true;
        //            this.LoadDataGrid();
        //            return;
        //        }
        //        MessageBox.Show("Khóa tài khoản khách hàng này thất bại vui lòng thử lại sau");
        //    }
        //}

        //private void btnUnlock_Click(object sender, EventArgs e)
        //{
        //    if (model.CustomerId <= 0)
        //    {
        //        MessageBox.Show("Chưa có khách hàng nào được chọn");
        //        return;
        //    }
        //    if (MessageBox.Show(
        //        "Bạn có chắc là muốn mở khóa tài khoản của khách hàng này",
        //        "Thông báo",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question) == DialogResult.Yes)
        //    {

        //        if (model.CustomerId > 0)
        //        {
        //            model.IsCustomerLock = false;
        //            service.SaveOrUpdateCustomer(model);


        //            MessageBox.Show("Tài khoản đã đuợc mở khóa");
        //            chkIsLock.Checked = false;
        //            this.LoadDataGrid();
        //            return;
        //        }
        //        MessageBox.Show("Mở khóa tài khoản khách hàng này thất bại vui lòng thử lại sau");
        //    }
        //}

        //private void btnNewCardNumber_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show(
        //       "Bạn có chắc là muốn kích hoạt mã số mới cho tài khoản của khách hàng này",
        //       "Thông báo",
        //       MessageBoxButtons.YesNo,
        //       MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        if (Application.OpenForms["FrmAcviteCustomer"] == null)
        //        {
        //            FrmAcviteCustomer area = new FrmAcviteCustomer();
        //            area.ShowDialog();
        //            if (general.MemberCardNumberActive != "" && model != null && model.CustomerId > 0)
        //            {
        //                model.MemberCardNumber = general.MemberCardNumberActive;
        //                model.IsActiveCard = true;
        //                model.IsCustomerLock = false;
        //                model.DateActiveCard = DateTime.Now;
        //                if (service.SaveOrUpdateCustomer(model).CustomerId > 0)
        //                {
        //                    MessageBox.Show("Kích hoạt tài khoản thành công");
        //                    if (model.IsActiveCard)
        //                    {
        //                        lblIsActive.Text = "Tài khoản đã kích hoạt";
        //                    }
        //                    else
        //                    {
        //                        lblIsActive.Text = "Tài khoản chưa kích hoạt";
        //                    }

        //                    txtDateActive.Text = model.DateActiveCard != null
        //                                             ? model.DateActiveCard.Value.ToString("dd/MM/yyyy")
        //                                             : "";
        //                    txtMemberCardNumber.Text = model.MemberCardNumber;
        //                    if (model.IsCustomerLock)
        //                    {
        //                        btnNewCardNumber.Enabled = true;
        //                    }
        //                    else
        //                    {
        //                        btnNewCardNumber.Enabled = false;
        //                    }

        //                    this.LoadDataGrid();
        //                    return;
        //                }
        //                MessageBox.Show("Kích hoạt tài khoản thất bại");
        //            }
        //            return;

        //        }
        //        Application.OpenForms["FrmAcviteCustomer"].ShowDialog();
                
        //    }
        //}

        //private void btnMemberCard_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms["FrmMemberCard"] == null)
        //    {
        //        FrmMemberCard area = new FrmMemberCard();
        //        area.ShowDialog();
        //        return;

        //    }
        //    Application.OpenForms["FrmMemberCard"].ShowDialog();
            
        //}
    }
}
