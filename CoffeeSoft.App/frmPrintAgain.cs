namespace CoffeeSoft.App
{
    public partial class frmPrintAgain : DevExpress.XtraEditors.XtraForm
    {
        //private IServices service;
        //public frmPrintAgain()
        //{
        //    InitializeComponent();
        //    service=new Services();
        
        //}

        //private void frmPrintAgain_Load(object sender, EventArgs e)
        //{
        //    dtpFrom.EditValue = DateTime.Now.Date;
        //    dtpTo.EditValue = DateTime.Now.Date;

        //}

        //int x = 0;
        //int y = 0;
        //private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    x = 0;
        //    y = 0;
        //    var font = new Font("Tahoma", 14);
        //    //draw title
        //    if (general.isTitlePrint)
        //    {

        //        e.Graphics.DrawString(general.titlePrint, font, Brushes.Black, new RectangleF(15, y, 210, 20));
        //    }

        //    // draw Name of bussiness
        //    if (general.isLogoTextPrint)
        //    {
        //        font = new Font("Tahoma", 38, FontStyle.Bold);
        //        y += 20;
        //        e.Graphics.DrawString("SOKUL", font, Brushes.Black, new RectangleF(0, y, 220, 95));
        //        y += 75;

        //    }

        //    //drawing logo
        //    Image i = Image.FromFile(general.GetStartupPath() + @"img\logo.png");
        //    if (general.isLogoImagePrint)
        //    {
        //        y += 20;

        //        Point p = new Point(0, y);
        //        e.Graphics.DrawImage(i, 0, y, i.Width + 10, i.Height);
        //        y += i.Height;
        //    }



        //    // drawing date
        //    font = new Font("Tahoma", 7);
        //    if (general.isDatePrint)
        //    {


        //        e.Graphics.DrawString(string.Format("{0:dd/MM/yyyy}", general.DateCreate), font, Brushes.Black, new RectangleF(65, y, 100, 15));
        //        y += 15;
        //    }

        //    // time in
        //    if (general.isTimeInPrint)
        //    {

        //        e.Graphics.DrawString(string.Format("{0:hh:mm tt}", general.DateCreate), font, Brushes.Black, new RectangleF(0, y, 110, 15));

        //    }

        //    // timeout
        //    if (general.isTimeOutPrint)
        //    {

        //        e.Graphics.DrawString(string.Format("{0:hh:mm tt}", general.DatePaid), font, Brushes.Black, new RectangleF(125, y, 100, 15));
        //        y += 15;
        //    }

        //    //draw table
        //    if (general.isTablePrint)
        //    {

        //        e.Graphics.DrawString("Bàn " + general.tableName + "(" + general.areaName + ")", font, Brushes.Black, new RectangleF(0, y, 130, 15));


        //    }
        //    //draw exportid
        //    if (general.isExportIdPrint)
        //    {

        //        e.Graphics.DrawString(general.ExportId, font, Brushes.Black, new RectangleF(125, y, 90, 15));
        //        y += 15;

        //    }


        //    // draw custumername

        //    //if (general.isCustomerPrint && txtNote.Text != "")
        //    //{

        //    //    e.Graphics.DrawString("Ghi chú : " + txtNote.Text, font, Brushes.Black, new RectangleF(0, y, 220, 15));
        //    //    y += 15;

        //    //}

        //    // draw title of grid
        //    font = new Font("Tahoma", 10);
        //    y += 20;
        //    e.Graphics.DrawString("Tên Món", font, Brushes.Black, new RectangleF(0, y, 110, 20));
        //    e.Graphics.DrawString("SL", font, Brushes.Black, new RectangleF(120, y, 125, 20));
        //    e.Graphics.DrawString("ĐGiá", font, Brushes.Black, new RectangleF(150, y, 125, 20));
        //    y += 10;
        //    e.Graphics.DrawString("--------------------------------------------", font, Brushes.Black, new RectangleF(0, y, 250, 20));

        //    y += 15;
        //    //draw item
        //    var entList = gridView2.DataSource as List<ExportDetailModel>;
        //    font = new Font("Tahoma", 7);
        //    foreach (var item in entList)
        //    {
        //        if (item.ItemName == "" || item.ItemName == null)
        //        {
        //            e.Graphics.DrawString("--------------------", font, Brushes.Black, new RectangleF(120, y - 5, 125, 15));
        //            y += 5;
        //            break;
        //        }
        //        e.Graphics.DrawString(item.ItemName, font, Brushes.Black, new RectangleF(0, y, 110, 15));
        //        e.Graphics.DrawString(item.Quantity.ToString(), font, Brushes.Black, new RectangleF(120, y, 125, 15));
        //        e.Graphics.DrawString(string.Format("{0:0,0}", item.CurrentPrice), font, Brushes.Black, new RectangleF(150, y, 125, 15));
        //        y += 15;

        //    }
        //    // draw total
        //    double total = 0;
        //    double totalPaid = 0;

        //    if (general.isTotalPrint)
        //    {
        //        foreach (var item in entList)
        //        {
        //            if (item.ItemName == "Tổng cộng")
        //            {
        //                e.Graphics.DrawString(item.ItemName, font, Brushes.Black, new RectangleF(0, y, 110, 15));
        //                e.Graphics.DrawString(string.Format("{0:0,0}", item.Total), font, Brushes.Black, new RectangleF(140, y, 125, 15));
        //                total = (double) item.Total;
        //                totalPaid = (double) item.Total;
        //                y += 15;
        //                break;
        //            }


        //        }
        //    }


        //    // draw discount
        //    if (general.isTotalDiscount)
        //    {
        //        foreach (var item1 in entList)
        //        {
        //            if (item1.ItemName == "Tiền thanh toán")
        //            {
        //                e.Graphics.DrawString(string.Format("-{0:0,0}", (total - (double) item1.Total)), font, Brushes.Black, new RectangleF(140, y, 125, 15));
        //                totalPaid = (double) ((total - (double) item1.Total) == 0 ? item1.Total : item1.Total);
        //                y += 15;
        //                break;
        //            }


        //        }
        //    }
            

        //    //draw total pay
        //    if (general.isTotalPayPrint)
        //    {
        //        e.Graphics.DrawString("---------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y - 5, 250, 10));
        //        y += 10;

        //        font = new Font("Tahoma", 8);
        //        e.Graphics.DrawString("Tiền thanh toán", font, Brushes.Black, new RectangleF(0, y, 110, 30));
        //        e.Graphics.DrawString(string.Format("{0:0,0} d", totalPaid), font, Brushes.Black, new RectangleF(120, y, 250, 30));
        //        y += 15;
        //    }


        //    if (general.isSayGoodByePrint)
        //    {
        //        y += 30;
        //        e.Graphics.DrawString(general.isSayGoodByeText1, font, Brushes.Black, new RectangleF(50, y, 250, 15));
        //        y += 15;
        //        e.Graphics.DrawString(general.isSayGoodByeText2, font, Brushes.Black, new RectangleF(65, y, 250, 250));
        //        y += 15;

        //    }

        //    if (general.isDiscountInfomationPrint)
        //    {
        //        y += 30;
        //        e.Graphics.DrawString(general.DiscountInfomationPrintTest, font, Brushes.Black, new RectangleF(0, y, 210, 1500));


        //    }

        //    // draw emply space

        //    y += 10;
        //    e.Graphics.DrawString(string.Format("\n{0}", "."), font, Brushes.LightGreen, new RectangleF(0, y, 120, 250));
        //}

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (gridView2.RowCount > 0)
        //        {


        //            if (MessageBox.Show("Bạn có muốn in lại hóa đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {

        //                printDocument1.PrinterSettings.PrinterName = general.PrinterBillName;
        //                printDocument1.Print();

        //                MessageBox.Show("In lại thành công");
        //            }
       
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Không tìm thấy máy in vui lòng kiểm tra lại phần cài đặt", "Thông báo");
        //        return;
        //    }


        //}

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{

        //}

        //private void gridView1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.BuildGridTotal(service.GetDetailExportByExportId(
        //       gridView1.GetFocusedRowCellValue("ExportId").ToString()));
        //        general.TableId =
        //           int.Parse(gridView1.GetFocusedRowCellValue("TableId").ToString());
        //        general.areaName =
        //         gridView1.GetFocusedRowCellValue("AreaId").ToString();
        //    }
        //    catch (Exception)
        //    {
                
                
        //    }
           


        //}
        //private ExportDetailModel item;

        //private DataRow row;
        //private void BuildGridTotal(List<ExportDetailModel> listExp)
        //{

        //    decimal totalDicount = 0;
        //    decimal totalService = 0;
        //    decimal totalVAT = 0;

        //    if (listExp != null && listExp.Count > 0)
        //    {
        //        decimal total = 0;
        //        foreach (var itement in listExp)
        //        {
        //            total += (decimal) itement.Total;
        //        }

        //        // empty row
        //        item = new ExportDetailModel();
        //        item.Quantity = 0;
        //        item.CurrentPrice = 0;
        //        item.ItemDiscount = 0;
        //        item.Total = 0;
        //        listExp.Add(item);

        //        // total row
        //        item = new ExportDetailModel();
        //        item.Total = (decimal) total;
        //        item.ItemName = "Tổng cộng";
        //        listExp.Add(item);

        //        // total row
        //        item = new ExportDetailModel();
        //        item.Total = -((total * ((ExportDetailModel)listExp[0]).TableDiscount) / 100);
        //        item.ItemDiscount =  listExp[0].TableDiscount;
        //        item.ItemName = "Giảm giá";
        //        listExp.Add(item);

        //        // thanh tien
        //        totalDicount = total - (total * ((ExportDetailModel)listExp[0]).TableDiscount) / 100;
        //        item = new ExportDetailModel();
        //        item.Total = totalDicount;
        //        item.ItemDiscount = 0;
        //        item.ItemName = "Thành tiền";
        //        listExp.Add(item);

        //        // service
        //        item = new ExportDetailModel();
        //        item.Total = ((total * ((ExportDetailModel)listExp[0]).Service) / 100);
        //        item.ItemDiscount =  listExp[0].Service;
        //        item.ItemName = "Phí phòng lạnh";
        //        listExp.Add(item);


        //        // thanh tien
        //        totalService = (totalDicount + (total * ((ExportDetailModel)listExp[0]).Service) / 100);
        //        item = new ExportDetailModel();
        //        item.Total = totalService;
        //        item.ItemDiscount = 0;
        //        item.ItemName = "Thành tiền";
        //        listExp.Add(item);

        //        // VAT
        //        item = new ExportDetailModel();
        //        item.Total = (decimal) ((total * ((ExportDetailModel)listExp[0]).Vat) / 100);
        //        item.ItemDiscount = listExp[0].Vat;
        //        item.ItemName = "VAT";
        //        listExp.Add(item);

        //        // thanh tien thanh toan
        //        totalVAT = (total + (total * listExp[0].Service) / 100
        //                    + (total * listExp[0].Vat) / 100)
        //                   - (total * listExp[0].TableDiscount) / 100;
        //        item = new ExportDetailModel();
        //        item.Total = (decimal) totalVAT;
        //        item.ItemDiscount = 0;
        //        item.ItemName = "Tiền thanh toán";
        //        listExp.Add(item);


             
        //        General.general.ExportId = listExp[0].ExportId;
        //        gridControl2.DataSource = listExp;
        //        gridView2.SelectRow(gridView2.RowCount);


        //        try
        //        {
        //            if (listExp.Any())
        //            {
        //                general.ExportId = listExp[0].ExportId;
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            return;
        //        }

        //        return;
        //    }
         
        //    gridControl2.DataSource = listExp;




        //}

        //private void btnExcute_Click(object sender, EventArgs e)
        //{

        //    gridControl1.DataSource = service.GetListExport(DateTime.Parse(dtpFrom.EditValue.ToString()), DateTime.Parse(dtpTo.EditValue.ToString()).Date, true);
        //    if (gridView1.DataRowCount>0)
        //    {

        //        this.BuildGridTotal(service.GetDetailExportByExportId(
        //        gridView1.GetFocusedRowCellValue("ExportId").ToString()));

        //        general.TableId =
        //            int.Parse(gridView1.GetFocusedRowCellValue("TableId").ToString());
        //        general.areaName =
        //         gridView1.GetFocusedRowCellValue("AreaName").ToString();
        //    }

        //}

    }
}