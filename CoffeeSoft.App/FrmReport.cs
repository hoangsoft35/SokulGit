using System.Windows.Forms;

namespace CoffeeSoft.App
{
    public partial class FrmReport : Form
    {
        //private GridControl grid;

        //private IServices service;
        //public FrmReport()
        //{
        //    service=new Services();
        //    grid=new GridControl();
        //    InitializeComponent();

        //    dtpFrom.EditValue = DateTime.Now;
        //    dtpTo.EditValue = DateTime.Now;
        //}

        //private void btnExcute_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (glkReportType.EditValue==null)
        //        {
        //            MessageBox.Show("Chọn loại báo cáo cần xem");
        //            return;
        //        }
        //        if (dtpFrom.EditValue == null || dtpTo ==null)
        //        {
        //            MessageBox.Show("Chưa chọn ngày xem");
        //            return;
        //        }
        //        DateTime from = DateTime.Parse(dtpFrom.EditValue.ToString());
        //        DateTime to = DateTime.Parse(dtpTo.EditValue.ToString());
        //        switch (int.Parse(glkReportType.EditValue.ToString()))
        //        {
        //            case (int)Report.SynthesysReport:
        //                var gridControl1 = InitializeGridControlTemplate((int)Report.SynthesysReport);
        //                gridControl1.DataSource = service.ReportSynthesis(from, to);
        //                panel2.Controls.Clear();
        //                panel2.Controls.Add(gridControl1);
        //                break;
        //            case (int)Report.ItemReport:
        //                var gridControl2 = InitializeGridControlTemplate((int)Report.ItemReport);
        //                gridControl2.DataSource = service.ReportByItem(from, to);
                       
        //                panel2.Controls.Clear();
        //                panel2.Controls.Add(gridControl2);
        //                break;
        //            case (int)Report.ExportIdReport:
        //                var gridControl3 = InitializeGridControlTemplate((int)Report.ExportIdReport);
        //                gridControl3.DataSource = service.ReportByExport(from, to);
        //                panel2.Controls.Clear();
        //                panel2.Controls.Add(gridControl3);
        //                break;
        //            case (int)Report.DateReport:
        //                var gridControl4 = InitializeGridControlTemplate((int)Report.DateReport);
        //                gridControl4.DataSource = service.ReportByDate(from, to);
        //                panel2.Controls.Clear();
        //                panel2.Controls.Add(gridControl4);
        //                break;
        //        }


        //    }
        //    catch (Exception)
        //    {
             
        //    }

          
        //}

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.RemoveAt(0);
        //}

        //private void FrmReport_Load(object sender, EventArgs e)
        //{
        //    this.LoadReportType();
        //}

        //private void LoadReportType()
        //{
        //    var listReport = new List<GeneralModel>
        //        {
        //            new GeneralModel { Id =(int) Report.SynthesysReport, Description = "Báo cáo tổng hợp"  },
        //            new GeneralModel { Id = (int) Report.ItemReport, Description = "Báo cáo doanh thu theo món ăn" },
        //            new GeneralModel { Id = (int) Report.ExportIdReport, Description = "Báo cáo doanh thu theo hóa đơn" },
        //            new GeneralModel { Id = (int) Report.DateReport, Description = "Báo cáo doanh thu theo ngày" }
        //        };

        //    this.glkReportType.Properties.DataSource = listReport;
        //    this.glkReportType.Properties.DisplayMember = "Description";
        //    this.glkReportType.Properties.ValueMember = "Id";
        //}

        //private GridControl InitializeGridControlTemplate(int reportType)
        //{
        //    var gridControl = new GridControl();

        //    switch (reportType)
        //    {
        //        case (int)Report.SynthesysReport:

        //              GridView view = new GridView(gridControl);
        //             var name=new GridColumn();
        //            name.Caption = "Mục";
        //            name.FieldName = "Name";
                   
        //             var totalTable = new GridColumn();
        //             totalTable.Caption = "SL";
        //             totalTable.FieldName = "TotalTable";
                    

        //             var totalMoney = new GridColumn();

        //             totalMoney.Caption = "Số tiền";
        //             totalMoney.FieldName = "TotalMoney";
        //            totalMoney.DisplayFormat.FormatType = FormatType.Custom;
        //            totalMoney.DisplayFormat.FormatString = "{0:N0}";
        //            view.Columns.Add(name);
        //            view.Columns.Add(totalTable);
        //            view.Columns.Add(totalMoney);
        //            view.Columns["Name"].Visible = true;
        //            view.Columns["TotalTable"].Visible = true;
        //            view.Columns["TotalMoney"].Visible = true;


        //            view.Columns["TotalTable"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "TotalTable", "Tổng={0:N0}");
        //            view.Columns["TotalMoney"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "TotalMoney", "Tổng={0:N0}");
        //            view.OptionsView.ShowFooter = true;
        //              gridControl.MainView = view;
                 
        //              gridControl.Dock = DockStyle.Fill;

        //            break;
        //        case (int)Report.ItemReport:
        //                     GridView view1 = new GridView(gridControl);
        //             var name1=new GridColumn();
        //            name1.Caption = "Tên sản phẩm";
        //            name1.FieldName = "ItemName";
                  
        //             var totalTable1 = new GridColumn();
        //             totalTable1.Caption = "Số lượng";
        //             totalTable1.FieldName = "Quantity";
                     

        //             var totalMoney1 = new GridColumn();

        //             totalMoney1.Caption = "Số tiền";
        //             totalMoney1.FieldName = "Total";
                    
        //            totalMoney1.DisplayFormat.FormatType = FormatType.Custom;
        //            totalMoney1.DisplayFormat.FormatString = "{0:N0}";

        //            view1.Columns.Add(name1);
        //            view1.Columns.Add(totalTable1);
        //            view1.Columns.Add(totalMoney1);
        //            view1.Columns["ItemName"].Visible = true;
        //            view1.Columns["Quantity"].Visible = true;
        //            view1.Columns["Total"].Visible = true;

        //            view1.Columns["Quantity"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Quantity", "Tổng={0:N0}");
        //            view1.Columns["Total"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Tổng={0:N0}");
        //            view1.OptionsView.ShowFooter = true;
        //              gridControl.MainView = view1;
                      
        //              gridControl.Dock = DockStyle.Fill;
        //            break;
        //        case (int)Report.ExportIdReport:

        //                GridView view2 = new GridView(gridControl);
        //             var exportId=new GridColumn();
        //             exportId.Caption = "Mã HD";
        //             exportId.FieldName = "ExportId";
                    
        //             var areaName = new GridColumn();
        //             areaName.Caption = "Khu vực";
        //             areaName.FieldName = "AreaName";
                 
              
                    
        //             var tableName = new GridColumn();
        //             tableName.Caption = "Bàn";
        //             tableName.FieldName = "TableName";
                    
        //             var dateCreate = new GridColumn();
        //             dateCreate.Caption = "Ngày lập HD";
        //             dateCreate.FieldName = "DateCreate";
                     
        //             dateCreate.DisplayFormat.FormatType = FormatType.Custom;
        //             dateCreate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
                


        //             var total1 = new GridColumn();

        //             total1.Caption = "Tổng cộng";
        //             total1.FieldName = "Total";
                     
        //             total1.DisplayFormat.FormatType = FormatType.Custom;
        //             total1.DisplayFormat.FormatString = "{0:N0}";

        //            var service1 = new GridColumn();

        //            service1.Caption = "Phí dịch vụ";
        //            service1.FieldName = "Service";
                    
        //            service1.DisplayFormat.FormatType = FormatType.Custom;
        //            service1.DisplayFormat.FormatString = "{0:N0}";

        //            var vat = new GridColumn();

        //            vat.Caption = "Thuế";
        //            vat.FieldName = "Vat";
                    
        //            vat.DisplayFormat.FormatType = FormatType.Custom;
        //            vat.DisplayFormat.FormatString = "{0:N0}";

        //             var itemDiscount = new GridColumn();

        //            itemDiscount.Caption = "Giảm theo SP";
        //            itemDiscount.FieldName = "ItemDiscount";
                    
        //            itemDiscount.DisplayFormat.FormatType = FormatType.Custom;
        //            itemDiscount.DisplayFormat.FormatString = "{0:N0}";

        //             var tableDiscount = new GridColumn();

        //             tableDiscount.Caption = "Giảm theo bàn";
        //             tableDiscount.FieldName = "TableDiscount";
                     
        //             tableDiscount.DisplayFormat.FormatType = FormatType.Custom;
        //             tableDiscount.DisplayFormat.FormatString = "{0:N0}";


        //             var finalTotal = new GridColumn();

        //             finalTotal.Caption = "Tiền phải trả";
        //             finalTotal.FieldName = "FinalTotal";
                     
        //             finalTotal.DisplayFormat.FormatType = FormatType.Custom;
        //             finalTotal.DisplayFormat.FormatString = "{0:N0}";

        //            view2.Columns.Add(exportId);
        //            view2.Columns.Add(areaName);
        //            view2.Columns.Add(tableName);
        //            view2.Columns.Add(total1);
        //            view2.Columns.Add(service1);
        //            view2.Columns.Add(vat);
        //            view2.Columns.Add(itemDiscount);
        //            view2.Columns.Add(tableDiscount);
        //            view2.Columns.Add(finalTotal);
        //            view2.Columns.Add(dateCreate);


        //            view2.Columns["ExportId"].Visible = true;
        //            view2.Columns["AreaName"].Visible = true;
        //            view2.Columns["TableName"].Visible = true;
        //            view2.Columns["DateCreate"].Visible = true;
        //            view2.Columns["Total"].Visible = true;
        //            view2.Columns["Service"].Visible = true;
        //            view2.Columns["Vat"].Visible = true;
        //            view2.Columns["TableDiscount"].Visible = true;
        //            view2.Columns["ItemDiscount"].Visible = true;
                 
        //            view2.Columns["FinalTotal"].Visible = true;

        //            view2.Columns["Total"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Tổng={0:N0}");
        //            view2.Columns["Service"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Service", "Tổng={0:N0}");
        //            view2.Columns["Vat"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Vat", "Tổng={0:N0}");
        //            view2.Columns["TableDiscount"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "TableDiscount", "Tổng={0:N0}");
        //            view2.Columns["ItemDiscount"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "ItemDiscount", "Tổng={0:N0}");
        //            view2.Columns["FinalTotal"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "FinalTotal", "Tổng={0:N0}");


        //            view2.OptionsView.ShowFooter = true;

        //            gridControl.MainView = view2;
                    
                    
        //              gridControl.Dock = DockStyle.Fill;
        //            break;
        //        case (int)Report.DateReport:
        //               GridView view3 = new GridView(gridControl);
        //             var date=new GridColumn();
        //             date.Caption = "Ngày lập HD";
        //             date.FieldName = "Date";
                 
        //             date.DisplayFormat.FormatType = FormatType.Custom;
        //             date.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";

        //             var quantity = new GridColumn();
        //             quantity.Caption = "Số lượng";
        //             quantity.FieldName = "Quantity";
                  
                    

        //             var total = new GridColumn();

        //             total.Caption = "Số tiền";
        //             total.FieldName = "Total";
                   
        //             total.DisplayFormat.FormatType = FormatType.Custom;
        //             total.DisplayFormat.FormatString = "{0:N0}";
        //            view3.Columns.Add(date);
        //            view3.Columns.Add(quantity);
        //            view3.Columns.Add(total);
        //            view3.Columns["Date"].Visible = true;
        //            view3.Columns["Quantity"].Visible = true;
        //            view3.Columns["Total"].Visible = true;

        //            view3.Columns["Quantity"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Quantity", "Tổng={0:N0}");
        //            view3.Columns["Total"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Tổng={0:N0}");


                
        //            view3.OptionsView.ShowFooter = true;
        //              gridControl.MainView = view3;
                      
        //              gridControl.Dock = DockStyle.Fill;
        //            break;


        //    }
            
        //    return gridControl;
        //}
    }
}
