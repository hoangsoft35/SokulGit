namespace CoffeeSoft.App
{
    partial class FrmItemPrice
    {
        ///// <summary>
        ///// Required designer variable.
        ///// </summary>
        //private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (this.components != null))
        //    {
        //        this.components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemPrice));
        //    this.gridItem = new DevExpress.XtraGrid.GridControl();
        //    this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        //    this.ItemId = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.Shortcut = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.panel1 = new System.Windows.Forms.Panel();
        //    this.btnDelete = new System.Windows.Forms.Button();
        //    this.btnUpdate = new System.Windows.Forms.Button();
        //    this.btnAdd = new System.Windows.Forms.Button();
        //    this.gridItemPrice = new System.Windows.Forms.DataGridView();
        //    this.ItemPriceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.ItemName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.IsCurrentPrice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        //    this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.EffectiveFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.EffectiveToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.UserCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.UpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.ItemId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.groupBox1 = new System.Windows.Forms.GroupBox();
        //    this.groupBox2 = new System.Windows.Forms.GroupBox();
        //    this.dtpEffectiveTo = new DevExpress.XtraEditors.DateEdit();
        //    this.dtpEffectiveFrom = new DevExpress.XtraEditors.DateEdit();
        //    this.chkIsCurrentPrice = new System.Windows.Forms.CheckBox();
        //    this.label9 = new System.Windows.Forms.Label();
        //    this.txtDateCreate = new System.Windows.Forms.TextBox();
        //    this.txtUserUpdate = new System.Windows.Forms.TextBox();
        //    this.txtUserCreate = new System.Windows.Forms.TextBox();
        //    this.txtLastUpdate = new System.Windows.Forms.TextBox();
        //    this.label8 = new System.Windows.Forms.Label();
        //    this.label5 = new System.Windows.Forms.Label();
        //    this.label7 = new System.Windows.Forms.Label();
        //    this.label4 = new System.Windows.Forms.Label();
        //    this.label6 = new System.Windows.Forms.Label();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.txtPrice = new System.Windows.Forms.TextBox();
        //    this.txtItemPriceId = new System.Windows.Forms.TextBox();
        //    this.txtItemName = new System.Windows.Forms.TextBox();
        //    this.txtItemId = new System.Windows.Forms.TextBox();
        //    this.label3 = new System.Windows.Forms.Label();
        //    this.label2 = new System.Windows.Forms.Label();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridItemPrice)).BeginInit();
        //    this.groupBox1.SuspendLayout();
        //    this.groupBox2.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveTo.Properties.VistaTimeProperties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveTo.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveFrom.Properties.VistaTimeProperties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveFrom.Properties)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // gridItem
        //    // 
        //    this.gridItem.Dock = System.Windows.Forms.DockStyle.Left;
        //    this.gridItem.Location = new System.Drawing.Point(0, 0);
        //    this.gridItem.MainView = this.gridView1;
        //    this.gridItem.Name = "gridItem";
        //    this.gridItem.Size = new System.Drawing.Size(286, 559);
        //    this.gridItem.TabIndex = 0;
        //    this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
        //    this.gridView1});
        //    this.gridItem.DoubleClick += new System.EventHandler(this.gridItem_DoubleClick);
        //    // 
        //    // gridView1
        //    // 
        //    this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
        //    this.ItemId,
        //    this.ItemName,
        //    this.Shortcut});
        //    this.gridView1.GridControl = this.gridItem;
        //    this.gridView1.Name = "gridView1";
        //    this.gridView1.OptionsBehavior.Editable = false;
        //    this.gridView1.OptionsBehavior.ReadOnly = true;
        //    this.gridView1.OptionsView.ShowAutoFilterRow = true;
        //    this.gridView1.OptionsView.ShowGroupPanel = false;
        //    // 
        //    // ItemId
        //    // 
        //    this.ItemId.Caption = "Mã sản phẩm";
        //    this.ItemId.FieldName = "ItemId";
        //    this.ItemId.Name = "ItemId";
        //    this.ItemId.Width = 108;
        //    // 
        //    // ItemName
        //    // 
        //    this.ItemName.Caption = "Tên Sản Phẩm";
        //    this.ItemName.FieldName = "ItemName";
        //    this.ItemName.Name = "ItemName";
        //    this.ItemName.OptionsColumn.AllowEdit = false;
        //    this.ItemName.Visible = true;
        //    this.ItemName.VisibleIndex = 1;
        //    this.ItemName.Width = 160;
        //    // 
        //    // Shortcut
        //    // 
        //    this.Shortcut.Caption = "Tên viết tắt";
        //    this.Shortcut.FieldName = "Shortcut";
        //    this.Shortcut.Name = "Shortcut";
        //    this.Shortcut.Visible = true;
        //    this.Shortcut.VisibleIndex = 0;
        //    // 
        //    // panel1
        //    // 
        //    this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        //    this.panel1.Location = new System.Drawing.Point(286, 0);
        //    this.panel1.Name = "panel1";
        //    this.panel1.Size = new System.Drawing.Size(747, 37);
        //    this.panel1.TabIndex = 1;
        //    // 
        //    // btnDelete
        //    // 
        //    this.btnDelete.Location = new System.Drawing.Point(928, 114);
        //    this.btnDelete.Name = "btnDelete";
        //    this.btnDelete.Size = new System.Drawing.Size(75, 27);
        //    this.btnDelete.TabIndex = 10;
        //    this.btnDelete.Text = "XÓA";
        //    this.btnDelete.UseVisualStyleBackColor = true;
        //    this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        //    // 
        //    // btnUpdate
        //    // 
        //    this.btnUpdate.Location = new System.Drawing.Point(928, 81);
        //    this.btnUpdate.Name = "btnUpdate";
        //    this.btnUpdate.Size = new System.Drawing.Size(75, 27);
        //    this.btnUpdate.TabIndex = 11;
        //    this.btnUpdate.Text = "CẬP NHẬT";
        //    this.btnUpdate.UseVisualStyleBackColor = true;
        //    this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        //    // 
        //    // btnAdd
        //    // 
        //    this.btnAdd.Location = new System.Drawing.Point(928, 48);
        //    this.btnAdd.Name = "btnAdd";
        //    this.btnAdd.Size = new System.Drawing.Size(75, 27);
        //    this.btnAdd.TabIndex = 12;
        //    this.btnAdd.Text = "THÊM MỚI";
        //    this.btnAdd.UseVisualStyleBackColor = true;
        //    this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        //    // 
        //    // gridItemPrice
        //    // 
        //    this.gridItemPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    this.gridItemPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        //    this.ItemPriceId,
        //    this.ItemName1,
        //    this.IsCurrentPrice,
        //    this.Value,
        //    this.EffectiveFromDate,
        //    this.EffectiveToDate,
        //    this.DateCreate,
        //    this.UserCreate,
        //    this.LastUpdate,
        //    this.UpdateBy,
        //    this.ItemId1});
        //    this.gridItemPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
        //    this.gridItemPrice.Location = new System.Drawing.Point(286, 409);
        //    this.gridItemPrice.Name = "gridItemPrice";
        //    this.gridItemPrice.ReadOnly = true;
        //    this.gridItemPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        //    this.gridItemPrice.Size = new System.Drawing.Size(747, 150);
        //    this.gridItemPrice.TabIndex = 13;
        //    this.gridItemPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemPrice_CellClick);
        //    // 
        //    // ItemPriceId
        //    // 
        //    this.ItemPriceId.DataPropertyName = "ItemPriceId";
        //    this.ItemPriceId.HeaderText = "Mã giá sản phẩm";
        //    this.ItemPriceId.Name = "ItemPriceId";
        //    this.ItemPriceId.ReadOnly = true;
        //    // 
        //    // ItemName1
        //    // 
        //    this.ItemName1.DataPropertyName = "ItemName";
        //    this.ItemName1.HeaderText = "Tên sản phẩm";
        //    this.ItemName1.Name = "ItemName1";
        //    this.ItemName1.ReadOnly = true;
        //    // 
        //    // IsCurrentPrice
        //    // 
        //    this.IsCurrentPrice.DataPropertyName = "IsCurrentPrice";
        //    this.IsCurrentPrice.HeaderText = "Giá hiện tại";
        //    this.IsCurrentPrice.Name = "IsCurrentPrice";
        //    this.IsCurrentPrice.ReadOnly = true;
        //    this.IsCurrentPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        //    this.IsCurrentPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
        //    // 
        //    // Value
        //    // 
        //    this.Value.DataPropertyName = "Value";
        //    this.Value.HeaderText = "Giá";
        //    this.Value.Name = "Value";
        //    this.Value.ReadOnly = true;
        //    // 
        //    // EffectiveFromDate
        //    // 
        //    this.EffectiveFromDate.DataPropertyName = "EffectiveFromDate";
        //    this.EffectiveFromDate.HeaderText = "Ngày bắt đầu ";
        //    this.EffectiveFromDate.Name = "EffectiveFromDate";
        //    this.EffectiveFromDate.ReadOnly = true;
        //    // 
        //    // EffectiveToDate
        //    // 
        //    this.EffectiveToDate.DataPropertyName = "EffectiveToDate";
        //    this.EffectiveToDate.HeaderText = "Ngày kết thúc";
        //    this.EffectiveToDate.Name = "EffectiveToDate";
        //    this.EffectiveToDate.ReadOnly = true;
        //    // 
        //    // DateCreate
        //    // 
        //    this.DateCreate.DataPropertyName = "DateCreate";
        //    this.DateCreate.HeaderText = "Ngày tạo";
        //    this.DateCreate.Name = "DateCreate";
        //    this.DateCreate.ReadOnly = true;
        //    // 
        //    // UserCreate
        //    // 
        //    this.UserCreate.DataPropertyName = "UserCreate";
        //    this.UserCreate.HeaderText = "Người tạo";
        //    this.UserCreate.Name = "UserCreate";
        //    this.UserCreate.ReadOnly = true;
        //    // 
        //    // LastUpdate
        //    // 
        //    this.LastUpdate.DataPropertyName = "LastUpdate";
        //    this.LastUpdate.HeaderText = "Lần cập nhật cuối";
        //    this.LastUpdate.Name = "LastUpdate";
        //    this.LastUpdate.ReadOnly = true;
        //    // 
        //    // UpdateBy
        //    // 
        //    this.UpdateBy.DataPropertyName = "UpdateBy";
        //    this.UpdateBy.HeaderText = "Người cập nhật cuối";
        //    this.UpdateBy.Name = "UpdateBy";
        //    this.UpdateBy.ReadOnly = true;
        //    // 
        //    // ItemId1
        //    // 
        //    this.ItemId1.DataPropertyName = "ItemId";
        //    this.ItemId1.HeaderText = "ItemId1";
        //    this.ItemId1.Name = "ItemId1";
        //    this.ItemId1.ReadOnly = true;
        //    this.ItemId1.Visible = false;
        //    // 
        //    // groupBox1
        //    // 
        //    this.groupBox1.Controls.Add(this.groupBox2);
        //    this.groupBox1.Controls.Add(this.txtItemName);
        //    this.groupBox1.Controls.Add(this.txtItemId);
        //    this.groupBox1.Controls.Add(this.label3);
        //    this.groupBox1.Controls.Add(this.label2);
        //    this.groupBox1.Location = new System.Drawing.Point(292, 43);
        //    this.groupBox1.Name = "groupBox1";
        //    this.groupBox1.Size = new System.Drawing.Size(625, 344);
        //    this.groupBox1.TabIndex = 9;
        //    this.groupBox1.TabStop = false;
        //    this.groupBox1.Text = "Thông tin chi tiết";
        //    // 
        //    // groupBox2
        //    // 
        //    this.groupBox2.Controls.Add(this.dtpEffectiveTo);
        //    this.groupBox2.Controls.Add(this.dtpEffectiveFrom);
        //    this.groupBox2.Controls.Add(this.chkIsCurrentPrice);
        //    this.groupBox2.Controls.Add(this.label9);
        //    this.groupBox2.Controls.Add(this.txtDateCreate);
        //    this.groupBox2.Controls.Add(this.txtUserUpdate);
        //    this.groupBox2.Controls.Add(this.txtUserCreate);
        //    this.groupBox2.Controls.Add(this.txtLastUpdate);
        //    this.groupBox2.Controls.Add(this.label8);
        //    this.groupBox2.Controls.Add(this.label5);
        //    this.groupBox2.Controls.Add(this.label7);
        //    this.groupBox2.Controls.Add(this.label4);
        //    this.groupBox2.Controls.Add(this.label6);
        //    this.groupBox2.Controls.Add(this.label1);
        //    this.groupBox2.Controls.Add(this.txtPrice);
        //    this.groupBox2.Controls.Add(this.txtItemPriceId);
        //    this.groupBox2.Location = new System.Drawing.Point(6, 59);
        //    this.groupBox2.Name = "groupBox2";
        //    this.groupBox2.Size = new System.Drawing.Size(610, 250);
        //    this.groupBox2.TabIndex = 23;
        //    this.groupBox2.TabStop = false;
        //    this.groupBox2.Text = "Thông tin giá sản phẩm";
        //    // 
        //    // dtpEffectiveTo
        //    // 
        //    this.dtpEffectiveTo.EditValue = null;
        //    this.dtpEffectiveTo.Location = new System.Drawing.Point(426, 64);
        //    this.dtpEffectiveTo.Name = "dtpEffectiveTo";
        //    this.dtpEffectiveTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.dtpEffectiveTo.Properties.DisplayFormat.FormatString = "{0:dd-MM-yyyy}";
        //    this.dtpEffectiveTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
        //    this.dtpEffectiveTo.Properties.EditFormat.FormatString = "{0:dd-MM-yyyy}";
        //    this.dtpEffectiveTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
        //    this.dtpEffectiveTo.Properties.Mask.EditMask = "";
        //    this.dtpEffectiveTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton()});
        //    this.dtpEffectiveTo.Size = new System.Drawing.Size(165, 20);
        //    this.dtpEffectiveTo.TabIndex = 2;
        //    // 
        //    // dtpEffectiveFrom
        //    // 
        //    this.dtpEffectiveFrom.EditValue = null;
        //    this.dtpEffectiveFrom.Location = new System.Drawing.Point(127, 64);
        //    this.dtpEffectiveFrom.Name = "dtpEffectiveFrom";
        //    this.dtpEffectiveFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.dtpEffectiveFrom.Properties.DisplayFormat.FormatString = "{0:dd-MM-yyyy}";
        //    this.dtpEffectiveFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
        //    this.dtpEffectiveFrom.Properties.EditFormat.FormatString = "{0:dd-MM-yyyy}";
        //    this.dtpEffectiveFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
        //    this.dtpEffectiveFrom.Properties.Mask.EditMask = "";
        //    this.dtpEffectiveFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton()});
        //    this.dtpEffectiveFrom.Size = new System.Drawing.Size(166, 20);
        //    this.dtpEffectiveFrom.TabIndex = 1;
        //    // 
        //    // chkIsCurrentPrice
        //    // 
        //    this.chkIsCurrentPrice.AutoSize = true;
        //    this.chkIsCurrentPrice.Location = new System.Drawing.Point(127, 144);
        //    this.chkIsCurrentPrice.Name = "chkIsCurrentPrice";
        //    this.chkIsCurrentPrice.Size = new System.Drawing.Size(153, 17);
        //    this.chkIsCurrentPrice.TabIndex = 3;
        //    this.chkIsCurrentPrice.Text = "Chọn giá này là giá hiện tại";
        //    this.chkIsCurrentPrice.UseVisualStyleBackColor = true;
        //    // 
        //    // label9
        //    // 
        //    this.label9.AutoSize = true;
        //    this.label9.Location = new System.Drawing.Point(299, 67);
        //    this.label9.Name = "label9";
        //    this.label9.Size = new System.Drawing.Size(53, 13);
        //    this.label9.TabIndex = 36;
        //    this.label9.Text = "Đến ngày";
        //    // 
        //    // txtDateCreate
        //    // 
        //    this.txtDateCreate.Enabled = false;
        //    this.txtDateCreate.Location = new System.Drawing.Point(127, 92);
        //    this.txtDateCreate.Name = "txtDateCreate";
        //    this.txtDateCreate.Size = new System.Drawing.Size(166, 20);
        //    this.txtDateCreate.TabIndex = 34;
        //    // 
        //    // txtUserUpdate
        //    // 
        //    this.txtUserUpdate.Enabled = false;
        //    this.txtUserUpdate.Location = new System.Drawing.Point(425, 92);
        //    this.txtUserUpdate.Name = "txtUserUpdate";
        //    this.txtUserUpdate.Size = new System.Drawing.Size(165, 20);
        //    this.txtUserUpdate.TabIndex = 31;
        //    // 
        //    // txtUserCreate
        //    // 
        //    this.txtUserCreate.Enabled = false;
        //    this.txtUserCreate.Location = new System.Drawing.Point(425, 118);
        //    this.txtUserCreate.Name = "txtUserCreate";
        //    this.txtUserCreate.Size = new System.Drawing.Size(165, 20);
        //    this.txtUserCreate.TabIndex = 32;
        //    // 
        //    // txtLastUpdate
        //    // 
        //    this.txtLastUpdate.Enabled = false;
        //    this.txtLastUpdate.Location = new System.Drawing.Point(127, 118);
        //    this.txtLastUpdate.Name = "txtLastUpdate";
        //    this.txtLastUpdate.Size = new System.Drawing.Size(166, 20);
        //    this.txtLastUpdate.TabIndex = 33;
        //    // 
        //    // label8
        //    // 
        //    this.label8.AutoSize = true;
        //    this.label8.Location = new System.Drawing.Point(299, 120);
        //    this.label8.Name = "label8";
        //    this.label8.Size = new System.Drawing.Size(120, 13);
        //    this.label8.TabIndex = 29;
        //    this.label8.Text = "Người cập nhật lần cuối";
        //    // 
        //    // label5
        //    // 
        //    this.label5.AutoSize = true;
        //    this.label5.Location = new System.Drawing.Point(6, 67);
        //    this.label5.Name = "label5";
        //    this.label5.Size = new System.Drawing.Size(98, 13);
        //    this.label5.TabIndex = 30;
        //    this.label5.Text = "Có hiệu lực từ ngày";
        //    // 
        //    // label7
        //    // 
        //    this.label7.AutoSize = true;
        //    this.label7.Location = new System.Drawing.Point(299, 94);
        //    this.label7.Name = "label7";
        //    this.label7.Size = new System.Drawing.Size(90, 13);
        //    this.label7.TabIndex = 27;
        //    this.label7.Text = "Cập nhật lần cuối";
        //    // 
        //    // label4
        //    // 
        //    this.label4.AutoSize = true;
        //    this.label4.Location = new System.Drawing.Point(6, 41);
        //    this.label4.Name = "label4";
        //    this.label4.Size = new System.Drawing.Size(113, 13);
        //    this.label4.TabIndex = 28;
        //    this.label4.Text = "Giá cho sản phẩm này";
        //    // 
        //    // label6
        //    // 
        //    this.label6.AutoSize = true;
        //    this.label6.Location = new System.Drawing.Point(6, 118);
        //    this.label6.Name = "label6";
        //    this.label6.Size = new System.Drawing.Size(53, 13);
        //    this.label6.TabIndex = 26;
        //    this.label6.Text = "Người tạo";
        //    // 
        //    // label1
        //    // 
        //    this.label1.AutoSize = true;
        //    this.label1.Location = new System.Drawing.Point(6, 92);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(50, 13);
        //    this.label1.TabIndex = 25;
        //    this.label1.Text = "Ngày tạo";
        //    // 
        //    // txtPrice
        //    // 
        //    this.txtPrice.Location = new System.Drawing.Point(127, 38);
        //    this.txtPrice.Name = "txtPrice";
        //    this.txtPrice.Size = new System.Drawing.Size(166, 20);
        //    this.txtPrice.TabIndex = 0;
        //    // 
        //    // txtItemPriceId
        //    // 
        //    this.txtItemPriceId.Location = new System.Drawing.Point(127, 167);
        //    this.txtItemPriceId.Name = "txtItemPriceId";
        //    this.txtItemPriceId.Size = new System.Drawing.Size(156, 20);
        //    this.txtItemPriceId.TabIndex = 24;
        //    this.txtItemPriceId.Visible = false;
        //    // 
        //    // txtItemName
        //    // 
        //    this.txtItemName.Location = new System.Drawing.Point(432, 19);
        //    this.txtItemName.Name = "txtItemName";
        //    this.txtItemName.ReadOnly = true;
        //    this.txtItemName.Size = new System.Drawing.Size(165, 20);
        //    this.txtItemName.TabIndex = 22;
        //    // 
        //    // txtItemId
        //    // 
        //    this.txtItemId.Location = new System.Drawing.Point(121, 22);
        //    this.txtItemId.Name = "txtItemId";
        //    this.txtItemId.ReadOnly = true;
        //    this.txtItemId.Size = new System.Drawing.Size(166, 20);
        //    this.txtItemId.TabIndex = 0;
        //    // 
        //    // label3
        //    // 
        //    this.label3.AutoSize = true;
        //    this.label3.Location = new System.Drawing.Point(322, 25);
        //    this.label3.Name = "label3";
        //    this.label3.Size = new System.Drawing.Size(75, 13);
        //    this.label3.TabIndex = 2;
        //    this.label3.Text = "Tên sản phẩm";
        //    // 
        //    // label2
        //    // 
        //    this.label2.AutoSize = true;
        //    this.label2.Location = new System.Drawing.Point(15, 26);
        //    this.label2.Name = "label2";
        //    this.label2.Size = new System.Drawing.Size(71, 13);
        //    this.label2.TabIndex = 1;
        //    this.label2.Text = "Mã sản phẩm";
        //    // 
        //    // FrmItemPrice
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(1033, 559);
        //    this.Controls.Add(this.btnDelete);
        //    this.Controls.Add(this.btnUpdate);
        //    this.Controls.Add(this.btnAdd);
        //    this.Controls.Add(this.gridItemPrice);
        //    this.Controls.Add(this.groupBox1);
        //    this.Controls.Add(this.panel1);
        //    this.Controls.Add(this.gridItem);
        //    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        //    this.Name = "FrmItemPrice";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        //    this.Text = "Thiết lập giá cho sản phẩm";
        //    this.Load += new System.EventHandler(this.FrmItemPrice_Load);
        //    ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridItemPrice)).EndInit();
        //    this.groupBox1.ResumeLayout(false);
        //    this.groupBox1.PerformLayout();
        //    this.groupBox2.ResumeLayout(false);
        //    this.groupBox2.PerformLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveTo.Properties.VistaTimeProperties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveTo.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveFrom.Properties.VistaTimeProperties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dtpEffectiveFrom.Properties)).EndInit();
        //    this.ResumeLayout(false);

        //}

        //#endregion

        //private DevExpress.XtraGrid.GridControl gridItem;
        //private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //private DevExpress.XtraGrid.Columns.GridColumn ItemId;
        //private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Button btnDelete;
        //private System.Windows.Forms.Button btnUpdate;
        //private System.Windows.Forms.Button btnAdd;
        //private System.Windows.Forms.DataGridView gridItemPrice;
        //private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.GroupBox groupBox2;
        //private System.Windows.Forms.Label label9;
        //private System.Windows.Forms.TextBox txtDateCreate;
        //private System.Windows.Forms.TextBox txtUserUpdate;
        //private System.Windows.Forms.TextBox txtUserCreate;
        //private System.Windows.Forms.TextBox txtLastUpdate;
        //private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox txtPrice;
        //private System.Windows.Forms.TextBox txtItemName;
        //private System.Windows.Forms.TextBox txtItemId;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label2;
        //private DevExpress.XtraGrid.Columns.GridColumn Shortcut;
        //private System.Windows.Forms.CheckBox chkIsCurrentPrice;
        //private System.Windows.Forms.TextBox txtItemPriceId;
        //private DevExpress.XtraEditors.DateEdit dtpEffectiveTo;
        //private DevExpress.XtraEditors.DateEdit dtpEffectiveFrom;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceId;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ItemName1;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn IsCurrentPrice;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        //private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveFromDate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveToDate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn UserCreate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn UpdateBy;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ItemId1;

    }
}