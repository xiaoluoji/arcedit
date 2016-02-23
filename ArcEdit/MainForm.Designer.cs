namespace ArcEdit
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabctrMainform = new System.Windows.Forms.TabControl();
            this.tabPageArcedit = new System.Windows.Forms.TabPage();
            this.tabPageSysconfig = new System.Windows.Forms.TabPage();
            this.gbxPubDatabaseSet = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxPubTablePrename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPubPort = new System.Windows.Forms.TextBox();
            this.tboxPubHostName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxPubDbName = new System.Windows.Forms.TextBox();
            this.tboxPubUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxPubPassword = new System.Windows.Forms.TextBox();
            this.cboxPubCharset = new System.Windows.Forms.ComboBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.gbxCoDatabaseSet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxCoPort = new System.Windows.Forms.TextBox();
            this.tboxCoHostName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCoDbName = new System.Windows.Forms.TextBox();
            this.tboxCoUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxCoPassword = new System.Windows.Forms.TextBox();
            this.cboxCoCharset = new System.Windows.Forms.ComboBox();
            this.tabctrMainform.SuspendLayout();
            this.tabPageSysconfig.SuspendLayout();
            this.gbxPubDatabaseSet.SuspendLayout();
            this.gbxCoDatabaseSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrMainform
            // 
            this.tabctrMainform.Controls.Add(this.tabPageArcedit);
            this.tabctrMainform.Controls.Add(this.tabPageSysconfig);
            this.tabctrMainform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrMainform.Location = new System.Drawing.Point(0, 0);
            this.tabctrMainform.Name = "tabctrMainform";
            this.tabctrMainform.SelectedIndex = 0;
            this.tabctrMainform.Size = new System.Drawing.Size(1262, 818);
            this.tabctrMainform.TabIndex = 0;
            // 
            // tabPageArcedit
            // 
            this.tabPageArcedit.Location = new System.Drawing.Point(4, 28);
            this.tabPageArcedit.Name = "tabPageArcedit";
            this.tabPageArcedit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArcedit.Size = new System.Drawing.Size(1254, 786);
            this.tabPageArcedit.TabIndex = 0;
            this.tabPageArcedit.Text = "内容编辑发布";
            this.tabPageArcedit.UseVisualStyleBackColor = true;
            // 
            // tabPageSysconfig
            // 
            this.tabPageSysconfig.Controls.Add(this.gbxPubDatabaseSet);
            this.tabPageSysconfig.Controls.Add(this.btnSaveConfig);
            this.tabPageSysconfig.Controls.Add(this.gbxCoDatabaseSet);
            this.tabPageSysconfig.Location = new System.Drawing.Point(4, 28);
            this.tabPageSysconfig.Name = "tabPageSysconfig";
            this.tabPageSysconfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSysconfig.Size = new System.Drawing.Size(1254, 786);
            this.tabPageSysconfig.TabIndex = 1;
            this.tabPageSysconfig.Text = "系统配置";
            this.tabPageSysconfig.UseVisualStyleBackColor = true;
            // 
            // gbxPubDatabaseSet
            // 
            this.gbxPubDatabaseSet.Controls.Add(this.label13);
            this.gbxPubDatabaseSet.Controls.Add(this.tboxPubTablePrename);
            this.gbxPubDatabaseSet.Controls.Add(this.label5);
            this.gbxPubDatabaseSet.Controls.Add(this.tboxPubPort);
            this.gbxPubDatabaseSet.Controls.Add(this.tboxPubHostName);
            this.gbxPubDatabaseSet.Controls.Add(this.label7);
            this.gbxPubDatabaseSet.Controls.Add(this.label9);
            this.gbxPubDatabaseSet.Controls.Add(this.tboxPubDbName);
            this.gbxPubDatabaseSet.Controls.Add(this.tboxPubUserName);
            this.gbxPubDatabaseSet.Controls.Add(this.label10);
            this.gbxPubDatabaseSet.Controls.Add(this.label11);
            this.gbxPubDatabaseSet.Controls.Add(this.label12);
            this.gbxPubDatabaseSet.Controls.Add(this.tboxPubPassword);
            this.gbxPubDatabaseSet.Controls.Add(this.cboxPubCharset);
            this.gbxPubDatabaseSet.Location = new System.Drawing.Point(17, 203);
            this.gbxPubDatabaseSet.Name = "gbxPubDatabaseSet";
            this.gbxPubDatabaseSet.Size = new System.Drawing.Size(991, 162);
            this.gbxPubDatabaseSet.TabIndex = 40;
            this.gbxPubDatabaseSet.TabStop = false;
            this.gbxPubDatabaseSet.Text = "发布数据库设置(CMS数据库)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(657, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "CMS数据表前缀:";
            // 
            // tboxPubTablePrename
            // 
            this.tboxPubTablePrename.Location = new System.Drawing.Point(803, 32);
            this.tboxPubTablePrename.Name = "tboxPubTablePrename";
            this.tboxPubTablePrename.Size = new System.Drawing.Size(166, 28);
            this.tboxPubTablePrename.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mysql HostName:";
            // 
            // tboxPubPort
            // 
            this.tboxPubPort.Location = new System.Drawing.Point(471, 107);
            this.tboxPubPort.Name = "tboxPubPort";
            this.tboxPubPort.Size = new System.Drawing.Size(166, 28);
            this.tboxPubPort.TabIndex = 35;
            this.tboxPubPort.Text = "3306";
            // 
            // tboxPubHostName
            // 
            this.tboxPubHostName.Location = new System.Drawing.Point(155, 34);
            this.tboxPubHostName.Name = "tboxPubHostName";
            this.tboxPubHostName.Size = new System.Drawing.Size(166, 28);
            this.tboxPubHostName.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mysql Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mysql UserName:";
            // 
            // tboxPubDbName
            // 
            this.tboxPubDbName.Location = new System.Drawing.Point(155, 107);
            this.tboxPubDbName.Name = "tboxPubDbName";
            this.tboxPubDbName.Size = new System.Drawing.Size(166, 28);
            this.tboxPubDbName.TabIndex = 31;
            // 
            // tboxPubUserName
            // 
            this.tboxPubUserName.Location = new System.Drawing.Point(155, 68);
            this.tboxPubUserName.Name = "tboxPubUserName";
            this.tboxPubUserName.Size = new System.Drawing.Size(166, 28);
            this.tboxPubUserName.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mysql DbName:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mysql Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mysql Charset:";
            // 
            // tboxPubPassword
            // 
            this.tboxPubPassword.Location = new System.Drawing.Point(471, 68);
            this.tboxPubPassword.Name = "tboxPubPassword";
            this.tboxPubPassword.Size = new System.Drawing.Size(166, 28);
            this.tboxPubPassword.TabIndex = 27;
            // 
            // cboxPubCharset
            // 
            this.cboxPubCharset.FormattingEnabled = true;
            this.cboxPubCharset.Items.AddRange(new object[] {
            "utf8",
            "gb2312"});
            this.cboxPubCharset.Location = new System.Drawing.Point(471, 34);
            this.cboxPubCharset.Name = "cboxPubCharset";
            this.cboxPubCharset.Size = new System.Drawing.Size(166, 26);
            this.cboxPubCharset.TabIndex = 28;
            this.cboxPubCharset.Text = "utf8";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(1085, 703);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(129, 36);
            this.btnSaveConfig.TabIndex = 39;
            this.btnSaveConfig.Text = "保存配置";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // gbxCoDatabaseSet
            // 
            this.gbxCoDatabaseSet.Controls.Add(this.label1);
            this.gbxCoDatabaseSet.Controls.Add(this.tboxCoPort);
            this.gbxCoDatabaseSet.Controls.Add(this.tboxCoHostName);
            this.gbxCoDatabaseSet.Controls.Add(this.label8);
            this.gbxCoDatabaseSet.Controls.Add(this.label2);
            this.gbxCoDatabaseSet.Controls.Add(this.tboxCoDbName);
            this.gbxCoDatabaseSet.Controls.Add(this.tboxCoUserName);
            this.gbxCoDatabaseSet.Controls.Add(this.label6);
            this.gbxCoDatabaseSet.Controls.Add(this.label3);
            this.gbxCoDatabaseSet.Controls.Add(this.label4);
            this.gbxCoDatabaseSet.Controls.Add(this.tboxCoPassword);
            this.gbxCoDatabaseSet.Controls.Add(this.cboxCoCharset);
            this.gbxCoDatabaseSet.Location = new System.Drawing.Point(17, 16);
            this.gbxCoDatabaseSet.Name = "gbxCoDatabaseSet";
            this.gbxCoDatabaseSet.Size = new System.Drawing.Size(651, 162);
            this.gbxCoDatabaseSet.TabIndex = 38;
            this.gbxCoDatabaseSet.TabStop = false;
            this.gbxCoDatabaseSet.Text = "采集数据库设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mysql HostName:";
            // 
            // tboxCoPort
            // 
            this.tboxCoPort.Location = new System.Drawing.Point(471, 107);
            this.tboxCoPort.Name = "tboxCoPort";
            this.tboxCoPort.Size = new System.Drawing.Size(166, 28);
            this.tboxCoPort.TabIndex = 35;
            this.tboxCoPort.Text = "3306";
            // 
            // tboxCoHostName
            // 
            this.tboxCoHostName.Location = new System.Drawing.Point(155, 34);
            this.tboxCoHostName.Name = "tboxCoHostName";
            this.tboxCoHostName.Size = new System.Drawing.Size(166, 28);
            this.tboxCoHostName.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mysql Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mysql UserName:";
            // 
            // tboxCoDbName
            // 
            this.tboxCoDbName.Location = new System.Drawing.Point(155, 107);
            this.tboxCoDbName.Name = "tboxCoDbName";
            this.tboxCoDbName.Size = new System.Drawing.Size(166, 28);
            this.tboxCoDbName.TabIndex = 31;
            // 
            // tboxCoUserName
            // 
            this.tboxCoUserName.Location = new System.Drawing.Point(155, 68);
            this.tboxCoUserName.Name = "tboxCoUserName";
            this.tboxCoUserName.Size = new System.Drawing.Size(166, 28);
            this.tboxCoUserName.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mysql DbName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mysql Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mysql Charset:";
            // 
            // tboxCoPassword
            // 
            this.tboxCoPassword.Location = new System.Drawing.Point(471, 68);
            this.tboxCoPassword.Name = "tboxCoPassword";
            this.tboxCoPassword.Size = new System.Drawing.Size(166, 28);
            this.tboxCoPassword.TabIndex = 27;
            // 
            // cboxCoCharset
            // 
            this.cboxCoCharset.FormattingEnabled = true;
            this.cboxCoCharset.Items.AddRange(new object[] {
            "utf8",
            "gb2312"});
            this.cboxCoCharset.Location = new System.Drawing.Point(471, 34);
            this.cboxCoCharset.Name = "cboxCoCharset";
            this.cboxCoCharset.Size = new System.Drawing.Size(166, 26);
            this.cboxCoCharset.TabIndex = 28;
            this.cboxCoCharset.Text = "utf8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 818);
            this.Controls.Add(this.tabctrMainform);
            this.Name = "MainForm";
            this.Text = "文章编辑";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabctrMainform.ResumeLayout(false);
            this.tabPageSysconfig.ResumeLayout(false);
            this.gbxPubDatabaseSet.ResumeLayout(false);
            this.gbxPubDatabaseSet.PerformLayout();
            this.gbxCoDatabaseSet.ResumeLayout(false);
            this.gbxCoDatabaseSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageArcedit;
        private System.Windows.Forms.TabPage tabPageSysconfig;
        private System.Windows.Forms.TabControl tabctrMainform;
        private System.Windows.Forms.GroupBox gbxPubDatabaseSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tboxPubTablePrename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPubPort;
        private System.Windows.Forms.TextBox tboxPubHostName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxPubDbName;
        private System.Windows.Forms.TextBox tboxPubUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tboxPubPassword;
        private System.Windows.Forms.ComboBox cboxPubCharset;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox gbxCoDatabaseSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxCoPort;
        private System.Windows.Forms.TextBox tboxCoHostName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxCoDbName;
        private System.Windows.Forms.TextBox tboxCoUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxCoPassword;
        private System.Windows.Forms.ComboBox cboxCoCharset;
    }
}

