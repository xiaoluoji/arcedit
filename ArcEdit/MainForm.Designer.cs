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
            this.gboxArcList = new System.Windows.Forms.GroupBox();
            this.tboxDisplayArcCount = new System.Windows.Forms.TextBox();
            this.lblDisplayArcCount = new System.Windows.Forms.Label();
            this.btnSearchArcTitle = new System.Windows.Forms.Button();
            this.listViewArticles = new ArcDB.ListViewNF();
            this.arc_aid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arc_pic_counts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arc_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tboxSearchArcTitle = new System.Windows.Forms.TextBox();
            this.lblSearchArcTitle = new System.Windows.Forms.Label();
            this.gboxArcCategory = new System.Windows.Forms.GroupBox();
            this.btnSearchCoTypename = new System.Windows.Forms.Button();
            this.tboxSearchCoTypename = new System.Windows.Forms.TextBox();
            this.lblSearchCoTypename = new System.Windows.Forms.Label();
            this.listViewCoTypeinfo = new ArcDB.ListViewNF();
            this.co_typeid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.co_typename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.co_type_unused_nums = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabPageArcedit.SuspendLayout();
            this.gboxArcList.SuspendLayout();
            this.gboxArcCategory.SuspendLayout();
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
            this.tabctrMainform.Size = new System.Drawing.Size(1029, 968);
            this.tabctrMainform.TabIndex = 0;
            // 
            // tabPageArcedit
            // 
            this.tabPageArcedit.Controls.Add(this.gboxArcList);
            this.tabPageArcedit.Controls.Add(this.gboxArcCategory);
            this.tabPageArcedit.Location = new System.Drawing.Point(4, 28);
            this.tabPageArcedit.Name = "tabPageArcedit";
            this.tabPageArcedit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArcedit.Size = new System.Drawing.Size(1021, 936);
            this.tabPageArcedit.TabIndex = 0;
            this.tabPageArcedit.Text = "内容编辑发布";
            this.tabPageArcedit.UseVisualStyleBackColor = true;
            // 
            // gboxArcList
            // 
            this.gboxArcList.Controls.Add(this.tboxDisplayArcCount);
            this.gboxArcList.Controls.Add(this.lblDisplayArcCount);
            this.gboxArcList.Controls.Add(this.btnSearchArcTitle);
            this.gboxArcList.Controls.Add(this.listViewArticles);
            this.gboxArcList.Controls.Add(this.tboxSearchArcTitle);
            this.gboxArcList.Controls.Add(this.lblSearchArcTitle);
            this.gboxArcList.Location = new System.Drawing.Point(377, 6);
            this.gboxArcList.Name = "gboxArcList";
            this.gboxArcList.Size = new System.Drawing.Size(636, 911);
            this.gboxArcList.TabIndex = 1;
            this.gboxArcList.TabStop = false;
            this.gboxArcList.Text = "选择文章";
            // 
            // tboxDisplayArcCount
            // 
            this.tboxDisplayArcCount.Location = new System.Drawing.Point(412, 19);
            this.tboxDisplayArcCount.Name = "tboxDisplayArcCount";
            this.tboxDisplayArcCount.Size = new System.Drawing.Size(218, 28);
            this.tboxDisplayArcCount.TabIndex = 21;
            this.tboxDisplayArcCount.TextChanged += new System.EventHandler(this.tboxDisplayArcCount_TextChanged);
            // 
            // lblDisplayArcCount
            // 
            this.lblDisplayArcCount.AutoSize = true;
            this.lblDisplayArcCount.Location = new System.Drawing.Point(278, 24);
            this.lblDisplayArcCount.Name = "lblDisplayArcCount";
            this.lblDisplayArcCount.Size = new System.Drawing.Size(125, 18);
            this.lblDisplayArcCount.TabIndex = 24;
            this.lblDisplayArcCount.Text = "显示文章数量:";
            // 
            // btnSearchArcTitle
            // 
            this.btnSearchArcTitle.Location = new System.Drawing.Point(489, 58);
            this.btnSearchArcTitle.Name = "btnSearchArcTitle";
            this.btnSearchArcTitle.Size = new System.Drawing.Size(141, 31);
            this.btnSearchArcTitle.TabIndex = 23;
            this.btnSearchArcTitle.Text = "搜索";
            this.btnSearchArcTitle.UseVisualStyleBackColor = true;
            this.btnSearchArcTitle.Click += new System.EventHandler(this.btnSearchArcTitle_Click);
            // 
            // listViewArticles
            // 
            this.listViewArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.arc_aid,
            this.arc_pic_counts,
            this.arc_title});
            this.listViewArticles.FullRowSelect = true;
            this.listViewArticles.GridLines = true;
            this.listViewArticles.Location = new System.Drawing.Point(6, 109);
            this.listViewArticles.MultiSelect = false;
            this.listViewArticles.Name = "listViewArticles";
            this.listViewArticles.Size = new System.Drawing.Size(624, 796);
            this.listViewArticles.TabIndex = 21;
            this.listViewArticles.UseCompatibleStateImageBehavior = false;
            this.listViewArticles.View = System.Windows.Forms.View.Details;
            this.listViewArticles.SelectedIndexChanged += new System.EventHandler(this.listViewArticles_SelectedIndexChanged);
            // 
            // arc_aid
            // 
            this.arc_aid.Text = "文章ID";
            this.arc_aid.Width = 76;
            // 
            // arc_pic_counts
            // 
            this.arc_pic_counts.Text = "图片数";
            this.arc_pic_counts.Width = 80;
            // 
            // arc_title
            // 
            this.arc_title.Text = "文章标题";
            this.arc_title.Width = 450;
            // 
            // tboxSearchArcTitle
            // 
            this.tboxSearchArcTitle.Location = new System.Drawing.Point(6, 61);
            this.tboxSearchArcTitle.Name = "tboxSearchArcTitle";
            this.tboxSearchArcTitle.Size = new System.Drawing.Size(477, 28);
            this.tboxSearchArcTitle.TabIndex = 22;
            // 
            // lblSearchArcTitle
            // 
            this.lblSearchArcTitle.AutoSize = true;
            this.lblSearchArcTitle.Location = new System.Drawing.Point(6, 32);
            this.lblSearchArcTitle.Name = "lblSearchArcTitle";
            this.lblSearchArcTitle.Size = new System.Drawing.Size(125, 18);
            this.lblSearchArcTitle.TabIndex = 21;
            this.lblSearchArcTitle.Text = "搜索文章标题:";
            // 
            // gboxArcCategory
            // 
            this.gboxArcCategory.Controls.Add(this.btnSearchCoTypename);
            this.gboxArcCategory.Controls.Add(this.tboxSearchCoTypename);
            this.gboxArcCategory.Controls.Add(this.lblSearchCoTypename);
            this.gboxArcCategory.Controls.Add(this.listViewCoTypeinfo);
            this.gboxArcCategory.Location = new System.Drawing.Point(8, 6);
            this.gboxArcCategory.Name = "gboxArcCategory";
            this.gboxArcCategory.Size = new System.Drawing.Size(363, 911);
            this.gboxArcCategory.TabIndex = 0;
            this.gboxArcCategory.TabStop = false;
            this.gboxArcCategory.Text = "选择采集分类";
            // 
            // btnSearchCoTypename
            // 
            this.btnSearchCoTypename.Location = new System.Drawing.Point(190, 58);
            this.btnSearchCoTypename.Name = "btnSearchCoTypename";
            this.btnSearchCoTypename.Size = new System.Drawing.Size(141, 31);
            this.btnSearchCoTypename.TabIndex = 20;
            this.btnSearchCoTypename.Text = "搜索";
            this.btnSearchCoTypename.UseVisualStyleBackColor = true;
            this.btnSearchCoTypename.Click += new System.EventHandler(this.btnSearchCoTypename_Click);
            // 
            // tboxSearchCoTypename
            // 
            this.tboxSearchCoTypename.Location = new System.Drawing.Point(11, 61);
            this.tboxSearchCoTypename.Name = "tboxSearchCoTypename";
            this.tboxSearchCoTypename.Size = new System.Drawing.Size(161, 28);
            this.tboxSearchCoTypename.TabIndex = 19;
            // 
            // lblSearchCoTypename
            // 
            this.lblSearchCoTypename.AutoSize = true;
            this.lblSearchCoTypename.Location = new System.Drawing.Point(8, 32);
            this.lblSearchCoTypename.Name = "lblSearchCoTypename";
            this.lblSearchCoTypename.Size = new System.Drawing.Size(89, 18);
            this.lblSearchCoTypename.TabIndex = 18;
            this.lblSearchCoTypename.Text = "搜索分类:";
            // 
            // listViewCoTypeinfo
            // 
            this.listViewCoTypeinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.co_typeid,
            this.co_typename,
            this.co_type_unused_nums});
            this.listViewCoTypeinfo.FullRowSelect = true;
            this.listViewCoTypeinfo.GridLines = true;
            this.listViewCoTypeinfo.Location = new System.Drawing.Point(6, 109);
            this.listViewCoTypeinfo.MultiSelect = false;
            this.listViewCoTypeinfo.Name = "listViewCoTypeinfo";
            this.listViewCoTypeinfo.Size = new System.Drawing.Size(351, 796);
            this.listViewCoTypeinfo.TabIndex = 17;
            this.listViewCoTypeinfo.UseCompatibleStateImageBehavior = false;
            this.listViewCoTypeinfo.View = System.Windows.Forms.View.Details;
            this.listViewCoTypeinfo.SelectedIndexChanged += new System.EventHandler(this.listViewCoTypeinfo_SelectedIndexChanged);
            // 
            // co_typeid
            // 
            this.co_typeid.Text = "分类ID";
            this.co_typeid.Width = 80;
            // 
            // co_typename
            // 
            this.co_typename.Text = "分类名称";
            this.co_typename.Width = 140;
            // 
            // co_type_unused_nums
            // 
            this.co_type_unused_nums.Text = "可用文章数";
            this.co_type_unused_nums.Width = 120;
            // 
            // tabPageSysconfig
            // 
            this.tabPageSysconfig.Controls.Add(this.gbxPubDatabaseSet);
            this.tabPageSysconfig.Controls.Add(this.btnSaveConfig);
            this.tabPageSysconfig.Controls.Add(this.gbxCoDatabaseSet);
            this.tabPageSysconfig.Location = new System.Drawing.Point(4, 28);
            this.tabPageSysconfig.Name = "tabPageSysconfig";
            this.tabPageSysconfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSysconfig.Size = new System.Drawing.Size(1021, 936);
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
            this.btnSaveConfig.Location = new System.Drawing.Point(879, 456);
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
            this.ClientSize = new System.Drawing.Size(1029, 968);
            this.Controls.Add(this.tabctrMainform);
            this.Name = "MainForm";
            this.Text = "文章编辑";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabctrMainform.ResumeLayout(false);
            this.tabPageArcedit.ResumeLayout(false);
            this.gboxArcList.ResumeLayout(false);
            this.gboxArcList.PerformLayout();
            this.gboxArcCategory.ResumeLayout(false);
            this.gboxArcCategory.PerformLayout();
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
        private System.Windows.Forms.GroupBox gboxArcCategory;
        private System.Windows.Forms.GroupBox gboxArcList;
        private System.Windows.Forms.Button btnSearchCoTypename;
        private System.Windows.Forms.TextBox tboxSearchCoTypename;
        private System.Windows.Forms.Label lblSearchCoTypename;
        private ArcDB.ListViewNF listViewCoTypeinfo;
        private System.Windows.Forms.ColumnHeader co_typeid;
        private System.Windows.Forms.ColumnHeader co_typename;
        private System.Windows.Forms.ColumnHeader co_type_unused_nums;
        private ArcDB.ListViewNF listViewArticles;
        private System.Windows.Forms.ColumnHeader arc_aid;
        private System.Windows.Forms.ColumnHeader arc_title;
        private System.Windows.Forms.Button btnSearchArcTitle;
        private System.Windows.Forms.TextBox tboxSearchArcTitle;
        private System.Windows.Forms.Label lblSearchArcTitle;
        private System.Windows.Forms.TextBox tboxDisplayArcCount;
        private System.Windows.Forms.Label lblDisplayArcCount;
        private System.Windows.Forms.ColumnHeader arc_pic_counts;
    }
}

