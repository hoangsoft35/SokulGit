namespace CoffeeSoft.App
{
    partial class frmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
        //    this.btnSave = new DevExpress.XtraEditors.SimpleButton();
        //    this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        //    this.cboDatabase = new System.Windows.Forms.ComboBox();
        //    this.label2 = new System.Windows.Forms.Label();
        //    this.cboServer = new System.Windows.Forms.ComboBox();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.label3 = new System.Windows.Forms.Label();
        //    this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
        //    this.txtfilename = new System.Windows.Forms.TextBox();
        //    this.chkAuto = new System.Windows.Forms.CheckBox();
        //    this.txtHour = new System.Windows.Forms.TextBox();
        //    this.txtMinute = new System.Windows.Forms.TextBox();
        //    this.label4 = new System.Windows.Forms.Label();
        //    this.label5 = new System.Windows.Forms.Label();
        //    this.SuspendLayout();
        //    // 
        //    // btnSave
        //    // 
        //    this.btnSave.Location = new System.Drawing.Point(170, 72);
        //    this.btnSave.Name = "btnSave";
        //    this.btnSave.Size = new System.Drawing.Size(95, 29);
        //    this.btnSave.TabIndex = 0;
        //    this.btnSave.Text = "Chọn";
        //    this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        //    // 
        //    // cboDatabase
        //    // 
        //    this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        //    this.cboDatabase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.cboDatabase.FormattingEnabled = true;
        //    this.cboDatabase.Location = new System.Drawing.Point(139, 42);
        //    this.cboDatabase.Name = "cboDatabase";
        //    this.cboDatabase.Size = new System.Drawing.Size(309, 24);
        //    this.cboDatabase.TabIndex = 8;
        //    this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
        //    // 
        //    // label2
        //    // 
        //    this.label2.AutoSize = true;
        //    this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label2.Location = new System.Drawing.Point(4, 45);
        //    this.label2.Name = "label2";
        //    this.label2.Size = new System.Drawing.Size(115, 16);
        //    this.label2.TabIndex = 7;
        //    this.label2.Text = "Chọn Database :";
        //    // 
        //    // cboServer
        //    // 
        //    this.cboServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        //    this.cboServer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.cboServer.FormattingEnabled = true;
        //    this.cboServer.Location = new System.Drawing.Point(139, 12);
        //    this.cboServer.Name = "cboServer";
        //    this.cboServer.Size = new System.Drawing.Size(309, 24);
        //    this.cboServer.TabIndex = 6;
        //    this.cboServer.SelectedIndexChanged += new System.EventHandler(this.cboServer_SelectedIndexChanged);
        //    // 
        //    // label1
        //    // 
        //    this.label1.AutoSize = true;
        //    this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label1.Location = new System.Drawing.Point(4, 15);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(135, 16);
        //    this.label1.TabIndex = 5;
        //    this.label1.Text = "Chọn server name :";
        //    // 
        //    // label3
        //    // 
        //    this.label3.AutoSize = true;
        //    this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label3.Location = new System.Drawing.Point(4, 79);
        //    this.label3.Name = "label3";
        //    this.label3.Size = new System.Drawing.Size(160, 16);
        //    this.label3.TabIndex = 9;
        //    this.label3.Text = "Chọn đường dẫn lưu file";
        //    // 
        //    // btnBackup
        //    // 
        //    this.btnBackup.Location = new System.Drawing.Point(170, 228);
        //    this.btnBackup.Name = "btnBackup";
        //    this.btnBackup.Size = new System.Drawing.Size(140, 55);
        //    this.btnBackup.TabIndex = 10;
        //    this.btnBackup.Text = "Sao lưu dữ liệu";
        //    this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
        //    // 
        //    // txtfilename
        //    // 
        //    this.txtfilename.Enabled = false;
        //    this.txtfilename.Location = new System.Drawing.Point(7, 107);
        //    this.txtfilename.Multiline = true;
        //    this.txtfilename.Name = "txtfilename";
        //    this.txtfilename.Size = new System.Drawing.Size(441, 65);
        //    this.txtfilename.TabIndex = 11;
        //    // 
        //    // chkAuto
        //    // 
        //    this.chkAuto.AutoSize = true;
        //    this.chkAuto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.chkAuto.Location = new System.Drawing.Point(7, 178);
        //    this.chkAuto.Name = "chkAuto";
        //    this.chkAuto.Size = new System.Drawing.Size(186, 20);
        //    this.chkAuto.TabIndex = 12;
        //    this.chkAuto.Text = "Tự động chạy hằng ngày";
        //    this.chkAuto.UseVisualStyleBackColor = true;
        //    // 
        //    // txtHour
        //    // 
        //    this.txtHour.Location = new System.Drawing.Point(198, 178);
        //    this.txtHour.Name = "txtHour";
        //    this.txtHour.Size = new System.Drawing.Size(40, 21);
        //    this.txtHour.TabIndex = 13;
        //    this.txtHour.Text = "0";
        //    this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        //    this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHour_KeyPress);
        //    // 
        //    // txtMinute
        //    // 
        //    this.txtMinute.Location = new System.Drawing.Point(334, 177);
        //    this.txtMinute.Name = "txtMinute";
        //    this.txtMinute.Size = new System.Drawing.Size(40, 21);
        //    this.txtMinute.TabIndex = 13;
        //    this.txtMinute.Text = "0";
        //    this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        //    this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinute_KeyPress);
        //    // 
        //    // label4
        //    // 
        //    this.label4.AutoSize = true;
        //    this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label4.Location = new System.Drawing.Point(239, 181);
        //    this.label4.Name = "label4";
        //    this.label4.Size = new System.Drawing.Size(77, 16);
        //    this.label4.TabIndex = 14;
        //    this.label4.Text = "Giờ(0 - 24)";
        //    // 
        //    // label5
        //    // 
        //    this.label5.AutoSize = true;
        //    this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label5.Location = new System.Drawing.Point(374, 180);
        //    this.label5.Name = "label5";
        //    this.label5.Size = new System.Drawing.Size(88, 16);
        //    this.label5.TabIndex = 15;
        //    this.label5.Text = "Phút(0 - 60)";
        //    // 
        //    // frmBackup
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(466, 336);
        //    this.Controls.Add(this.label5);
        //    this.Controls.Add(this.label4);
        //    this.Controls.Add(this.txtMinute);
        //    this.Controls.Add(this.txtHour);
        //    this.Controls.Add(this.chkAuto);
        //    this.Controls.Add(this.txtfilename);
        //    this.Controls.Add(this.btnBackup);
        //    this.Controls.Add(this.label3);
        //    this.Controls.Add(this.cboDatabase);
        //    this.Controls.Add(this.label2);
        //    this.Controls.Add(this.cboServer);
        //    this.Controls.Add(this.label1);
        //    this.Controls.Add(this.btnSave);
        //    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        //    this.Name = "frmBackup";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        //    this.Text = "Sao lưu dữ liệu";
        //    this.Load += new System.EventHandler(this.frmBackup_Load);
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        //#endregion

        //private DevExpress.XtraEditors.SimpleButton btnSave;
        //private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        //private System.Windows.Forms.ComboBox cboDatabase;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.ComboBox cboServer;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label3;
        //private DevExpress.XtraEditors.SimpleButton btnBackup;
        //private System.Windows.Forms.TextBox txtfilename;
        //private System.Windows.Forms.CheckBox chkAuto;
        //private System.Windows.Forms.TextBox txtHour;
        //private System.Windows.Forms.TextBox txtMinute;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Label label5;
    }
}