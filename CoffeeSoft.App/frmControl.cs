using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoffeeSoft.App.General;
using CoffeeSoft.App.Service;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace CoffeeSoft.App
{
    public partial class frmControl : DevExpress.XtraEditors.XtraForm
    {
        private IServiceInstance service;
        private ExportModel expENT;
        public frmControl(IServiceInstance serviceInstance)
        {
            service = serviceInstance;
            InitializeComponent();
        }

        private Label label2;
        
        private int flat = 0;

        private int labelHeight = 0;

        private int labelWidth = 0;

        private int btnX = 5;

        private int btnY = 10;

        private SimpleButton button1;

        private ExportDetailModel item;

        private DataRow row;

        private void frmControl_Load(object sender, EventArgs e)
        {
            this.BuildTablePanel();
            var data = service.ItemService.ListItem(Consts.LangCultures.DefaultWinformAppLanguage);
            this.gridControl1.DataSource = data;
            glkItem.DataSource = data;
            ReloadSuggestListMemberForMemberCard();


        }

        public void BuildTablePanel()
        {
            btnX = 5;
            flat = 0;
            btnY = 10;
            this.panelTable.Controls.Clear();
            var area = service.AreaService.GetAllAreaByCompany(Consts.LangCultures.DefaultWinformAppLanguage, general.CompanyId);
            var table = service.TableService.GetAllTableByCompany(Consts.LangCultures.DefaultWinformAppLanguage, general.CompanyId);
            for (int i = 0; i < area.Count; i++)
            {
                if (table.Any(x => x.AreaId == area[i].AreaId))
                {
                    //add label 
                    if (this.btnY > 55)
                    {
                        this.btnY += 55;
                        this.btnX = 5;
                        this.flat = 0;
                    }
                    this.label2 = new Label();
                    this.label2.Location = new System.Drawing.Point(this.btnX, this.btnY);
                    this.label2.Name = area[i].AreaId.ToString();
                    this.label2.Size = new System.Drawing.Size(35, 13);
                    this.label2.TabIndex = 0;
                    this.label2.Text = area[i].AreaName;
                    this.label2.AutoSize = true;
                    this.label2.Font = new System.Drawing.Font(
                        "Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    this.btnY += this.label2.Height + 25;
                    this.panelTable.Controls.Add(this.label2);
                    for (int j = 0; j < table.Count; j++)
                    {
                        if (table[j].AreaId == area[i].AreaId)
                        {
                            if (this.flat == 0)
                            {

                                this.button1 = new SimpleButton();
                                if (service.ExportService.IsTableHaveGuest(table[j].TableId))
                                {
                                    this.button1.Appearance.ForeColor = Color.White;
                                    this.button1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;


                                }
                                else
                                {
                                    this.button1.Appearance.BackColor = System.Drawing.Color.Wheat;
                                }
                                this.button1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
                                this.button1.Appearance.Options.UseBackColor = true;

                                this.button1.Appearance.Font = new System.Drawing.Font(
                                    "Tahoma",
                                    18F,
                                    System.Drawing.FontStyle.Bold,
                                    System.Drawing.GraphicsUnit.Point,
                                    ((byte)(0)));
                                this.button1.Appearance.Options.UseFont = true;
                                this.button1.Location = new System.Drawing.Point(this.btnX, this.btnY);
                                this.button1.Name = table[j].TableId.ToString();
                                this.button1.Size = new System.Drawing.Size(75, 50);
                                this.button1.TabIndex = 1;
                                this.button1.Click += button1_Click;
                                this.button1.Text = table[j].Id.ToString();
                                this.panelTable.Controls.Add(this.button1);

                                this.flat = 1;
                                this.btnX += this.button1.Width + 5;

                            }

                            else if (this.flat == 1)
                            {
                                this.button1 = new SimpleButton();
                                if (service.ExportService.IsTableHaveGuest(table[j].TableId))
                                {
                                    this.button1.Appearance.ForeColor = Color.White;
                                    this.button1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;

                                }
                                else
                                {
                                    this.button1.Appearance.BackColor = System.Drawing.Color.Wheat;
                                }
                                this.button1.Appearance.Options.UseBackColor = true;
                                this.button1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;

                                this.button1.Appearance.Font = new System.Drawing.Font(
                                    "Tahoma",
                                    18F,
                                    System.Drawing.FontStyle.Bold,
                                    System.Drawing.GraphicsUnit.Point,
                                    ((byte)(0)));
                                this.button1.Appearance.Options.UseFont = true;
                                this.button1.Location = new System.Drawing.Point(this.btnX, this.btnY);
                                this.button1.Name = table[j].TableId.ToString();
                                this.button1.Size = new System.Drawing.Size(75, 50);
                                this.button1.TabIndex = 1;
                                this.button1.Text = table[j].Id.ToString();
                                this.button1.Click += button1_Click;
                                this.panelTable.Controls.Add(this.button1);
                                this.flat = 2;
                                this.btnX += this.button1.Width + 5;

                            }

                            else if (this.flat == 2)
                            {
                                this.button1 = new SimpleButton();
                                if (service.ExportService.IsTableHaveGuest(table[j].TableId))
                                {this.button1.Appearance.ForeColor = Color.White;
                                    this.button1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;

                                }
                                else
                                {
                                    this.button1.Appearance.BackColor = System.Drawing.Color.Wheat;
                                }
                                this.button1.Appearance.Options.UseBackColor = true;
                                this.button1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
                                this.button1.Appearance.Font = new System.Drawing.Font(
                                    "Tahoma",
                                    18F,
                                    System.Drawing.FontStyle.Bold,
                                    System.Drawing.GraphicsUnit.Point,
                                    ((byte)(0)));
                                this.button1.Appearance.Options.UseFont = true;
                                this.button1.Location = new System.Drawing.Point(this.btnX, this.btnY);
                                this.button1.Name = table[j].TableId.ToString();
                                this.button1.Size = new System.Drawing.Size(75, 50);
                                this.button1.TabIndex = 1;
                                this.button1.Text = table[j].Id.ToString();
                                this.button1.Click += button1_Click;
                                this.panelTable.Controls.Add(this.button1);

                                this.btnY += this.button1.Height + 5;
                                this.btnX = 5;
                                this.flat = 0;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetValueForMember();
            var button = ((SimpleButton)sender);
            button.Appearance.BackColor = System.Drawing.Color.DarkRed;
            button.Appearance.ForeColor = Color.White;

            general.TableId = int.Parse(button.Name);

            lbTable.Text = "BÀN " + general.TableId;
            txttable.Text = general.TableId.ToString();

            button.LostFocus += this.button_LostFocus;
            
            this.LoadDataGridDetail();
            txtShortcut.SelectAll();
            txtShortcut.Focus();


            ////gridView2.FocusedRowHandle = gridView2.RowCount - 1;
            ////gridView2.Focus();
        }

        private void LoadDataGridDetail()
        {
            try
            {

                var listExp = service.ExportService.GetDetailExportByTableId(general.TableId);

                this.BuildGridTotal(listExp);


            }
            catch (Exception ex)
            {

                return;
            }

        }



        private void BuildGridTotal(List<ExportDetailModel> listExp)
        {

            decimal totalDicount = 0;
            decimal totalService = 0;
            decimal totalVAT = 0;

            if (listExp != null && listExp.Count > 0)
            {
                decimal total = 0;
                foreach (var ItemModel in listExp)
                {
                    total += (decimal)ItemModel.Total;
                }
                
                // empty row
                item = new ExportDetailModel();
                item.Quantity = null;
                item.Price = null;
                item.ItemDiscount = null;
                item.Total = null;
                listExp.Add(item);

                // total row
                item = new ExportDetailModel();
                item.Total = (double?) total;
                item.ItemName = "Tổng cộng";
                listExp.Add(item);

                // total row
                item = new ExportDetailModel();
                item.Total = (double?) -((total * listExp[0].TableDiscount) / 100);
                item.ItemDiscount = (decimal)listExp[0].TableDiscount;
                item.ItemName = "Giảm giá";
                listExp.Add(item);


                // thanh tien
                totalDicount = total - (total * ((ExportDetailModel)listExp[0]).TableDiscount) / 100 - listExp[0].MoneyExchangeByKul;
                item = new ExportDetailModel();
                item.Total = (double?) totalDicount;
                item.ItemDiscount = null;
                item.ItemName = "Thành tiền";
                listExp.Add(item);

                // service
                item = new ExportDetailModel();
                item.Total = (double?) ((total * ((ExportDetailModel)listExp[0]).Service) / 100);
                item.ItemDiscount = listExp[0].Service;
                item.ItemName = "Phí phòng lạnh";
                listExp.Add(item);


                // thanh tien
                totalService = (totalDicount + (total * ((ExportDetailModel)listExp[0]).Service) / 100);
                item = new ExportDetailModel();
                item.Total = (double?) totalService;
                item.ItemDiscount = null;
                item.ItemName = "Thành tiền";
                listExp.Add(item);

                // VAT
                item = new ExportDetailModel();
                item.Total = (double?) ((total * ((ExportDetailModel)listExp[0]).Vat) / 100);
                item.ItemDiscount = listExp[0].Vat;
                item.ItemName = "VAT";
                listExp.Add(item);

                // thanh tien thanh toan
                totalVAT = (total + (total * ((ExportDetailModel)listExp[0]).Service) / 100
                            + (total * ((ExportDetailModel)listExp[0]).Vat) / 100)
                           - (total * ((ExportDetailModel)listExp[0]).TableDiscount) / 100;
                item = new ExportDetailModel();
                item.Total = (double?) ((decimal)totalVAT - listExp[0].MoneyExchangeByKul);
                item.ItemDiscount = null;
                item.ItemName = "Tiền thanh toán";
                listExp.Add(item);

                general.TotalExportValue = (decimal)(item.Total ?? 0);



                txtVat.Text = listExp[0].Vat.ToString("N0");
                txtService.Text = listExp[0].Service.ToString("N0");
                txtDiscount.Text = listExp[0].TableDiscount.ToString("N0");
                General.general.ExportId = listExp[0].ExportId;
                gridControl2.DataSource = listExp;
                gridView2.SelectRow(gridView2.RowCount);


                try
                {
                    if (listExp.Any())
                    {
                        general.ExportId = listExp[0].ExportId;

                        var result = service.ExportService.GetExportByExportId(general.ExportId);
                        general.DateCreate = result.Created;
                        general.DatePaid = result.DatePaid;
                        general.tableName = result.TableName;
                        general.areaName = result.AreaName;
                    }
                }
                catch (Exception)
                {

                    return;
                }

                return;
            }
            txtVat.Text = "0";
            txtService.Text = "0";
            txtDiscount.Text = "0";
            gridControl2.DataSource = listExp;




        }

        private void button_LostFocus(object sender, EventArgs e)
        {
            var button = ((SimpleButton)sender);

            if (service.ExportService.IsTableHaveGuest(int.Parse(button.Name)))
            {
                button.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            }
            else
            {
                button.Appearance.BackColor = System.Drawing.Color.Wheat;
                button.Appearance.ForeColor = Color.Black;

            }



        }


        #region Text box Select All

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
        }

        private void txtService_Click(object sender, EventArgs e)
        {
            txtService.SelectAll();
        }

        private void txtVat_Click(object sender, EventArgs e)
        {
            txtVat.SelectAll();
        }

        #endregion

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            this.UpdateDiscount();

        }

        private void UpdateDiscount()
        {

            this.expENT = new ExportModel();
            expENT.Id = General.general.ExportId;

            this.expENT.Service = decimal.Parse((this.txtService.Text == "" ? "0" : this.txtService.Text));
            this.expENT.Vat = decimal.Parse((this.txtVat.Text == "" ? "0" : this.txtVat.Text));
            this.expENT.TableDiscount = decimal.Parse((this.txtDiscount.Text == "" ? "0" : this.txtDiscount.Text));


            if (service.ExportService.UpdateServiceAndVat(this.expENT))
            {

                this.LoadDataGridDetail();
            }
        }





        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (decimal)Keys.Enter)
            {
                this.UpdateDiscount();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var row = (ItemModel)this.gridView1.GetFocusedRow();
                if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Left
                    && (e as DXMouseEventArgs).Clicks == 2)
                {

                    // check table is having guest
                    if (service.ExportService.InitUpdateExport(general.ExportId,general.TableId,general.UserKey,row.Id, 1, general.CompanyId, row.CurrentPriceId, row.CurrentPriceValue))
                    {
                        this.LoadDataGridDetail();
                        ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);
                        return;
                    }
                    else
                    {
                        this.LoadDataGridDetail();
                        ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);

                        return;
                    }
                }

                if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Right
                    && (e as DXMouseEventArgs).Clicks == 2)
                {

                    if (!service.ExportService.InitUpdateExport(general.ExportId, general.TableId, general.UserKey, row.Id, -1, general.CompanyId, row.CurrentPriceId, row.CurrentPriceValue))
                    {
                        ActiveTableHaveGuest(Consts.TableStatus.Selected);
                    }
                    this.LoadDataGridDetail();

                }

        }
            catch (Exception ex)
            {

                throw  new Exception(ex.Message);
    }

}

        private void ActiveTableHaveGuest(int tableStatus)
        {
            var buttons = this.panelTable.Controls.Find(general.TableId.ToString(), true);
            foreach (var item in buttons)
            {
                if (item.GetType() == typeof (SimpleButton))
                {
                    var tempItem = (SimpleButton) item;
                    if (tableStatus == Consts.TableStatus.HaveGuest)
                    {
                        tempItem.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
                        break;
                    }
                    if (tableStatus == Consts.TableStatus.NotHaveGuest)
                    {
                        tempItem.Appearance.BackColor = System.Drawing.Color.Wheat;
                        tempItem.Appearance.ForeColor = Color.Black;
                        break;
                    }

                    if (tableStatus == Consts.TableStatus.Selected)
                    {
                        tempItem.Appearance.BackColor = System.Drawing.Color.Wheat;
                        tempItem.Appearance.ForeColor = Color.Black;
                        break;
                    }
                  
                }
            }
        }


        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExportDetailModel row = (ExportDetailModel)this.gridView2.GetFocusedRow();
                if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Left
                    && (e as DXMouseEventArgs).Clicks == 2)
                {

                    // check table is having guest
                    if (row.Price != null && service.ExportService.InitUpdateExport(general.ExportId, general.TableId, general.UserKey, row.ItemId, 1, general.CompanyId, row.ItemPriceId, (decimal)row.Price))
                    { 
                        this.LoadDataGridDetail();
                        ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);
                        return;
                    }
                    else
                    {
                        this.LoadDataGridDetail();
                        ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);

                        return;
                    }
                }

                if ((e as DXMouseEventArgs).Button == System.Windows.Forms.MouseButtons.Right
                    && (e as DXMouseEventArgs).Clicks == 2)
                {

                    if (row.Price != null && !service.ExportService.InitUpdateExport(general.ExportId, general.TableId, general.UserKey, row.ItemId, -1, general.CompanyId, row.ItemPriceId, row.Price.Value))
                    {
                        ActiveTableHaveGuest(Consts.TableStatus.NotHaveGuest);
                    }
                    this.LoadDataGridDetail();

                    return;
                }

            }
            catch (Exception)
            {

                return;
            }

        }

        private void gridView2_PopupMenuShowing(
            object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

            //GridView view = sender as GridView;
            //// Check whether a row is right-clicked.
            //if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            //{
            //    int rowHandle = e.HitInfo.RowHandle;
            //    // Delete existing menu items, if any.
            //    e.Menu.Items.Clear();

            //    // Add a check menu item.
            //    DXMenuItem item = CreateMergingEnabledMenuItem(view, rowHandle);

            //    item.BeginGroup = true;
            //    e.Menu.Items.Add(item);
            //}
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            try
            {
                ExportDetailModel row = (ExportDetailModel)this.gridView2.GetFocusedRow();
                decimal inSt = (decimal)((decimal)row.ItemDiscount == null ? 0 : row.ItemDiscount);
                string cellValue = "0";
                if (inSt < 0 || inSt > 100)
                {
                    //Set errors with specific descriptions for the columns
                    MessageBox.Show("Chỉ được giảm giá từ 0% đến 100%", "Thông báo");
                    this.LoadDataGridDetail();
                    return;
                }


                service.ExportService.UpdateDiscountForItem(General.general.ExportId, row.ItemId, inSt);
                this.LoadDataGridDetail();
                gridView2.FocusedRowHandle = gridView2.RowCount - 1;
                gridView2.Focus();
            }
            catch (Exception)
            {
                return;
            }

        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDetailModel row = (ExportDetailModel)this.gridView2.GetFocusedRow();
                general.itemId = row.ItemId;

            }
            catch (Exception)
            {

                return;
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.RowCount > 0)
                {
                    
                    if (MessageBox.Show("Bạn có muốn in hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        general.DatePaid = DateTimeOffset.UtcNow;
                        printDocument1.PrinterSettings.PrinterName = general.PrinterBillName;
                        printDocument1.Print();
                    }
                    UpdateDiscount();
                    if (service.ExportService.PaidBill(general.ExportId, customer, chkUseKul.Checked, general.TotalExportValue))
                    {
                        ActiveTableHaveGuest(Consts.TableStatus.NotHaveGuest);
                    }
                    
                   
                 

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Không tìm thấy máy in vui lòng kiểm tra lại phần cài đặt", "Thông báo");
                return;
            }


        }



        int x = 0;
        int y = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            x = 0;
            y = 0;
            var font = new Font("Tahoma", 14);
            //draw title
            if (general.isTitlePrint)
            {

                e.Graphics.DrawString(general.titlePrint, font, Brushes.Black, new RectangleF(15, y, 210, 20));

            }

            // draw Name of bussiness
            if (general.isLogoTextPrint)
            {
                font = new Font("Tahoma", 38, FontStyle.Bold);
                y += 20;
                e.Graphics.DrawString("SOKUL", font, Brushes.Black, new RectangleF(0, y, 220, 95));
                y += 75;

            }

            //drawing logo
            Image i = Image.FromFile(general.GetStartupPath() + @"img\logo.png");
            if (general.isLogoImagePrint)
            {
                y += 20;

                Point p = new Point(0, y);
                e.Graphics.DrawImage(i, 0, y, i.Width + 10, i.Height);
                y += i.Height;
            }



            // drawing date
            font = new Font("Tahoma", 7);
            if (general.isDatePrint)
            {


                e.Graphics.DrawString(string.Format("{0:dd/MM/yyyy}", general.DateCreate), font, Brushes.Black, new RectangleF(65, y, 100, 15));
                y += 15;
            }

            // time in
            if (general.isTimeInPrint)
            {

                e.Graphics.DrawString(string.Format("{0:hh:mm tt}", general.DateCreate), font, Brushes.Black, new RectangleF(0, y, 110, 15));

            }

            // timeout
            if (general.isTimeOutPrint)
            {

                e.Graphics.DrawString(string.Format("{0:hh:mm tt}", general.DatePaid), font, Brushes.Black, new RectangleF(125, y, 100, 15));
                y += 15;
            }

            //draw table
            if (general.isTablePrint)
            {

                e.Graphics.DrawString("Bàn " + general.tableName + "(" + general.areaName + ")", font, Brushes.Black, new RectangleF(0, y, 130, 15));


            }
            //draw exportid
            if (general.isExportIdPrint)
            {

                e.Graphics.DrawString(general.ExportId, font, Brushes.Black, new RectangleF(125, y, 90, 15));
                y += 15;

            }


            // draw custumername

            if (general.isCustomerPrint && txtNote.Text != "")
            {

                e.Graphics.DrawString("Ghi chú : " + txtNote.Text, font, Brushes.Black, new RectangleF(0, y, 220, 15));
                y += 15;

            }

            // draw title of grid
            font = new Font("Tahoma", 10);
            y += 20;
            e.Graphics.DrawString("Tên Món", font, Brushes.Black, new RectangleF(0, y, 110, 20));
            e.Graphics.DrawString("SL", font, Brushes.Black, new RectangleF(120, y, 125, 20));
            e.Graphics.DrawString("ĐGiá", font, Brushes.Black, new RectangleF(150, y, 125, 20));
            y += 10;
            e.Graphics.DrawString("--------------------------------------------", font, Brushes.Black, new RectangleF(0, y, 250, 20));

            y += 15;
            //draw item
            var entList = gridView2.DataSource as List<ExportDetailModel>;
            font = new Font("Tahoma", 7);
            foreach (var item in entList)
            {
                if (item.ItemName == "" || item.ItemName == null)
                {
                    e.Graphics.DrawString("--------------------", font, Brushes.Black, new RectangleF(120, y - 5, 125, 15));
                    y += 5;
                    break;
                }
                e.Graphics.DrawString(item.ItemName, font, Brushes.Black, new RectangleF(0, y, 110, 15));
                e.Graphics.DrawString(item.Quantity.ToString(), font, Brushes.Black, new RectangleF(120, y, 125, 15));
                e.Graphics.DrawString(string.Format("{0:0,0}", item.Price), font, Brushes.Black, new RectangleF(150, y, 125, 15));
                y += 15;

            }
            // draw total
            double total = 0;
            double totalPaid = 0;

            if (general.isTotalPrint)
            {
                foreach (var item in entList)
                {
                    if (item.ItemName == "Tổng cộng")
                    {
                        e.Graphics.DrawString(item.ItemName, font, Brushes.Black, new RectangleF(0, y, 110, 15));
                        e.Graphics.DrawString(string.Format("{0:0,0}", item.Total), font, Brushes.Black, new RectangleF(140, y, 125, 15));
                        total = (double)item.Total;
                        totalPaid = (double)item.Total;
                        y += 15;
                        break;
                    }


                }
            }


            // draw discount
            if (general.isTotalDiscount)
            {
                foreach (var item in entList)
                {
                    if (item.ItemName == "Tiền thanh toán")
                    {
                        e.Graphics.DrawString(string.Format("-{0:0,0}", (total - (double)item.Total)), font, Brushes.Black, new RectangleF(140, y, 125, 15));
                        totalPaid = (double)((total - (double)item.Total) == 0 ? item.Total : item.Total);
                        y += 15;
                        break;
                    }


                }
            }


            //draw total pay
            if (general.isTotalPayPrint)
            {
                e.Graphics.DrawString("---------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y - 5, 250, 10));
                y += 10;

                font = new Font("Tahoma", 8);
                e.Graphics.DrawString("Tiền thanh toán", font, Brushes.Black, new RectangleF(0, y, 110, 30));
                e.Graphics.DrawString(string.Format("{0:0,0} d", totalPaid), font, Brushes.Black, new RectangleF(120, y, 250, 30));
                y += 15;
            }


            if (general.isSayGoodByePrint)
            {
                y += 30;
                e.Graphics.DrawString(general.isSayGoodByeText1, font, Brushes.Black, new RectangleF(50, y, 250, 15));
                y += 15;
                e.Graphics.DrawString(general.isSayGoodByeText2, font, Brushes.Black, new RectangleF(65, y, 250, 250));
                y += 15;

            }

            if (general.isDiscountInfomationPrint)
            {
                y += 30;
                e.Graphics.DrawString(general.DiscountInfomationPrintTest, font, Brushes.Black, new RectangleF(0, y, 210, 1500));


            }

            // draw emply space

            y += 10;
            e.Graphics.DrawString(string.Format("\n{0}", "."), font, Brushes.LightGreen, new RectangleF(0, y, 120, 250));
        }
        #region Menu  Code

        private void khuVựcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.area_read))
                //{
                //    if (Application.OpenForms["FrmArea"] == null)
                //    {
                //        FrmArea area = new FrmArea();
                //        area.ShowDialog();
                //        return;

                //    }
                //    Application.OpenForms["FrmArea"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.table_read))
                //{
                //    if (Application.OpenForms["FrmTable"] == null)
                //    {
                //        FrmTable area = new FrmTable();
                //        area.ShowDialog();
                //        return;

                //    }
                //    Application.OpenForms["FrmTable"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void mónĂnThứcUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.item_read))
                //{
                //    if (Application.OpenForms["FrmItem"] == null)
                //    {
                //        FrmItem area = new FrmItem();
                //        area.ShowDialog();
                //        return;

                //    }
                //    Application.OpenForms["FrmItem"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void nguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.material_read))
                //{
                //    if (Application.OpenForms["frmMaterial"] == null)
                //    {
                //        var area = new frmMaterial();
                //        area.ShowDialog();
                //        return;

                //    }
                //    Application.OpenForms["frmMaterial"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        #endregion

        private void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.emp_read))
                //{
                //    if (Application.OpenForms["FrmEmployer"] == null)
                //    {
                //        FrmEmployer area = new FrmEmployer();
                //        area.ShowDialog();
                //        return;

                //    }
                //    Application.OpenForms["FrmEmployer"].ShowDialog();
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmEmployer"] == null)
            {
                FrmEmployer area = new FrmEmployer();
                area.ShowDialog();
                return;

            }
            Application.OpenForms["FrmEmployer"].ShowDialog();
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmEmployer"] == null)
            {
                FrmEmployer area = new FrmEmployer();
                area.ShowDialog();
                return;

            }
            Application.OpenForms["FrmEmployer"].ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tạoTàiKhoảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.user_read))
                //{
                //    if (Application.OpenForms["FrmUserAccount"] == null)
                //    {
                //        FrmUserAccount area = new FrmUserAccount();
                //        area.ShowDialog();
                //        return;
                //    }
                //    Application.OpenForms["FrmUserAccount"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }


        }

        private void xóaTàiKhoảnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmUserAccount"] == null)
            {
                FrmUserAccount area = new FrmUserAccount();
                area.ShowDialog();
                return;

            }
            Application.OpenForms["FrmUserAccount"].ShowDialog();
        }

        private void thiếtLậpMáyInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.print_setting))
            //{
            //    if (Application.OpenForms["frmPrintSetting"] == null)
            //    {
            //        frmPrintSetting area = new frmPrintSetting();
            //        area.ShowDialog();
            //        return;

            //    }
            //    Application.OpenForms["frmPrintSetting"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Application.OpenForms["frmLogin"].Show();
                this.Close();
            }
        }

        private void txttable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;

            }

            if (((Keys)e.KeyChar == Keys.Enter))
            {
                txtShortcut.Text = "";
                txtShortcut.Focus();
                General.general.TableId = int.Parse(txttable.Text);
            }
        }

        private void txttable_Leave(object sender, EventArgs e)
        {
            if (txttable.Text == "")
            {
                // MessageBox.Show("Số bàn không thể để trống", "Thông báo");

                txttable.Focus();
                return;
            }
            General.general.TableId = int.Parse(txttable.Text);
        }

        private void txtShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right))
            {
                gridView3.Focus();
                var result = gridView3.GetFocusedRowCellValue("ItemName");
                txtItemName.Text = result.ToString();

            }
        }

        private void txtShortcut_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (((Keys)e.KeyChar == Keys.Enter))
                {
                    gridView3.Focus();
                    var result = gridView3.GetFocusedRowCellValue("ItemName");
                    txtItemName.Text = result.ToString();
                }
            }
            catch (Exception)
            {

                return;
            }

        }

        private void txtShortcut_TextChanged(object sender, EventArgs e)
        {
            gridView3.Columns["Shortcut"].FilterInfo =
  new ColumnFilterInfo("[Shortcut] LIKE '" + txtShortcut.Text + "%'");
            if (txtShortcut.Text.Trim() == "")
            {
                glkItem.Visible = false;
            }
            else
            {
                glkItem.Visible = true;
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '-'))
                    e.Handled = true;


                // only allow minus sign at the beginning
                if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                    e.Handled = true;



                if (((Keys)e.KeyChar == Keys.Enter))
                {
                    frmControl control = new frmControl(service);
                    if (txtQuantity.Text == @"-")
                    {
                        txtQuantity.Text = "1";
                    }
                    var result = control.AddItemToExportForForm(int.Parse(this.txtQuantity.Text));
                    if (result == false)
                    {
                        ActiveTableHaveGuest(Consts.TableStatus.NotHaveGuest);
                        this.LoadDataGridDetail();
                        showFilterItem();
                    }
                    else
                    {
                        ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);
                        this.txtShortcut.SelectAll();
                        this.txtShortcut.Focus();
                        this.LoadDataGridDetail();
                        showFilterItem();
                    }
                }
            }
            catch (Exception)
            {

                txtQuantity.SelectAll();
                txtQuantity.Focus();
            }

        }

        private void glkItem_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left))
            {
                txtShortcut.Focus();
                txtItemName.Text = "";
                glkItem.Visible = false;
            }
        }

        private void glkItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter))
            {
                glkItem.Visible = false;
                txtQuantity.Focus();
                txtQuantity.Text = "1";
                txtQuantity.SelectAll();
                var result = gridView3.GetFocusedRowCellValue("Id");
                General.general.itemPriceId = int.Parse(gridView3.GetFocusedRowCellValue("CurrentPriceId")!= null ? gridView3.GetFocusedRowCellValue("CurrentPriceId").ToString(): "0");
                General.general.currentPriceValue = decimal.Parse(gridView3.GetFocusedRowCellValue("CurrentPriceValue") != null ? gridView3.GetFocusedRowCellValue("CurrentPriceValue").ToString(): "0");
                General.general.itemId = int.Parse(result?.ToString() ?? "0");

            }
        }

        private void glkItem_Leave(object sender, EventArgs e)
        {
            var result = gridView3.GetFocusedRowCellValue("Id");
            if (result != null)
            {
                General.general.itemId = int.Parse(result.ToString());
            }
        }
        bool flag = false;
        private void frmControl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {


                if (e.KeyData.ToString() == general.NEWTABLE)
                {
                    if (flag == false)
                    {
                        if (general.TableId > 0)
                        {
                            txttable.Text = general.TableId.ToString();
                            txttable.SelectAll();
                            txttable.Focus();
                            panelExportByForm.Visible = true;
                            txtShortcut.Focus();
                        }
                        flag = true;
                        return;
                    }

                    panelExportByForm.Visible = false;
                    flag = false;
                }

                if (e.KeyData.ToString() == general.SLIPT)
                {
                    if (Application.OpenForms["frmSplitTable"] == null)
                    {
                        frmSplitTable area = new frmSplitTable();
                        area.ShowDialog();
                        ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);
                        this.LoadDataGridDetail();
                        return;
                    }
                    Application.OpenForms["frmSplitTable"].ShowDialog();
                    ActiveTableHaveGuest(Consts.TableStatus.HaveGuest);
                    this.LoadDataGridDetail();
                    return;
                }

                if (e.KeyData.ToString() == general.JOIN)
                {
                    if (Application.OpenForms["FrmJoinTable"] == null)
                    {
                        FrmJoinTable area = new FrmJoinTable();
                        area.ShowDialog();
                        this.LoadDataGridDetail();
                        ActiveTableHaveGuest(Consts.TableStatus.NotHaveGuest);
                        return;
                    }
                    Application.OpenForms["FrmJoinTable"].ShowDialog();
                    this.LoadDataGridDetail();
                    ActiveTableHaveGuest(Consts.TableStatus.NotHaveGuest);
                    return;
                }

                if (e.KeyData.ToString() == general.PAID)
                {
                    try
                    {
                        if (gridView2.RowCount > 0)
                        {


                            if (MessageBox.Show("Bạn có muốn in hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                printDocument1.PrinterSettings.PrinterName = general.PrinterBillName;
                                printDocument1.Print();
                            }
                            general.DatePaid = DateTimeOffset.UtcNow;

                            UpdateDiscount();
                            if (service.ExportService.PaidBill(general.ExportId, customer, chkUseKul.Checked, general.TotalExportValue))
                            {
                                ActiveTableHaveGuest(Consts.TableStatus.NotHaveGuest);
                            }
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Không tìm thấy máy in vui lòng kiểm tra lại phần cài đặt", "Thông báo");
                        return;
                    }

                    return;
                }

                if (e.KeyData.ToString() == general.PRINTAGAIN)
                {
                    if (Application.OpenForms["frmPrintAgain"] == null)
                    {
                        frmPrintAgain area = new frmPrintAgain();
                        area.ShowDialog();
                        return;
                    }
                    Application.OpenForms["frmPrintAgain"].ShowDialog();

                    return;
                }

                if (e.KeyData.ToString() == general.PRINTNOTPAY)
                {
                    try
                    {
                        if (gridView2.RowCount > 0)
                        {



                            printDocument1.PrinterSettings.PrinterName = general.PrinterBillName;
                            printDocument1.Print();


                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Không tìm thấy máy in vui lòng kiểm tra lại phần cài đặt", "Thông báo");
                        return;
                    }

                    return;
                }

                if (e.KeyData.ToString() == general.HELP)
                {

                    return;
                }

                if (e.KeyData.ToString() == general.REPORT)
                {
                    //if (Application.OpenForms["frmReport"] == null)
                    //{
                    //    frmReport area = new frmReport();
                    //    area.ShowDialog();

                    //    return;
                    //}
                    //Application.OpenForms["frmReport"].ShowDialog();
                    //return;
                }

                if (e.KeyData.ToString() == general.CHANGEPASS)
                {


                    if (Application.OpenForms["FrmChangePassword"] == null)
                    {
                        FrmChangePassword area = new FrmChangePassword();
                        area.ShowDialog();

                        return;
                    }
                    Application.OpenForms["FrmChangePassword"].ShowDialog();

                }
            }
            catch (Exception)
            {


            }
        }

        public bool? AddItemToExportForForm(int quantity)
        {
            try
            {

                return service.ExportService.InitUpdateExport(general.ExportId, general.TableId, general.UserKey,
                    general.itemId, quantity, general.CompanyId, general.itemPriceId, general.currentPriceValue);

            }
            catch (Exception)
            {
                return null;
            }
        }

        private void panelExportByForm_Leave(object sender, EventArgs e)
        {
            //panelExportByForm.Visible = false;
        }

        private void btIntam_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.RowCount > 0)
                {



                    printDocument1.PrinterSettings.PrinterName = general.PrinterBillName;
                    printDocument1.Print();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Không tìm thấy máy in vui lòng kiểm tra lại phần cài đặt", "Thông báo");
                return;
            }



        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (service.R(general.groupUserId, Role.split_table))
                //{

                //    if (Application.OpenForms["frmSplitTable"] == null)
                //    {
                //        frmSplitTable area = new frmSplitTable();
                //        area.ShowDialog();
                //        var button2 = (SimpleButton)this.panelTable.Controls.Find(general.TableId.ToString(), true)[1];
                //        button2.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
                //        this.LoadDataGridDetail();
                //        return;
                //    }
                //    Application.OpenForms["frmSplitTable"].ShowDialog();
                //    if (general.SuccessFlag)
                //    {
                //        var button1 = (SimpleButton)this.panelTable.Controls.Find(general.TableId.ToString(), true)[1];
                //        button1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
                //        this.LoadDataGridDetail();
                //    }

                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }


        }

        private void ghépBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.join_table))
                //{
                //    if (Application.OpenForms["FrmJoinTable"] == null)
                //    {
                //        FrmJoinTable area = new FrmJoinTable();
                //        area.ShowDialog();
                //        this.LoadDataGridDetail();
                //        var button1 = (SimpleButton)this.panelTable.Controls.Find(general.tableIdJoin.ToString(), true)[0];
                //        button1.Appearance.BackColor = System.Drawing.Color.Wheat;
                //        button1.Appearance.ForeColor = Color.Black;
                //        return;
                //    }
                //    Application.OpenForms["FrmJoinTable"].ShowDialog();
                //    this.LoadDataGridDetail();
                //    var button = (SimpleButton)this.panelTable.Controls.Find(general.tableIdJoin.ToString(), true)[0];
                //    button.Appearance.BackColor = System.Drawing.Color.Wheat;
                //    button.Appearance.ForeColor = Color.Black;
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }


        }

        private void báoCáoTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.report))
                //{
                //    if (Application.OpenForms["FrmReport"] == null)
                //    {
                //        FrmReport area = new FrmReport();
                //        area.ShowDialog();

                //        return;
                //    }
                //    Application.OpenForms["FrmReport"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }


        }

        private void cấpQuyềnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.permission))
                //{
                //    if (Application.OpenForms["FrmPermit"] == null)
                //    {
                //        FrmPermit area = new FrmPermit();
                //        area.ShowDialog();

                //        return;
                //    }
                //    Application.OpenForms["FrmPermit"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }


        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                //if (service.R(general.groupUserId, Role.change_pass))
                //{
                //    if (Application.OpenForms["FrmChangePassword"] == null)
                //    {
                //        FrmChangePassword area = new FrmChangePassword();
                //        area.ShowDialog();

                //        return;
                //    }
                //    Application.OpenForms["FrmChangePassword"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void đặtLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //if (service.R(general.groupUserId, Role.user_read))
                //{
                //    if (Application.OpenForms["FrmUserAccount"] == null)
                //    {
                //        FrmUserAccount area = new FrmUserAccount();
                //        area.ShowDialog();
                //        return;
                //    }
                //    Application.OpenForms["FrmUserAccount"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void inLạiHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                //if (service.R(general.groupUserId, Role.print_flag))
                //{
                //    if (Application.OpenForms["frmPrintAgain"] == null)
                //    {
                //        frmPrintAgain area = new frmPrintAgain();
                //        area.ShowDialog();
                //        return;
                //    }
                //    Application.OpenForms["frmPrintAgain"].ShowDialog();
                //    return;
                //}
                //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
            }
            catch (Exception)
            {


            }

        }

        private void thiếtKếHóaĐơnTínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.bill_setting))
            //{
            //    if (Application.OpenForms["frmBillSetting"] == null)
            //    {
            //        frmBillSetting area = new frmBillSetting();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["frmBillSetting"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");



        }

        private void danhSáchQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thiếtLậpPhímTắtChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.shortcut_setting))
            //{
            //    if (Application.OpenForms["frmShortcutSetting"] == null)
            //    {
            //        frmShortcutSetting area = new frmShortcutSetting();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["frmShortcutSetting"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");


        }

        private void lậpHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.shortcut_setting))
            //{
            //    if (Application.OpenForms["frmBackup"] == null)
            //    {
            //        frmBackup area = new frmBackup();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["frmBackup"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.shortcut_setting))
            //{
            //    if (Application.OpenForms["frmServerConfig"] == null)
            //    {
            //        frmServerConfig area = new frmServerConfig();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["frmServerConfig"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");
        }

        private void thôngTinVềPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmInfomation"] == null)
            {
                frmInfomation area = new frmInfomation();
                area.ShowDialog();
                return;
            }
            Application.OpenForms["frmInfomation"].ShowDialog();
        }


        private void showFilterItem()
        {

            gridView3.Columns["Shortcut"].FilterInfo =
 new ColumnFilterInfo("[Shortcut] LIKE '" + txtShortcut.Text + "%'");
            if (txtShortcut.Text.Trim() == "")
            {
                glkItem.Visible = false;
            }
            else
            {
                glkItem.Visible = true;
            }

        }

        private void quảnLýNhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.groupuser_read))
            //{

            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");

            //if (Application.OpenForms["FrmGroupUser"] == null)
            //{
            //    FrmGroupUser area = new FrmGroupUser();
            //    area.ShowDialog();
            //    return;
            //}
            //Application.OpenForms["FrmGroupUser"].ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)

        {
            //if (service.R(general.groupUserId, Role.customer_read))
            //{
            //    if (Application.OpenForms["FrmCustomer"] == null)
            //    {
            //        FrmCustomer area = new FrmCustomer();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmCustomer"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");


        }

        private void quảnLýThẻThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (service.R(general.groupUserId, Role.membercard_read))
            //{

            //    if (Application.OpenForms["FrmMemberCard"] == null)
            //    {
            //        FrmMemberCard area = new FrmMemberCard();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmMemberCard"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");

        }

        private void quảnLýLoạiThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (service.R(general.groupUserId, Role.membertype_read))
            //{
            //    if (Application.OpenForms["FrmMemberType"] == null)
            //    {
            //        FrmMemberType area = new FrmMemberType();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmMemberType"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");


        }

        private void địnhNghĩaTrạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (service.R(general.groupUserId, Role.state_read))
            //{
            //    if (Application.OpenForms["FrmState"] == null)
            //    {
            //        FrmState area = new FrmState();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmState"].ShowDialog();

            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");



        }

        private void thiếtLậpMệnhGiáChoKulToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (service.R(general.groupUserId, Role.kulexchange_full))
            //{
            //    if (Application.OpenForms["FrmUpdateKulValue"] == null)
            //    {
            //        FrmUpdateKulValue area = new FrmUpdateKulValue();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmUpdateKulValue"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");



        }

        private void thiếtLậpSLKulKhiBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (service.R(general.groupUserId, Role.kulexport_full))
            //{
            //    if (Application.OpenForms["FrmExportKulExchange"] == null)
            //    {
            //        FrmExportKulExchange area = new FrmExportKulExchange();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmExportKulExchange"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");



        }

        private void đặtGiáChoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (service.R(general.groupUserId, Role.shortcut_setting))
            //{
            //    if (Application.OpenForms["FrmItemPrice"] == null)
            //    {
            //        FrmItemPrice area = new FrmItemPrice();
            //        area.ShowDialog();
            //        return;
            //    }
            //    Application.OpenForms["FrmItemPrice"].ShowDialog();
            //    return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");



        }

        private void txtMemberNumber_Click(object sender, EventArgs e)
        {
            txtMemberNumber.SelectAll();
        }




        private CustomerModel customer;


        private void chkUseKul_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseKul.Checked)
            {
                try
                {

                    var listExp = service.ExportService.GetDetailExportByTableId(general.TableId);
                    if (listExp.Count > 0)
                    {
                        txtDiscount.Text = general.TableDiscount.ToString();
                        listExp[0].TableDiscount = general.TableDiscount;
                        this.BuildGridTotal(listExp);
                    }
                    
                }
                catch (Exception)
                {

                    return;
                }



            }
            else
            {
                LoadDataGridDetail();

            }

        }

        private int CalculateKul(int totalKul, int kulValue, decimal totalExport)
        {
            var totalMoney = totalKul * kulValue;

            if (totalMoney < totalExport)
            {
                var part = totalMoney / 1000;

                return (part * 1000) / kulValue;
            }
            var part1 = totalExport / 1000;
            return (int)part1 * 1000 / kulValue;

        }


        private void ResetValueForMember()
        {


            lblCustomerName.Text = "";
            lblTotalKul.Text = "";
            lblKulCalculate.Text = "";
            chkUseKul.Enabled = false;
            txtMemberNumber.Text = "Nhập mã số thành viên";
            customer = null;
            chkUseKul.Checked = false;

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUseKul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang hoàn thiện chuẩn bị ra mắt các bạn");
        }

        private void lậpPhiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (service.R(general.groupUserId, Role.kulexport_full))
            //{
            if (Application.OpenForms["FrmImport"] == null)
            {
                FrmImport area = new FrmImport();
                area.ShowDialog();
                return;
            }
            Application.OpenForms["FrmImport"].ShowDialog();
            return;
            //}
            //MessageBox.Show("Bạn chưa chưa được cấp quyền sử dụng cho tính năng này");

        }

        private void NoteCheck_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("a");

        }


        private void gridView2_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "Note") return;
            GridView gv = sender as GridView;
            var fieldName = gv.GetRowCellValue(e.RowHandle, gv.Columns["Note"]);
            if (fieldName != null)
            {



                switch (fieldName.ToString())
                {
                    case "True":
                    case "False":
                        var rowTest = (ExportDetailModel)gv.GetRow(e.RowHandle);

                        if (rowTest != null && rowTest.ItemId > 0)
                        {
                            e.RepositoryItem = repositoryItemCheckEdit1;
                            break;
                        }

                        e.RepositoryItem = repositoryItemTextEdit1;
                        break;

                    default:

                        e.RepositoryItem = repositoryItemTextEdit1;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < gridView2.RowCount; i++)
            //{
            //    var rowTest = (ExportDetailModel)gridView2.GetRow(i);


            //    if (rowTest.ItemId > 0)
            //    {
            //        var checkBox = new RepositoryItemCheckEdit();
            //        checkBox.ValueChecked = rowTest.Note;
            //        gridView2.Columns["Note"].ColumnEdit = checkBox;

            //    }
            //    else
            //    {
            //        gridView2.Columns["Note"].ColumnEdit = new RepositoryItemTextEdit();
            //    }
            //}
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckEdit)sender;
            if (check != null && (bool)check.EditValue)
            {
                var row = (ExportDetailModel)this.gridView2.GetRow(gridView2.GetFocusedDataSourceRowIndex());
                service.ExportService.UpdateNoteForExportDetailItem(general.ExportId, row.ItemId, true);
                LoadDataGridDetail();

            }
            else
            {
                var row = (ExportDetailModel)this.gridView2.GetRow(gridView2.GetFocusedDataSourceRowIndex());
                service.ExportService.UpdateNoteForExportDetailItem(general.ExportId, row.ItemId, false);
                LoadDataGridDetail();
            }
        }

        private void btnAddSuggestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberNumber.Text.Trim() == "" || txtMemberNumber.Text == "Nhập mã số thành viên")
                {
                    MessageBox.Show(
                        "Dữ liệu thêm vào không được bỏ trống !!!!. Vui lòng nhập dữ liệu cần thêm vào ô [nhập mã số thành viên]",
                        "Thông báo");
                    return;
                }
                if (
                    MessageBox.Show("Bạn có muốn thêm [" + txtMemberNumber.Text.Trim() + "] làm gợi ý khi nhập mã số thẻ thành viên ?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    var tempPath = Path.GetTempPath();
                    var path = tempPath + "MemberCartSuggestList.txt";

                    // This text is added only once to the file. 
                    if (!File.Exists(path))
                    {
                        // Create a file to write to. 
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(txtMemberNumber.Text.Trim());

                        }
                        ReloadSuggestListMemberForMemberCard();
                    }
                    else
                    {
                        // This text is always added, making the file longer over time 
                        // if it is not deleted. 
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(txtMemberNumber.Text.Trim());

                        }
                        ReloadSuggestListMemberForMemberCard();
                    }

                    MessageBox.Show("Đã thêm thành công gợi ý khi gõ mã số thành viên", "Thông báo");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("File đang bị chiếm dụng có thể do virus.Vui lòng đăng nhập lại hoặc restart lại máy tính của bạn", "Thông báo");
            }
        }

        public void ReloadSuggestListMemberForMemberCard()
        {
            try
            {
                var tempPath = Path.GetTempPath();
                var path = tempPath + "MemberCartSuggestList.txt";
                // Open the file to read from. 
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        var s = "";
                        var sourceText = new AutoCompleteStringCollection();
                        while ((s = sr.ReadLine()) != null)
                        {
                            sourceText.Add(s);
                        }
                        txtMemberNumber.AutoCompleteCustomSource = sourceText;
                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("File đang bị chiếm dụng có thể do virus.Vui lòng đăng nhập lại hoặc restart lại máy tính của bạn", "Thông báo");
            }


        }


        private void btnDeleteAllSuggest_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Bạn có muốn xóa hết các gợi ý ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var tempPath = Path.GetTempPath();
                    var path = tempPath + "MemberCartSuggestList.txt";
                    File.WriteAllText(path, "");
                    ReloadSuggestListMemberForMemberCard();
                    MessageBox.Show("Đã xóa tất cả gợi ý", "Thông báo");
                }

            }
            catch (Exception)
            {

                MessageBox.Show(
                    "File đang bị chiếm dụng có thể do virus.Vui lòng đăng nhập lại hoặc restart lại máy tính của bạn",
                    "Thông báo");
            }
        }

        private void txtMemberNumber_LostFocus(object sender, System.EventArgs e)
        {

            if (txtMemberNumber.Text == "")
            {
                txtMemberNumber.Text = "Nhập mã số thành viên";
            }
        }

        private void txtMemberNumber_Enter(object sender, EventArgs e)
        {

        }

        private void txtMemberNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                if (txtMemberNumber.Text.Trim() == "")
                {
                    return;
                }

                customer = service.CustomerService.GetCustomerByMemberCardNumber(txtMemberNumber.Text);

                if (customer != null)
                {
                    lblTotalKul.Text = customer.KulPoint.ToString() + " Kul";
                    lblCustomerName.Text = customer.FullName;
                    chkUseKul.Enabled = true;
                    general.TableDiscount = service.CustomerService.GetDiscountMemberByCustomerId(customer.Id);
                    txtDiscount.Text = general.TableDiscount.ToString();

                }
                else
                {
                    lblTotalKul.Text = "";
                    lblKulCalculate.Text = "";

                    lblCustomerName.Text = "Không tìm thấy";
                    chkUseKul.Enabled = false;
                }
            }


        }


    }
}
