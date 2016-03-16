using Manina.Windows.Forms;

namespace ArcEdit
{
    partial class ArticleEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleEditForm));
            this.gboxWebBrowser = new System.Windows.Forms.GroupBox();
            this.webBrowserArcContent = new System.Windows.Forms.WebBrowser();
            this.gboxArcPics = new System.Windows.Forms.GroupBox();
            this.lblPicType = new System.Windows.Forms.Label();
            this.cboxPicType = new System.Windows.Forms.ComboBox();
            this.lblThumbSize = new System.Windows.Forms.Label();
            this.cboxThumbSize = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.thumbnailsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.galleryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.paneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.detailsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearThumbsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.x96ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x120ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gboxImageListView = new System.Windows.Forms.GroupBox();
            this.imageListView = new Manina.Windows.Forms.ImageListView();
            this.gboxPubTypename = new System.Windows.Forms.GroupBox();
            this.btnSearchPubTypename = new System.Windows.Forms.Button();
            this.tboxPubTypeid = new System.Windows.Forms.TextBox();
            this.lblPubTypeid = new System.Windows.Forms.Label();
            this.tboxSearchPubTypename = new System.Windows.Forms.TextBox();
            this.lblSearchPubTypename = new System.Windows.Forms.Label();
            this.lblPubTypename = new System.Windows.Forms.Label();
            this.tboxPubTypename = new System.Windows.Forms.TextBox();
            this.gboxListViewPubtype = new System.Windows.Forms.GroupBox();
            this.listViewPubTypeinfo = new ArcDB.ListViewNF();
            this.pub_typeid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pub_typename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pub_type_items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxArcEdit = new System.Windows.Forms.GroupBox();
            this.btnDisableArticle = new System.Windows.Forms.Button();
            this.lblCmsType = new System.Windows.Forms.Label();
            this.cboxCmsType = new System.Windows.Forms.ComboBox();
            this.tboxArticleLitpicURL = new System.Windows.Forms.TextBox();
            this.lblArticleLitpicURL = new System.Windows.Forms.Label();
            this.tboxAticleTypename = new System.Windows.Forms.TextBox();
            this.lblArticleTypename = new System.Windows.Forms.Label();
            this.tboxArticleDescription = new System.Windows.Forms.TextBox();
            this.lblArticleDescription = new System.Windows.Forms.Label();
            this.tboxArticleKeywords = new System.Windows.Forms.TextBox();
            this.lblArticleKeywords = new System.Windows.Forms.Label();
            this.tboxArticleTitle = new System.Windows.Forms.TextBox();
            this.lblArticleTitle = new System.Windows.Forms.Label();
            this.btnPublishArticle = new System.Windows.Forms.Button();
            this.btnSaveArticle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.gboxPageSpliter = new System.Windows.Forms.GroupBox();
            this.radioBtnOriginPage = new System.Windows.Forms.RadioButton();
            this.radioBtnAutopage = new System.Windows.Forms.RadioButton();
            this.radioBtnHandpage = new System.Windows.Forms.RadioButton();
            this.gboxAutopageType = new System.Windows.Forms.GroupBox();
            this.radioBtnAutopagebyImages = new System.Windows.Forms.RadioButton();
            this.radioBtnAutopagebyWords = new System.Windows.Forms.RadioButton();
            this.gboxParams = new System.Windows.Forms.GroupBox();
            this.tboxAutopageParams = new System.Windows.Forms.TextBox();
            this.lblPageParams = new System.Windows.Forms.Label();
            this.gboxOtherOption = new System.Windows.Forms.GroupBox();
            this.btnClearPageSeparator = new System.Windows.Forms.Button();
            this.btnResetEditorContent = new System.Windows.Forms.Button();
            this.checkBoxClearFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxOnlyImages = new System.Windows.Forms.CheckBox();
            this.statusStripArceditBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblImgCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.gboxWebBrowser.SuspendLayout();
            this.gboxArcPics.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gboxImageListView.SuspendLayout();
            this.gboxPubTypename.SuspendLayout();
            this.gboxListViewPubtype.SuspendLayout();
            this.gboxArcEdit.SuspendLayout();
            this.gboxPageSpliter.SuspendLayout();
            this.gboxAutopageType.SuspendLayout();
            this.gboxParams.SuspendLayout();
            this.gboxOtherOption.SuspendLayout();
            this.statusStripArceditBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxWebBrowser
            // 
            this.gboxWebBrowser.Controls.Add(this.webBrowserArcContent);
            this.gboxWebBrowser.Location = new System.Drawing.Point(12, 597);
            this.gboxWebBrowser.Name = "gboxWebBrowser";
            this.gboxWebBrowser.Size = new System.Drawing.Size(812, 808);
            this.gboxWebBrowser.TabIndex = 47;
            this.gboxWebBrowser.TabStop = false;
            this.gboxWebBrowser.Text = "内容编辑";
            // 
            // webBrowserArcContent
            // 
            this.webBrowserArcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserArcContent.Location = new System.Drawing.Point(3, 24);
            this.webBrowserArcContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserArcContent.Name = "webBrowserArcContent";
            this.webBrowserArcContent.Size = new System.Drawing.Size(806, 781);
            this.webBrowserArcContent.TabIndex = 39;
            // 
            // gboxArcPics
            // 
            this.gboxArcPics.Controls.Add(this.lblPicType);
            this.gboxArcPics.Controls.Add(this.cboxPicType);
            this.gboxArcPics.Controls.Add(this.lblThumbSize);
            this.gboxArcPics.Controls.Add(this.cboxThumbSize);
            this.gboxArcPics.Location = new System.Drawing.Point(830, 364);
            this.gboxArcPics.Name = "gboxArcPics";
            this.gboxArcPics.Size = new System.Drawing.Size(585, 72);
            this.gboxArcPics.TabIndex = 44;
            this.gboxArcPics.TabStop = false;
            this.gboxArcPics.Text = "图片选择";
            // 
            // lblPicType
            // 
            this.lblPicType.AutoSize = true;
            this.lblPicType.Location = new System.Drawing.Point(306, 32);
            this.lblPicType.Name = "lblPicType";
            this.lblPicType.Size = new System.Drawing.Size(125, 18);
            this.lblPicType.TabIndex = 43;
            this.lblPicType.Text = "选择图片类型:";
            // 
            // cboxPicType
            // 
            this.cboxPicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPicType.FormattingEnabled = true;
            this.cboxPicType.Items.AddRange(new object[] {
            "缩略图",
            "文章图片"});
            this.cboxPicType.Location = new System.Drawing.Point(436, 26);
            this.cboxPicType.Name = "cboxPicType";
            this.cboxPicType.Size = new System.Drawing.Size(136, 26);
            this.cboxPicType.TabIndex = 42;
            this.cboxPicType.SelectedIndexChanged += new System.EventHandler(this.cboxPicType_SelectedIndexChanged);
            // 
            // lblThumbSize
            // 
            this.lblThumbSize.AutoSize = true;
            this.lblThumbSize.Location = new System.Drawing.Point(9, 32);
            this.lblThumbSize.Name = "lblThumbSize";
            this.lblThumbSize.Size = new System.Drawing.Size(143, 18);
            this.lblThumbSize.TabIndex = 40;
            this.lblThumbSize.Text = "选择缩略图规格:";
            // 
            // cboxThumbSize
            // 
            this.cboxThumbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxThumbSize.FormattingEnabled = true;
            this.cboxThumbSize.Location = new System.Drawing.Point(160, 26);
            this.cboxThumbSize.Name = "cboxThumbSize";
            this.cboxThumbSize.Size = new System.Drawing.Size(136, 26);
            this.cboxThumbSize.TabIndex = 39;
            this.cboxThumbSize.SelectedIndexChanged += new System.EventHandler(this.cboxThumbSize_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thumbnailsToolStripButton,
            this.galleryToolStripButton,
            this.paneToolStripButton,
            this.detailsToolStripButton,
            this.toolStripSeparator3,
            this.clearThumbsToolStripButton,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(830, 466);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(319, 31);
            this.toolStrip1.TabIndex = 41;
            // 
            // thumbnailsToolStripButton
            // 
            this.thumbnailsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.thumbnailsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("thumbnailsToolStripButton.Image")));
            this.thumbnailsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.thumbnailsToolStripButton.Name = "thumbnailsToolStripButton";
            this.thumbnailsToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.thumbnailsToolStripButton.Text = "Thumbnails";
            this.thumbnailsToolStripButton.Click += new System.EventHandler(this.thumbnailsToolStripButton_Click);
            // 
            // galleryToolStripButton
            // 
            this.galleryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.galleryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("galleryToolStripButton.Image")));
            this.galleryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.galleryToolStripButton.Name = "galleryToolStripButton";
            this.galleryToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.galleryToolStripButton.Text = "Gallery";
            this.galleryToolStripButton.Click += new System.EventHandler(this.galleryToolStripButton_Click);
            // 
            // paneToolStripButton
            // 
            this.paneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paneToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("paneToolStripButton.Image")));
            this.paneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paneToolStripButton.Name = "paneToolStripButton";
            this.paneToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.paneToolStripButton.Text = "Pane";
            this.paneToolStripButton.Click += new System.EventHandler(this.paneToolStripButton_Click);
            // 
            // detailsToolStripButton
            // 
            this.detailsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detailsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripButton.Image")));
            this.detailsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailsToolStripButton.Name = "detailsToolStripButton";
            this.detailsToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.detailsToolStripButton.Text = "Details";
            this.detailsToolStripButton.Click += new System.EventHandler(this.detailsToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // clearThumbsToolStripButton
            // 
            this.clearThumbsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearThumbsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearThumbsToolStripButton.Image")));
            this.clearThumbsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearThumbsToolStripButton.Name = "clearThumbsToolStripButton";
            this.clearThumbsToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.clearThumbsToolStripButton.Text = "Clear Thumbnail Cache";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x96ToolStripMenuItem,
            this.x120ToolStripMenuItem,
            this.x200ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(154, 28);
            this.toolStripDropDownButton1.Text = "缩略图显示大小";
            // 
            // x96ToolStripMenuItem
            // 
            this.x96ToolStripMenuItem.Name = "x96ToolStripMenuItem";
            this.x96ToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.x96ToolStripMenuItem.Text = "96x96";
            this.x96ToolStripMenuItem.Click += new System.EventHandler(this.x96ToolStripMenuItem_Click);
            // 
            // x120ToolStripMenuItem
            // 
            this.x120ToolStripMenuItem.Name = "x120ToolStripMenuItem";
            this.x120ToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.x120ToolStripMenuItem.Text = "120x120";
            this.x120ToolStripMenuItem.Click += new System.EventHandler(this.x120ToolStripMenuItem_Click);
            // 
            // x200ToolStripMenuItem
            // 
            this.x200ToolStripMenuItem.Name = "x200ToolStripMenuItem";
            this.x200ToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.x200ToolStripMenuItem.Text = "200x200";
            this.x200ToolStripMenuItem.Click += new System.EventHandler(this.x200ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // gboxImageListView
            // 
            this.gboxImageListView.Controls.Add(this.imageListView);
            this.gboxImageListView.Location = new System.Drawing.Point(830, 520);
            this.gboxImageListView.Name = "gboxImageListView";
            this.gboxImageListView.Size = new System.Drawing.Size(585, 885);
            this.gboxImageListView.TabIndex = 45;
            this.gboxImageListView.TabStop = false;
            this.gboxImageListView.Text = "ImageListView";
            // 
            // imageListView
            // 
            this.imageListView.AllowDuplicateFileNames = true;
            this.imageListView.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListView.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.imageListView.Location = new System.Drawing.Point(3, 24);
            this.imageListView.Margin = new System.Windows.Forms.Padding(4);
            this.imageListView.Name = "imageListView";
            this.imageListView.PersistentCacheDirectory = "";
            this.imageListView.PersistentCacheSize = ((long)(100));
            this.imageListView.Size = new System.Drawing.Size(579, 858);
            this.imageListView.TabIndex = 0;
            this.imageListView.SelectionChanged += new System.EventHandler(this.imageListView_SelectionChanged);
            // 
            // gboxPubTypename
            // 
            this.gboxPubTypename.Controls.Add(this.btnSearchPubTypename);
            this.gboxPubTypename.Controls.Add(this.tboxPubTypeid);
            this.gboxPubTypename.Controls.Add(this.lblPubTypeid);
            this.gboxPubTypename.Controls.Add(this.tboxSearchPubTypename);
            this.gboxPubTypename.Controls.Add(this.lblSearchPubTypename);
            this.gboxPubTypename.Controls.Add(this.lblPubTypename);
            this.gboxPubTypename.Controls.Add(this.tboxPubTypename);
            this.gboxPubTypename.Location = new System.Drawing.Point(980, 12);
            this.gboxPubTypename.Name = "gboxPubTypename";
            this.gboxPubTypename.Size = new System.Drawing.Size(436, 116);
            this.gboxPubTypename.TabIndex = 20;
            this.gboxPubTypename.TabStop = false;
            this.gboxPubTypename.Text = "选择发布分类";
            // 
            // btnSearchPubTypename
            // 
            this.btnSearchPubTypename.Location = new System.Drawing.Point(274, 66);
            this.btnSearchPubTypename.Name = "btnSearchPubTypename";
            this.btnSearchPubTypename.Size = new System.Drawing.Size(141, 32);
            this.btnSearchPubTypename.TabIndex = 15;
            this.btnSearchPubTypename.Text = "搜索";
            this.btnSearchPubTypename.UseVisualStyleBackColor = true;
            this.btnSearchPubTypename.Click += new System.EventHandler(this.btnSearchPubTypename_Click);
            // 
            // tboxPubTypeid
            // 
            this.tboxPubTypeid.Location = new System.Drawing.Point(56, 27);
            this.tboxPubTypeid.Name = "tboxPubTypeid";
            this.tboxPubTypeid.ReadOnly = true;
            this.tboxPubTypeid.Size = new System.Drawing.Size(94, 28);
            this.tboxPubTypeid.TabIndex = 14;
            // 
            // lblPubTypeid
            // 
            this.lblPubTypeid.AutoSize = true;
            this.lblPubTypeid.Location = new System.Drawing.Point(6, 32);
            this.lblPubTypeid.Name = "lblPubTypeid";
            this.lblPubTypeid.Size = new System.Drawing.Size(44, 18);
            this.lblPubTypeid.TabIndex = 13;
            this.lblPubTypeid.Text = "ID: ";
            // 
            // tboxSearchPubTypename
            // 
            this.tboxSearchPubTypename.Location = new System.Drawing.Point(106, 69);
            this.tboxSearchPubTypename.Name = "tboxSearchPubTypename";
            this.tboxSearchPubTypename.Size = new System.Drawing.Size(162, 28);
            this.tboxSearchPubTypename.TabIndex = 3;
            // 
            // lblSearchPubTypename
            // 
            this.lblSearchPubTypename.AutoSize = true;
            this.lblSearchPubTypename.Location = new System.Drawing.Point(6, 74);
            this.lblSearchPubTypename.Name = "lblSearchPubTypename";
            this.lblSearchPubTypename.Size = new System.Drawing.Size(89, 18);
            this.lblSearchPubTypename.TabIndex = 1;
            this.lblSearchPubTypename.Text = "搜索分类:";
            // 
            // lblPubTypename
            // 
            this.lblPubTypename.AutoSize = true;
            this.lblPubTypename.Location = new System.Drawing.Point(168, 32);
            this.lblPubTypename.Name = "lblPubTypename";
            this.lblPubTypename.Size = new System.Drawing.Size(89, 18);
            this.lblPubTypename.TabIndex = 9;
            this.lblPubTypename.Text = "发布分类:";
            // 
            // tboxPubTypename
            // 
            this.tboxPubTypename.Location = new System.Drawing.Point(274, 27);
            this.tboxPubTypename.Name = "tboxPubTypename";
            this.tboxPubTypename.ReadOnly = true;
            this.tboxPubTypename.Size = new System.Drawing.Size(140, 28);
            this.tboxPubTypename.TabIndex = 12;
            // 
            // gboxListViewPubtype
            // 
            this.gboxListViewPubtype.Controls.Add(this.listViewPubTypeinfo);
            this.gboxListViewPubtype.Location = new System.Drawing.Point(981, 135);
            this.gboxListViewPubtype.Name = "gboxListViewPubtype";
            this.gboxListViewPubtype.Size = new System.Drawing.Size(436, 213);
            this.gboxListViewPubtype.TabIndex = 0;
            this.gboxListViewPubtype.TabStop = false;
            this.gboxListViewPubtype.Text = "发布分类";
            // 
            // listViewPubTypeinfo
            // 
            this.listViewPubTypeinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pub_typeid,
            this.pub_typename,
            this.pub_type_items});
            this.listViewPubTypeinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPubTypeinfo.FullRowSelect = true;
            this.listViewPubTypeinfo.GridLines = true;
            this.listViewPubTypeinfo.Location = new System.Drawing.Point(3, 24);
            this.listViewPubTypeinfo.MultiSelect = false;
            this.listViewPubTypeinfo.Name = "listViewPubTypeinfo";
            this.listViewPubTypeinfo.Size = new System.Drawing.Size(430, 186);
            this.listViewPubTypeinfo.TabIndex = 17;
            this.listViewPubTypeinfo.UseCompatibleStateImageBehavior = false;
            this.listViewPubTypeinfo.View = System.Windows.Forms.View.Details;
            this.listViewPubTypeinfo.SelectedIndexChanged += new System.EventHandler(this.listViewPubTypeinfo_SelectedIndexChanged);
            // 
            // pub_typeid
            // 
            this.pub_typeid.Text = "发布分类ID";
            this.pub_typeid.Width = 120;
            // 
            // pub_typename
            // 
            this.pub_typename.Text = "发布分类名称";
            this.pub_typename.Width = 130;
            // 
            // pub_type_items
            // 
            this.pub_type_items.Text = "栏目文章数";
            this.pub_type_items.Width = 130;
            // 
            // gboxArcEdit
            // 
            this.gboxArcEdit.Controls.Add(this.btnDisableArticle);
            this.gboxArcEdit.Controls.Add(this.lblCmsType);
            this.gboxArcEdit.Controls.Add(this.cboxCmsType);
            this.gboxArcEdit.Controls.Add(this.tboxArticleLitpicURL);
            this.gboxArcEdit.Controls.Add(this.lblArticleLitpicURL);
            this.gboxArcEdit.Controls.Add(this.tboxAticleTypename);
            this.gboxArcEdit.Controls.Add(this.lblArticleTypename);
            this.gboxArcEdit.Controls.Add(this.tboxArticleDescription);
            this.gboxArcEdit.Controls.Add(this.lblArticleDescription);
            this.gboxArcEdit.Controls.Add(this.tboxArticleKeywords);
            this.gboxArcEdit.Controls.Add(this.lblArticleKeywords);
            this.gboxArcEdit.Controls.Add(this.tboxArticleTitle);
            this.gboxArcEdit.Controls.Add(this.lblArticleTitle);
            this.gboxArcEdit.Controls.Add(this.btnPublishArticle);
            this.gboxArcEdit.Controls.Add(this.btnSaveArticle);
            this.gboxArcEdit.Controls.Add(this.label17);
            this.gboxArcEdit.Location = new System.Drawing.Point(12, 12);
            this.gboxArcEdit.Name = "gboxArcEdit";
            this.gboxArcEdit.Size = new System.Drawing.Size(963, 336);
            this.gboxArcEdit.TabIndex = 46;
            this.gboxArcEdit.TabStop = false;
            this.gboxArcEdit.Text = "编辑发布文章";
            // 
            // btnDisableArticle
            // 
            this.btnDisableArticle.Location = new System.Drawing.Point(13, 25);
            this.btnDisableArticle.Name = "btnDisableArticle";
            this.btnDisableArticle.Size = new System.Drawing.Size(141, 32);
            this.btnDisableArticle.TabIndex = 46;
            this.btnDisableArticle.Text = "禁用文章";
            this.btnDisableArticle.UseVisualStyleBackColor = true;
            this.btnDisableArticle.Click += new System.EventHandler(this.btnDisableArticle_Click);
            // 
            // lblCmsType
            // 
            this.lblCmsType.AutoSize = true;
            this.lblCmsType.Location = new System.Drawing.Point(682, 36);
            this.lblCmsType.Name = "lblCmsType";
            this.lblCmsType.Size = new System.Drawing.Size(116, 18);
            this.lblCmsType.TabIndex = 45;
            this.lblCmsType.Text = "发布CMS类型:";
            // 
            // cboxCmsType
            // 
            this.cboxCmsType.FormattingEnabled = true;
            this.cboxCmsType.Items.AddRange(new object[] {
            "akcms",
            "phpcms"});
            this.cboxCmsType.Location = new System.Drawing.Point(816, 32);
            this.cboxCmsType.Name = "cboxCmsType";
            this.cboxCmsType.Size = new System.Drawing.Size(136, 26);
            this.cboxCmsType.TabIndex = 44;
            // 
            // tboxArticleLitpicURL
            // 
            this.tboxArticleLitpicURL.Location = new System.Drawing.Point(116, 286);
            this.tboxArticleLitpicURL.Name = "tboxArticleLitpicURL";
            this.tboxArticleLitpicURL.Size = new System.Drawing.Size(836, 28);
            this.tboxArticleLitpicURL.TabIndex = 36;
            // 
            // lblArticleLitpicURL
            // 
            this.lblArticleLitpicURL.AutoSize = true;
            this.lblArticleLitpicURL.Location = new System.Drawing.Point(14, 290);
            this.lblArticleLitpicURL.Name = "lblArticleLitpicURL";
            this.lblArticleLitpicURL.Size = new System.Drawing.Size(98, 18);
            this.lblArticleLitpicURL.TabIndex = 37;
            this.lblArticleLitpicURL.Text = "缩略图URL:";
            // 
            // tboxAticleTypename
            // 
            this.tboxAticleTypename.Location = new System.Drawing.Point(116, 118);
            this.tboxAticleTypename.Name = "tboxAticleTypename";
            this.tboxAticleTypename.ReadOnly = true;
            this.tboxAticleTypename.Size = new System.Drawing.Size(296, 28);
            this.tboxAticleTypename.TabIndex = 30;
            // 
            // lblArticleTypename
            // 
            this.lblArticleTypename.AutoSize = true;
            this.lblArticleTypename.Location = new System.Drawing.Point(14, 123);
            this.lblArticleTypename.Name = "lblArticleTypename";
            this.lblArticleTypename.Size = new System.Drawing.Size(89, 18);
            this.lblArticleTypename.TabIndex = 31;
            this.lblArticleTypename.Text = "采集分类:";
            // 
            // tboxArticleDescription
            // 
            this.tboxArticleDescription.Location = new System.Drawing.Point(116, 156);
            this.tboxArticleDescription.Multiline = true;
            this.tboxArticleDescription.Name = "tboxArticleDescription";
            this.tboxArticleDescription.Size = new System.Drawing.Size(836, 120);
            this.tboxArticleDescription.TabIndex = 28;
            // 
            // lblArticleDescription
            // 
            this.lblArticleDescription.AutoSize = true;
            this.lblArticleDescription.Location = new System.Drawing.Point(14, 160);
            this.lblArticleDescription.Name = "lblArticleDescription";
            this.lblArticleDescription.Size = new System.Drawing.Size(89, 18);
            this.lblArticleDescription.TabIndex = 29;
            this.lblArticleDescription.Text = "文章概要:";
            // 
            // tboxArticleKeywords
            // 
            this.tboxArticleKeywords.Location = new System.Drawing.Point(560, 118);
            this.tboxArticleKeywords.Name = "tboxArticleKeywords";
            this.tboxArticleKeywords.Size = new System.Drawing.Size(394, 28);
            this.tboxArticleKeywords.TabIndex = 26;
            // 
            // lblArticleKeywords
            // 
            this.lblArticleKeywords.AutoSize = true;
            this.lblArticleKeywords.Location = new System.Drawing.Point(456, 123);
            this.lblArticleKeywords.Name = "lblArticleKeywords";
            this.lblArticleKeywords.Size = new System.Drawing.Size(71, 18);
            this.lblArticleKeywords.TabIndex = 27;
            this.lblArticleKeywords.Text = "关键词:";
            // 
            // tboxArticleTitle
            // 
            this.tboxArticleTitle.Location = new System.Drawing.Point(116, 80);
            this.tboxArticleTitle.Name = "tboxArticleTitle";
            this.tboxArticleTitle.Size = new System.Drawing.Size(836, 28);
            this.tboxArticleTitle.TabIndex = 25;
            // 
            // lblArticleTitle
            // 
            this.lblArticleTitle.AutoSize = true;
            this.lblArticleTitle.Location = new System.Drawing.Point(14, 84);
            this.lblArticleTitle.Name = "lblArticleTitle";
            this.lblArticleTitle.Size = new System.Drawing.Size(89, 18);
            this.lblArticleTitle.TabIndex = 25;
            this.lblArticleTitle.Text = "文章标题:";
            // 
            // btnPublishArticle
            // 
            this.btnPublishArticle.Location = new System.Drawing.Point(525, 25);
            this.btnPublishArticle.Name = "btnPublishArticle";
            this.btnPublishArticle.Size = new System.Drawing.Size(141, 32);
            this.btnPublishArticle.TabIndex = 25;
            this.btnPublishArticle.Text = "发布文章";
            this.btnPublishArticle.UseVisualStyleBackColor = true;
            this.btnPublishArticle.Click += new System.EventHandler(this.btnPublishArticle_Click);
            // 
            // btnSaveArticle
            // 
            this.btnSaveArticle.Location = new System.Drawing.Point(368, 25);
            this.btnSaveArticle.Name = "btnSaveArticle";
            this.btnSaveArticle.Size = new System.Drawing.Size(141, 32);
            this.btnSaveArticle.TabIndex = 24;
            this.btnSaveArticle.Text = "保存文章";
            this.btnSaveArticle.UseVisualStyleBackColor = true;
            this.btnSaveArticle.Click += new System.EventHandler(this.btnSaveArticle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-458, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 18);
            this.label17.TabIndex = 22;
            this.label17.Text = "搜索分类:";
            // 
            // gboxPageSpliter
            // 
            this.gboxPageSpliter.Controls.Add(this.radioBtnOriginPage);
            this.gboxPageSpliter.Controls.Add(this.radioBtnAutopage);
            this.gboxPageSpliter.Controls.Add(this.radioBtnHandpage);
            this.gboxPageSpliter.Location = new System.Drawing.Point(12, 364);
            this.gboxPageSpliter.Margin = new System.Windows.Forms.Padding(4);
            this.gboxPageSpliter.Name = "gboxPageSpliter";
            this.gboxPageSpliter.Padding = new System.Windows.Forms.Padding(4);
            this.gboxPageSpliter.Size = new System.Drawing.Size(414, 72);
            this.gboxPageSpliter.TabIndex = 48;
            this.gboxPageSpliter.TabStop = false;
            this.gboxPageSpliter.Text = "添加分隔符";
            // 
            // radioBtnOriginPage
            // 
            this.radioBtnOriginPage.AutoSize = true;
            this.radioBtnOriginPage.Location = new System.Drawing.Point(16, 27);
            this.radioBtnOriginPage.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnOriginPage.Name = "radioBtnOriginPage";
            this.radioBtnOriginPage.Size = new System.Drawing.Size(105, 22);
            this.radioBtnOriginPage.TabIndex = 2;
            this.radioBtnOriginPage.TabStop = true;
            this.radioBtnOriginPage.Text = "原始分页";
            this.radioBtnOriginPage.UseVisualStyleBackColor = true;
            this.radioBtnOriginPage.CheckedChanged += new System.EventHandler(this.radioBtnOriginPage_CheckedChanged);
            // 
            // radioBtnAutopage
            // 
            this.radioBtnAutopage.AutoSize = true;
            this.radioBtnAutopage.Location = new System.Drawing.Point(284, 27);
            this.radioBtnAutopage.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAutopage.Name = "radioBtnAutopage";
            this.radioBtnAutopage.Size = new System.Drawing.Size(105, 22);
            this.radioBtnAutopage.TabIndex = 1;
            this.radioBtnAutopage.TabStop = true;
            this.radioBtnAutopage.Text = "自动分页";
            this.radioBtnAutopage.UseVisualStyleBackColor = true;
            this.radioBtnAutopage.CheckedChanged += new System.EventHandler(this.radioBtnAutopage_CheckedChanged);
            // 
            // radioBtnHandpage
            // 
            this.radioBtnHandpage.AutoSize = true;
            this.radioBtnHandpage.Location = new System.Drawing.Point(150, 27);
            this.radioBtnHandpage.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnHandpage.Name = "radioBtnHandpage";
            this.radioBtnHandpage.Size = new System.Drawing.Size(105, 22);
            this.radioBtnHandpage.TabIndex = 0;
            this.radioBtnHandpage.TabStop = true;
            this.radioBtnHandpage.Text = "手工分页";
            this.radioBtnHandpage.UseVisualStyleBackColor = true;
            this.radioBtnHandpage.CheckedChanged += new System.EventHandler(this.radioBtnHandpage_CheckedChanged);
            // 
            // gboxAutopageType
            // 
            this.gboxAutopageType.Controls.Add(this.radioBtnAutopagebyImages);
            this.gboxAutopageType.Controls.Add(this.radioBtnAutopagebyWords);
            this.gboxAutopageType.Location = new System.Drawing.Point(459, 364);
            this.gboxAutopageType.Margin = new System.Windows.Forms.Padding(4);
            this.gboxAutopageType.Name = "gboxAutopageType";
            this.gboxAutopageType.Padding = new System.Windows.Forms.Padding(4);
            this.gboxAutopageType.Size = new System.Drawing.Size(350, 72);
            this.gboxAutopageType.TabIndex = 49;
            this.gboxAutopageType.TabStop = false;
            this.gboxAutopageType.Text = "自动分页类型";
            // 
            // radioBtnAutopagebyImages
            // 
            this.radioBtnAutopagebyImages.AutoSize = true;
            this.radioBtnAutopagebyImages.Checked = true;
            this.radioBtnAutopagebyImages.Location = new System.Drawing.Point(174, 27);
            this.radioBtnAutopagebyImages.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAutopagebyImages.Name = "radioBtnAutopagebyImages";
            this.radioBtnAutopagebyImages.Size = new System.Drawing.Size(141, 22);
            this.radioBtnAutopagebyImages.TabIndex = 1;
            this.radioBtnAutopagebyImages.TabStop = true;
            this.radioBtnAutopagebyImages.Text = "按图片数分页";
            this.radioBtnAutopagebyImages.UseVisualStyleBackColor = true;
            // 
            // radioBtnAutopagebyWords
            // 
            this.radioBtnAutopagebyWords.AutoSize = true;
            this.radioBtnAutopagebyWords.Enabled = false;
            this.radioBtnAutopagebyWords.Location = new System.Drawing.Point(12, 27);
            this.radioBtnAutopagebyWords.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnAutopagebyWords.Name = "radioBtnAutopagebyWords";
            this.radioBtnAutopagebyWords.Size = new System.Drawing.Size(123, 22);
            this.radioBtnAutopagebyWords.TabIndex = 0;
            this.radioBtnAutopagebyWords.Text = "按字数分页";
            this.radioBtnAutopagebyWords.UseVisualStyleBackColor = true;
            // 
            // gboxParams
            // 
            this.gboxParams.Controls.Add(this.tboxAutopageParams);
            this.gboxParams.Controls.Add(this.lblPageParams);
            this.gboxParams.Location = new System.Drawing.Point(12, 448);
            this.gboxParams.Margin = new System.Windows.Forms.Padding(4);
            this.gboxParams.Name = "gboxParams";
            this.gboxParams.Padding = new System.Windows.Forms.Padding(4);
            this.gboxParams.Size = new System.Drawing.Size(796, 64);
            this.gboxParams.TabIndex = 50;
            this.gboxParams.TabStop = false;
            this.gboxParams.Text = "分页参数";
            // 
            // tboxAutopageParams
            // 
            this.tboxAutopageParams.Location = new System.Drawing.Point(218, 18);
            this.tboxAutopageParams.Margin = new System.Windows.Forms.Padding(4);
            this.tboxAutopageParams.Name = "tboxAutopageParams";
            this.tboxAutopageParams.Size = new System.Drawing.Size(568, 28);
            this.tboxAutopageParams.TabIndex = 1;
            // 
            // lblPageParams
            // 
            this.lblPageParams.AutoSize = true;
            this.lblPageParams.Location = new System.Drawing.Point(10, 26);
            this.lblPageParams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageParams.Name = "lblPageParams";
            this.lblPageParams.Size = new System.Drawing.Size(197, 18);
            this.lblPageParams.TabIndex = 0;
            this.lblPageParams.Text = "（图片数或字数）/页：";
            // 
            // gboxOtherOption
            // 
            this.gboxOtherOption.Controls.Add(this.btnClearPageSeparator);
            this.gboxOtherOption.Controls.Add(this.btnResetEditorContent);
            this.gboxOtherOption.Controls.Add(this.checkBoxClearFormat);
            this.gboxOtherOption.Controls.Add(this.checkBoxOnlyImages);
            this.gboxOtherOption.Location = new System.Drawing.Point(12, 522);
            this.gboxOtherOption.Margin = new System.Windows.Forms.Padding(4);
            this.gboxOtherOption.Name = "gboxOtherOption";
            this.gboxOtherOption.Padding = new System.Windows.Forms.Padding(4);
            this.gboxOtherOption.Size = new System.Drawing.Size(796, 68);
            this.gboxOtherOption.TabIndex = 51;
            this.gboxOtherOption.TabStop = false;
            this.gboxOtherOption.Text = "其他选项";
            // 
            // btnClearPageSeparator
            // 
            this.btnClearPageSeparator.Location = new System.Drawing.Point(444, 24);
            this.btnClearPageSeparator.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPageSeparator.Name = "btnClearPageSeparator";
            this.btnClearPageSeparator.Size = new System.Drawing.Size(160, 34);
            this.btnClearPageSeparator.TabIndex = 3;
            this.btnClearPageSeparator.Text = "清除所有分页";
            this.btnClearPageSeparator.UseVisualStyleBackColor = true;
            this.btnClearPageSeparator.Click += new System.EventHandler(this.btnClearPageSeparator_Click);
            // 
            // btnResetEditorContent
            // 
            this.btnResetEditorContent.Location = new System.Drawing.Point(627, 24);
            this.btnResetEditorContent.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetEditorContent.Name = "btnResetEditorContent";
            this.btnResetEditorContent.Size = new System.Drawing.Size(160, 34);
            this.btnResetEditorContent.TabIndex = 2;
            this.btnResetEditorContent.Text = "重置编辑器内容";
            this.btnResetEditorContent.UseVisualStyleBackColor = true;
            this.btnResetEditorContent.Click += new System.EventHandler(this.btnResetContent_Click);
            // 
            // checkBoxClearFormat
            // 
            this.checkBoxClearFormat.AutoSize = true;
            this.checkBoxClearFormat.Location = new System.Drawing.Point(210, 32);
            this.checkBoxClearFormat.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxClearFormat.Name = "checkBoxClearFormat";
            this.checkBoxClearFormat.Size = new System.Drawing.Size(106, 22);
            this.checkBoxClearFormat.TabIndex = 1;
            this.checkBoxClearFormat.Text = "去除空格";
            this.checkBoxClearFormat.UseVisualStyleBackColor = true;
            this.checkBoxClearFormat.CheckedChanged += new System.EventHandler(this.checkBoxClearFormat_CheckedChanged);
            // 
            // checkBoxOnlyImages
            // 
            this.checkBoxOnlyImages.AutoSize = true;
            this.checkBoxOnlyImages.Location = new System.Drawing.Point(30, 30);
            this.checkBoxOnlyImages.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOnlyImages.Name = "checkBoxOnlyImages";
            this.checkBoxOnlyImages.Size = new System.Drawing.Size(124, 22);
            this.checkBoxOnlyImages.TabIndex = 0;
            this.checkBoxOnlyImages.Text = "只保留图片";
            this.checkBoxOnlyImages.UseVisualStyleBackColor = true;
            this.checkBoxOnlyImages.CheckedChanged += new System.EventHandler(this.checkBoxOnlyImages_CheckedChanged);
            // 
            // statusStripArceditBottom
            // 
            this.statusStripArceditBottom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripArceditBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblImgCount,
            this.toolStripStatusLblWordsCount});
            this.statusStripArceditBottom.Location = new System.Drawing.Point(0, 1429);
            this.statusStripArceditBottom.Name = "statusStripArceditBottom";
            this.statusStripArceditBottom.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStripArceditBottom.Size = new System.Drawing.Size(1425, 29);
            this.statusStripArceditBottom.TabIndex = 52;
            this.statusStripArceditBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLblImgCount
            // 
            this.toolStripStatusLblImgCount.Name = "toolStripStatusLblImgCount";
            this.toolStripStatusLblImgCount.Size = new System.Drawing.Size(129, 24);
            this.toolStripStatusLblImgCount.Text = "文章图片数：0";
            // 
            // toolStripStatusLblWordsCount
            // 
            this.toolStripStatusLblWordsCount.Name = "toolStripStatusLblWordsCount";
            this.toolStripStatusLblWordsCount.Size = new System.Drawing.Size(111, 24);
            this.toolStripStatusLblWordsCount.Text = "文章字数：0";
            // 
            // ArticleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 1458);
            this.Controls.Add(this.statusStripArceditBottom);
            this.Controls.Add(this.gboxOtherOption);
            this.Controls.Add(this.gboxParams);
            this.Controls.Add(this.gboxAutopageType);
            this.Controls.Add(this.gboxPageSpliter);
            this.Controls.Add(this.gboxImageListView);
            this.Controls.Add(this.gboxArcPics);
            this.Controls.Add(this.gboxWebBrowser);
            this.Controls.Add(this.gboxListViewPubtype);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gboxPubTypename);
            this.Controls.Add(this.gboxArcEdit);
            this.Name = "ArticleEditForm";
            this.Text = "ArticleEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArticleEditForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArticleEditForm_FormClosed);
            this.Load += new System.EventHandler(this.ArticleEditForm_Load);
            this.gboxWebBrowser.ResumeLayout(false);
            this.gboxArcPics.ResumeLayout(false);
            this.gboxArcPics.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gboxImageListView.ResumeLayout(false);
            this.gboxPubTypename.ResumeLayout(false);
            this.gboxPubTypename.PerformLayout();
            this.gboxListViewPubtype.ResumeLayout(false);
            this.gboxArcEdit.ResumeLayout(false);
            this.gboxArcEdit.PerformLayout();
            this.gboxPageSpliter.ResumeLayout(false);
            this.gboxPageSpliter.PerformLayout();
            this.gboxAutopageType.ResumeLayout(false);
            this.gboxAutopageType.PerformLayout();
            this.gboxParams.ResumeLayout(false);
            this.gboxParams.PerformLayout();
            this.gboxOtherOption.ResumeLayout(false);
            this.gboxOtherOption.PerformLayout();
            this.statusStripArceditBottom.ResumeLayout(false);
            this.statusStripArceditBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Manina.Windows.Forms.ImageListView imageListView;
        private System.Windows.Forms.GroupBox gboxImageListView;
        private System.Windows.Forms.ComboBox cboxThumbSize;
        private System.Windows.Forms.Label lblThumbSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem x200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x120ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x96ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton clearThumbsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton detailsToolStripButton;
        private System.Windows.Forms.ToolStripButton paneToolStripButton;
        private System.Windows.Forms.ToolStripButton galleryToolStripButton;
        private System.Windows.Forms.ToolStripButton thumbnailsToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cboxPicType;
        private System.Windows.Forms.Label lblPicType;
        private System.Windows.Forms.GroupBox gboxArcPics;
        private System.Windows.Forms.GroupBox gboxWebBrowser;
        private System.Windows.Forms.WebBrowser webBrowserArcContent;
        private System.Windows.Forms.GroupBox gboxListViewPubtype;
        private System.Windows.Forms.ColumnHeader pub_type_items;
        private System.Windows.Forms.ColumnHeader pub_typename;
        private System.Windows.Forms.ColumnHeader pub_typeid;
        private ArcDB.ListViewNF listViewPubTypeinfo;
        private System.Windows.Forms.TextBox tboxPubTypename;
        private System.Windows.Forms.Label lblPubTypename;
        private System.Windows.Forms.Label lblSearchPubTypename;
        private System.Windows.Forms.TextBox tboxSearchPubTypename;
        private System.Windows.Forms.Label lblPubTypeid;
        private System.Windows.Forms.TextBox tboxPubTypeid;
        private System.Windows.Forms.Button btnSearchPubTypename;
        private System.Windows.Forms.GroupBox gboxPubTypename;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSaveArticle;
        private System.Windows.Forms.Button btnPublishArticle;
        private System.Windows.Forms.Label lblArticleTitle;
        private System.Windows.Forms.TextBox tboxArticleTitle;
        private System.Windows.Forms.Label lblArticleKeywords;
        private System.Windows.Forms.TextBox tboxArticleKeywords;
        private System.Windows.Forms.Label lblArticleDescription;
        private System.Windows.Forms.TextBox tboxArticleDescription;
        private System.Windows.Forms.Label lblArticleTypename;
        private System.Windows.Forms.TextBox tboxAticleTypename;
        private System.Windows.Forms.Label lblArticleLitpicURL;
        private System.Windows.Forms.TextBox tboxArticleLitpicURL;
        private System.Windows.Forms.GroupBox gboxArcEdit;
        private System.Windows.Forms.GroupBox gboxPageSpliter;
        private System.Windows.Forms.RadioButton radioBtnHandpage;
        private System.Windows.Forms.RadioButton radioBtnAutopage;
        private System.Windows.Forms.GroupBox gboxAutopageType;
        private System.Windows.Forms.RadioButton radioBtnAutopagebyImages;
        private System.Windows.Forms.RadioButton radioBtnAutopagebyWords;
        private System.Windows.Forms.GroupBox gboxParams;
        private System.Windows.Forms.Label lblPageParams;
        private System.Windows.Forms.TextBox tboxAutopageParams;
        private System.Windows.Forms.GroupBox gboxOtherOption;
        private System.Windows.Forms.CheckBox checkBoxClearFormat;
        private System.Windows.Forms.CheckBox checkBoxOnlyImages;
        private System.Windows.Forms.RadioButton radioBtnOriginPage;
        private System.Windows.Forms.Button btnResetEditorContent;
        private System.Windows.Forms.Button btnClearPageSeparator;
        private System.Windows.Forms.StatusStrip statusStripArceditBottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblImgCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblWordsCount;
        private System.Windows.Forms.Label lblCmsType;
        private System.Windows.Forms.ComboBox cboxCmsType;
        private System.Windows.Forms.Button btnDisableArticle;
    }
}