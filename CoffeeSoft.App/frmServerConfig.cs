using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeSoft.App
{
    public partial class frmServerConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmServerConfig()
        {
            InitializeComponent();
        }

        private void frmServerConfig_Load(object sender, EventArgs e)
        {
            this.ListSqlServers();
        }
        private void ListSqlServers()
        {
            try
            {
                string myServer = Environment.MachineName;
                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();



                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    // Remove the following 'if' condition 
                    // to list the servers of local machine
                    // along with network servers


                    // used to get the servers in the local machine 
                    if (myServer == servers.Rows[i]["ServerName"].ToString())
                    {
                        if ((servers.Rows[i]["InstanceName"] as string) != null)
                            cboServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        else
                            cboServer.Items.Add(servers.Rows[i]["ServerName"]);
                    }
                }
                if (cboServer.Items.Count > 0)
                {
                    cboServer.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                    
                
            }
            
        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection SqlCon = new System.Data.SqlClient.SqlConnection("server=" + cboDatabase.Text + ";integrated security=true");
                SqlCon.Open();

                SqlCommand SqlCom = new System.Data.SqlClient.SqlCommand();
                SqlCom.Connection = SqlCon;
                SqlCom.CommandType = CommandType.StoredProcedure;
                SqlCom.CommandText = "sp_databases";

                System.Data.SqlClient.SqlDataReader SqlDR;
                SqlDR = SqlCom.ExecuteReader();

                while (SqlDR.Read())
                {
                    cboDatabase.Items.Add(SqlDR.GetString(0));
                }
            }
            catch (Exception)
            {
                    
                
            }
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {



                //string temp = General.general.GetStartupPath();

                //int cut = Directory.GetParent(General.general.GetStartupPath()).Parent.ToString().Length+1;
                //var path = General.general.GetStartupPath().Substring(0,temp.Length-cut)+"\\app.config";

                var path = General.general.GetStartupPath() + "app.config";
                var xdoc = XDocument.Load(path);
                var list1 = from appNode in xdoc.Descendants("connectionStrings").Elements()
                            where appNode.Attribute("name").Value == "dbConnectionString"
                            select appNode;
                var list2 = from appNode in xdoc.Descendants("connectionStrings").Elements()
                            where appNode.Attribute("name").Value == "CafeSoftwareManagement.Properties.Settings.CAFEDBConnectionString"
                            select appNode;
                var appPath = from appNode in xdoc.Descendants("appSettings").Elements()
                              where appNode.Attribute("key").Value == "AppConfigPath"
                              select appNode;

                var appPathElement = appPath.FirstOrDefault();

                var element1 = list1.FirstOrDefault();
                var element2 = list2.FirstOrDefault();

                element1.Attribute("connectionString").SetValue("server =" + cboServer.Text + "; Database = " + cboDatabase.Text + "; integrated security = true;");
                element2.Attribute("connectionString").SetValue("Data Source=" + cboServer.Text + ";Initial Catalog=" + cboDatabase.Text + ";Integrated Security=True");

                appPathElement.Attribute("value").SetValue(path);


                xdoc.Save(path);
                MessageBox.Show("Lưu cấu hình thành công", "Thông báo");
                this.Close();

            }
            catch (Exception)
            {
                
                
            }
            


        }
    }
}
