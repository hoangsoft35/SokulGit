namespace CoffeeSoft.App
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        //private IServices service;
        //public frmBackup()
        //{
        //    InitializeComponent();
        //    service=new Services();
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
           
        //    try
        //    {
        //        saveFileDialog1.Filter = "Backup Files (*.bak)|*.bak";
        //        saveFileDialog1.ShowDialog();
        //        txtfilename.Text = saveFileDialog1.FileName;

        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Backup Database");
        //        return;
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}
        //private void ListSqlServers()
        //{
        //    try
        //    {
        //        string myServer = Environment.MachineName;
        //        DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();



        //        for (int i = 0; i < servers.Rows.Count; i++)
        //        {
        //            // Remove the following 'if' condition 
        //            // to list the servers of local machine
        //            // along with network servers


        //            // used to get the servers in the local machine 
        //            if (myServer == servers.Rows[i]["ServerName"].ToString())
        //            {
        //                if ((servers.Rows[i]["InstanceName"] as string) != null)
        //                    cboServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
        //                else
        //                    cboServer.Items.Add(servers.Rows[i]["ServerName"]);
        //            }
        //        }
        //        if (cboServer.Items.Count > 0)
        //        {
        //            cboServer.SelectedIndex = 0;
        //        }
        //    }
        //    catch (Exception)
        //    {


        //    }

        //}

        //private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection SqlCon = new System.Data.SqlClient.SqlConnection("server=" + cboDatabase.Text + ";integrated security=true");
        //        SqlCon.Open();

        //        SqlCommand SqlCom = new System.Data.SqlClient.SqlCommand();
        //        SqlCom.Connection = SqlCon;
        //        SqlCom.CommandType = CommandType.StoredProcedure;
        //        SqlCom.CommandText = "sp_databases";

        //        System.Data.SqlClient.SqlDataReader SqlDR;
        //        SqlDR = SqlCom.ExecuteReader();

        //        while (SqlDR.Read())
        //        {
        //            cboDatabase.Items.Add(SqlDR.GetString(0));
        //        }
        //    }
        //    catch (Exception)
        //    {


        //    }
         
        //}

        //private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void frmBackup_Load(object sender, EventArgs e)
        //{
        //    this.ListSqlServers();


           
        //    var path = General.general.GetStartupPath() + "app.config";
        //    var xdoc = XDocument.Load(path);
        //    var IsAuto = from appNode in xdoc.Descendants("appSettings").Elements()
        //                where appNode.Attribute("key").Value == "IsAutoRun"
        //                select appNode;
        //    var Hour = from appNode in xdoc.Descendants("appSettings").Elements()
        //                where appNode.Attribute("key").Value == "Hour"
        //                select appNode;

        //    var Minute = from appNode in xdoc.Descendants("appSettings").Elements()
        //                where appNode.Attribute("key").Value == "Minute"
        //                select appNode;
        //    var browseBackup = from appNode in xdoc.Descendants("appSettings").Elements()
        //                 where appNode.Attribute("key").Value == "BrowseBackup"
        //                 select appNode;

        //    var isAutoElement = IsAuto.FirstOrDefault();
        //    var hourElement = Hour.FirstOrDefault();
        //    var minuteElement = Minute.FirstOrDefault();
        //    var browseBackupElement = browseBackup.FirstOrDefault();

        //    if (isAutoElement.Attribute("value").Value=="true")
        //    {
        //        chkAuto.Checked = true;
        //    }
        //    else
        //    {
        //        chkAuto.Checked = false;
        //    }

        //    txtHour.Text = hourElement.Attribute("value").Value;
        //    txtMinute.Text = minuteElement.Attribute("value").Value;

        //    txtfilename.Text = browseBackupElement.Attribute("value").Value;
         

        //}

      
        //private void btnBackup_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        if (saveFileDialog1.FileName==""||cboDatabase.Text=="")
        //        {
        //            MessageBox.Show("Chọn đường dẫn và database trước khi tiến hành sao lưu dữ liệu", "Thông báo");
        //            return;
        //        }

        //        if (chkAuto.Checked && txtHour.Text!="" &&txtMinute.Text!="")
        //        {
        //            if (int.Parse(txtHour.Text) < 0 || int.Parse(txtHour.Text) > 24 || int.Parse(txtMinute.Text) < 0 || int.Parse(txtMinute.Text)>60)
        //            {
        //                MessageBox.Show("Giờ chỉ được nhập từ 0 - 24 phút chỉ được nhập tử 0 - 60!", "Thông báo");
        //                return;
        //            }
        //        }


        //        var path = General.general.GetStartupPath()+"app.config";
        //        var xdoc = XDocument.Load(path);
        //        var IsAuto = from appNode in xdoc.Descendants("appSettings").Elements()
        //                     where appNode.Attribute("key").Value == "IsAutoRun"
        //                     select appNode;
        //        var Hour = from appNode in xdoc.Descendants("appSettings").Elements()
        //                   where appNode.Attribute("key").Value == "Hour"
        //                   select appNode;

        //        var Minute = from appNode in xdoc.Descendants("appSettings").Elements()
        //                     where appNode.Attribute("key").Value == "Minute"
        //                     select appNode;
        //        var browseBackup = from appNode in xdoc.Descendants("appSettings").Elements()
        //                           where appNode.Attribute("key").Value == "BrowseBackup"
        //                           select appNode;

        //        var appPath = from appNode in xdoc.Descendants("appSettings").Elements()
        //                      where appNode.Attribute("key").Value == "AppConfigPath"
        //                           select appNode;

        //        var appPathElement = appPath.FirstOrDefault();


        //        var isAutoElement = IsAuto.FirstOrDefault();
        //        var hourElement = Hour.FirstOrDefault();
        //        var minuteElement = Minute.FirstOrDefault();
        //        var browseBackupElement = browseBackup.FirstOrDefault();

        //        if (chkAuto.Checked)
        //        {
        //            isAutoElement.Attribute("value").SetValue("true");
        //        }
        //        else
           
        //        {
        //            isAutoElement.Attribute("value").SetValue("false");
        //        }



        //        hourElement.Attribute("value").SetValue(txtHour.Text.Trim());
        //        minuteElement.Attribute("value").SetValue(txtMinute.Text.Trim());
        //        FileInfo file=new FileInfo(txtfilename.Text);
        //        browseBackupElement.Attribute("value").SetValue(file.DirectoryName);

        //        appPathElement.Attribute("value").SetValue(path);


        //        xdoc.Save(path);






        //        string sqlBackup = "BACKUP DATABASE ["+cboDatabase.Text+"] TO DISK='" + saveFileDialog1.FileName + "'";

        //        if (service.Backup(sqlBackup))
        //        {
        //            MessageBox.Show("Đã backup cơ sở dữ liệu thành công");
        //            return;
        //        }
        //        MessageBox.Show("Backup cơ sở dữ liệu không thành công");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Backup Database");
        //        return;
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}

        //private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar)
        //&& !char.IsDigit(e.KeyChar)
        //&& e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtMinute_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar)
        //&& !char.IsDigit(e.KeyChar)
        //&& e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}