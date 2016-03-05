using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpMysql;
using System.Threading;
using HtmlAgilityPack;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Manina.Windows.Forms;
using System.Runtime.InteropServices;

namespace ArcEdit
{
    [ComVisible(true)]
    public partial class ArticleEditForm : Form
    {
        #region Custom Item Adaptor
        /// <summary>
        /// A custom item adaptor.
        /// </summary>
        private class CustomAdaptor : ImageListView.ImageListViewItemAdaptor
        {
            public override Image GetThumbnail(object key, Size size, UseEmbeddedThumbnails useEmbeddedThumbnails, bool useExifOrientation, bool useWIC)
            {
                string file = key as string;
                if (!string.IsNullOrEmpty(file))
                {
                    using (Image img = Image.FromFile(file))
                    {
                        Bitmap thumb = new Bitmap(img, size);
                        return thumb;
                    }
                }

                return null;
            }
            public override string GetUniqueIdentifier(object key, Size size, UseEmbeddedThumbnails useEmbeddedThumbnails, bool useExifOrientation, bool useWIC)
            {
                return (string)key;
            }
            public override string GetSourceImage(object key)
            {
                string file = key as string;
                return file;
            }

            public override Utility.Tuple<ColumnType, string, object>[] GetDetails(object key, bool useWIC)
            {
                throw new NotImplementedException();
            }

            public override void Dispose()
            {
                ;
            }
        }
        #endregion
        string[] files;
        CustomAdaptor adaptor;
        ImageListView.ImageListViewItemAdaptor uriAdaptor;

        private readonly string _RootPath = Application.StartupPath + @"\";                                            //程序根目录
        private string _thumbRootPath = Application.StartupPath + @"\temp\thumb\";                          //文章缩略图保存主目录
        private string _imgRootPath = Application.StartupPath + @"\temp\img\";                                   //文章缩略图保存主目录
        private int _aid=0;                                                                                                                           //文章在采集库中的ID
        private string _coConnString;                                                                                                          //采集数据库mysql连接配置参数
        private string _pubConnString;                                                                                                       //CMS数据库mysql连接配置参数
        private string _pubTablePrename;                                                                                                  //CMS数据表中的表前缀，如果有的话
        private int _arcCoTypeid = 0;                                                                                                          //文章所属采集分类ID
        private string _arcCoTypename;                                                                                                      //文章所属采集分类名称
        private string _arcTitle;                                                                                                                    //文章标题
        private string _arcLitpic;                                                                                                                  //文章缩略图URL
        private int _arcLitpicID;                                                                                                                   //当前修改的文章缩略图ID
        private int _arcPiCount;                                                                                                                   //文章包含图片数量
        private string _arcSourceSite;                                                                                                          //文章采集来源
        private string _arcKeywords;                                                                                                          //文章关键词
        private string _arcDescription;                                                                                                         //文章概要
        private string _arcContent;                                                                                                              //文章内容
        private string _arcUsedbyPc;                                                                                                           //文章是否已发布
        private int _arcCmsAid=0;                                                                                                               //文章发布后对于在CMS中的文章ID
        private int _arcPubTypeid=0;                                                                                                          //当前选中发布分类ID
        private string _arcPubTypename;                                                                                                    //当前选中发布分类名称
        private string _pubFilterKeywords;
        private List<Dictionary<string,string>> _arcPicUrls;                                                                       //保存文章所有图片URL信息，每个元素的key为图片在arc_pics表中的ID 
        private Dictionary<string,Dictionary<string,Dictionary<string,string>>> _dicArcThumbs;           //保存文章所有缩略图信息      
        private Dictionary<string, Dictionary<string, string>> _dicArcPics;                                               //保存文章中所有的图片信息
        private List<string> _cfgThumbSizeList;                                                        //需要生成多种规格缩略图所指定的宽度，此数据从数据库sys_config表cfg_thumb_size记录中获取，比如158*140表示宽158，高140，指定宽高则按Cut模式生成缩略图，只指定宽的话则按等比宽度生成。多种规格使用“|”分隔
        private int _cfgThumbWidthDefault = 0;                                                    //生成缩略图时设置的缩略图宽度，当从数据库中获取不到缩略图尺寸设置时使用
        private int _cfgThumbHeightDefault = 0;                                                   //生成缩略图时设置的缩略图高度，当从数据库中获取不到缩略图尺寸设置时使用
        private int _thumbDownloadedCount = 0;                                                 //记录成功下载的缩略图数量
        private int _imgDownloadedCount = 0;                                                     //记录成功下载的文章图片数量
        private int _thumbTotalCount = 0;                                                             //文章中缩略图总数
        private int _imgTotalCount = 0;                                                                 //文章中图片总数
        private int _thumbRequestFinished = 0;                                                    //异步下载缩略图片完成下载请求数量
        private int _imgRequestFinished = 0;                                                         //异步下载文章图片完成下载请求数量
        System.Threading.Timer _timerDownload;                                                //监控图片下载
        private Dictionary<string,Dictionary<string, string>> _thumbDownloadResult;           //保存缩略图下载结果
        private Dictionary<string, Dictionary<string, string>> _imgDownloadResult;               //保存文章图片下载结果

        private CancellationTokenSource cancelTokenSource;

        public ArticleEditForm(string coConnString, string pubConnString, int aid,string pubTablePrename, System.Windows.Forms.Form ParentForm)
        {
            _coConnString = coConnString;
            _pubConnString = pubConnString;
            _pubTablePrename = pubTablePrename;
            _aid = aid;
            _arcLitpicID = 0;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(ParentForm.Location.X + 350, ParentForm.Location.Y + 200);
            cboxThumbSize.Enabled = false;
            cboxPicType.Enabled = false;
            webBrowserArcContent.Url= new System.Uri(_RootPath + @"kindeditor\e.html", System.UriKind.Absolute);
            webBrowserArcContent.ObjectForScripting = this;
            string cacheDir = _RootPath + "cache";
            if (!Directory.Exists(cacheDir))
            {
                Directory.CreateDirectory(cacheDir);
            }
            imageListView.PersistentCacheDirectory = cacheDir;
            imageListView.Columns.Add(ColumnType.Name);
            imageListView.Columns.Add(ColumnType.Dimensions);
            imageListView.Columns.Add(ColumnType.FileSize);
            imageListView.Columns.Add(ColumnType.FolderName);

        }

        #region 控件事件触发方法
        //ArticleEditForm 加载事件触发
        private void ArticleEditForm_Load(object sender, EventArgs e)
        {
            loadPubTypeInfo(); //加载CMS分类信息
            loadArticleContents();
            downloadAllpic();
        }

        //当选中listViewPubTypeinfo中的分类项的时候，讲表单中CMS分类ID和CMS分类名称更新为选中的值
        private void listViewPubTypeinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewPubTypeinfo.FocusedItem != null)
                {
                    ListViewItem selectedItem = listViewPubTypeinfo.SelectedItems[0];
                    tboxPubTypeid.Text = selectedItem.SubItems[0].Text;
                    tboxPubTypename.Text = selectedItem.SubItems[1].Text;
                    _arcPubTypename = selectedItem.SubItems[1].Text;
                    _arcPubTypeid = 0;
                    if (int.TryParse(selectedItem.SubItems[0].Text,out _arcPubTypeid))
                    {
                        _arcPubTypeid = int.Parse(selectedItem.SubItems[0].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }



        private void thumbnailsToolStripButton_Click(object sender, EventArgs e)
        {
            imageListView.View = Manina.Windows.Forms.View.Thumbnails;

        }

        private void galleryToolStripButton_Click(object sender, EventArgs e)
        {
            imageListView.View = Manina.Windows.Forms.View.Gallery;
        }

        private void paneToolStripButton_Click(object sender, EventArgs e)
        {
            imageListView.View = Manina.Windows.Forms.View.Pane;
        }

        private void detailsToolStripButton_Click(object sender, EventArgs e)
        {
            imageListView.View = Manina.Windows.Forms.View.Details;
        }

        private void x96ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageListView.ThumbnailSize = new Size(96, 96);
        }

        private void x120ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageListView.ThumbnailSize = new Size(120, 120);
        }

        private void x200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageListView.ThumbnailSize = new Size(200, 200);
        }

        private void imageListView_SelectionChanged(object sender, EventArgs e)
        {
            ImageListViewItem sel = null;
            if (imageListView.SelectedItems.Count > 0)
            {
                sel = imageListView.SelectedItems[0];
                string selPicFullpath = sel.FileName;
                string selPicFilename = Path.GetFileName(selPicFullpath);
                if (cboxPicType.Text=="缩略图")
                {
                    string thumbSize = cboxThumbSize.Text;
                    string thumbURL = _dicArcThumbs[thumbSize][selPicFilename]["thumb_url"];
                    string pid = _dicArcThumbs[thumbSize][selPicFilename]["pid"];
                    if (int.TryParse(pid,out _arcLitpicID))
                    {
                        tboxArticleLitpicURL.Text = thumbURL;
                    }
                }
                else if (cboxPicType.Text=="文章图片")
                {

                }
            }
        }

        private void cboxPicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPicType.Text=="缩略图")
            {
                cboxThumbSize.Enabled = true;
                displayArcPics("缩略图");
            }
            else if (cboxPicType.Text== "文章图片")
            {
                cboxThumbSize.Enabled = false;
                displayArcPics("文章图片");
            }
            
        }

        private void cboxThumbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayArcPics("缩略图");
        }

        #endregion 控件事件触发方法结束


        #region 文章内容处理相关方法

        //加载发布分类信息
        private void loadPubTypeInfo(string searchCondition = "")
        {
            listViewPubTypeinfo.Items.Clear();
            mySqlDB myDB = new mySqlDB(_pubConnString);
            string sResult = "";
            int counts = 0;
            string sql = "select catid,catname,items from " + _pubTablePrename + "_category where parentid <> 0 and modelid=1";
            if (searchCondition != "")
            {
                sql = sql + " and catname like '%" + searchCondition + "%'";
            }
            List<Dictionary<string, object>> listPubTypeinfo = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult == mySqlDB.SUCCESS && counts > 0)
            {
                listViewPubTypeinfo.BeginUpdate();
                foreach (Dictionary<string, object> item in listPubTypeinfo)
                {
                    List<string> subItems = new List<string>();
                    foreach (KeyValuePair<string, object> kvp in item)
                    {
                        subItems.Add(kvp.Value.ToString());
                    }
                    ListViewItem listItem = new ListViewItem(subItems.ToArray());
                    listViewPubTypeinfo.Items.Add(listItem);
                }
                listViewPubTypeinfo.EndUpdate();
                listViewPubTypeinfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                if (counts == 0)
                {
                    MessageBox.Show(string.Format("未找到搜索的分类!"));

                }
                else
                {
                    MessageBox.Show(string.Format("加载采集分类数据出错!：{0}", sResult));
                }
            }
        }

        //加载文章内容
        private void loadArticleContents()
        {
            mySqlDB myDB = new mySqlDB(_coConnString);
            string sResult = "";
            int counts = 0;
            string sql = "select type_id,pic_count,litpic,title,source_site,keywords,description,content from arc_contents where aid = '" + _aid.ToString() + "'";
            List<Dictionary<string, object>> articleContentsInfo = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult == mySqlDB.SUCCESS && counts > 0)
            {
                _arcCoTypeid = int.Parse(articleContentsInfo[0]["type_id"].ToString());
                _arcPiCount = int.Parse(articleContentsInfo[0]["pic_count"].ToString());
                _arcLitpic = articleContentsInfo[0]["litpic"].ToString();
                _arcSourceSite = articleContentsInfo[0]["source_site"].ToString();
                _arcKeywords = articleContentsInfo[0]["keywords"].ToString();
                _arcDescription = articleContentsInfo[0]["description"].ToString();
                _arcContent = articleContentsInfo[0]["content"].ToString();
                _arcTitle = articleContentsInfo[0]["title"].ToString();
                tboxArticleTitle.Text = _arcTitle;
                tboxArticleLitpicURL.Text = _arcLitpic;
                tboxArticleKeywords.Text = _arcKeywords;
                tboxArticleDescription.Text = _arcDescription;
                //tboxArticleContent.Text = _arcContent;
                tboxAticleTypename.Text = _arcCoTypeid.ToString();
            }
            else
            {
                MessageBox.Show("加载文章内容出错！");
            }

        }

        //图片下载完毕后，初始化缩略图规格选择控件和图片类型选择控件
        private void initLoadPictures()
        {
            cboxThumbSize.SelectedIndex = 0;
            cboxPicType.SelectedIndex = 0;
        }

        private void loadImgListView(DirectoryInfo path)
        {
            imageListView.Items.Clear();
            imageListView.SuspendLayout();
            int i = 0;
            foreach (FileInfo p in path.GetFiles("*.*"))
            {
                if (p.Name.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".ico", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".cur", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".emf", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".wmf", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".tif", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                {
                    imageListView.Items.Add(p.FullName);
                }
            }
            imageListView.ResumeLayout();
        }

        //在选择图片的imageListView控件中显示选择的类型和规格的图片
        private void displayArcPics(string picType)
        {
            if (picType=="文章图片")
            {
                if (_dicArcPics!=null)
                {
                    string currentImgPath=_imgRootPath+_aid.ToString()+@"\";
                    if (Directory.Exists(currentImgPath))
                    {
                        DirectoryInfo dir = new DirectoryInfo(currentImgPath);
                        loadImgListView(dir);
                    }
                }
            }
            else if (picType=="缩略图")
            {
                if (_dicArcThumbs!=null)
                {
                    string thumbSize = cboxThumbSize.Text;
                    string currentThumbPath = _thumbRootPath + thumbSize + @"\" + _aid.ToString() + @"\";
                    if (Directory.Exists(currentThumbPath))
                    {
                        DirectoryInfo dir = new DirectoryInfo(currentThumbPath);
                        loadImgListView(dir);
                    }
                }
            }

        }


        #endregion 文章内容处理完成

        #region 编辑器相关方法



        //将_arcContent变量中的内容传递给编辑器中, 编辑器加载的时候执行
        public string GetContent()
        {
            return _arcContent;
        }

        //当编辑器内容修改时将编辑器中修改后的内容更新到_arcContent变量
        public void RequestContent(string str)
        {
            _arcContent = str;
            tboxArticleDescription.Text = _arcContent;
        }

        //将当前_arcContent变量中的内容更新到编辑器中的内容
        public void SetEditorContent()
        {
            webBrowserArcContent.Document.InvokeScript("setContent", new object[] { _arcContent });
        }


        #endregion  编辑器相关方法结束


        #region 文章图片处理区域

        //获取缩略图规格参数
        private void getThumbSize()
        {
            mySqlDB myDB = new mySqlDB(_coConnString);
            string sResult = "";
            int counts = 0;
            List<Dictionary<string, object>> dbResult;
            string sql;
            //读取默认生成缩略图宽度参数
            sql = "select value from sys_config where varname='cfg_thumb_width'";
            dbResult = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult == mySqlDB.SUCCESS && counts > 0)
            {
                string temp = dbResult[0]["value"].ToString();
                if (int.TryParse(temp, out _cfgThumbWidthDefault))
                {
                    _cfgThumbWidthDefault = int.Parse(temp);
                }
                else
                    _cfgThumbWidthDefault = 300;
            }
            else
                _cfgThumbWidthDefault = 300;
            //读取默认生成缩略图高度参数
            sql = "select value from sys_config where varname='cfg_thumb_height'";
            dbResult = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult == mySqlDB.SUCCESS && counts > 0)
            {
                string temp = dbResult[0]["value"].ToString();
                if (int.TryParse(temp, out _cfgThumbHeightDefault))
                {
                    _cfgThumbHeightDefault = int.Parse(temp);
                }
                else
                    _cfgThumbHeightDefault = 300;
            }
            else
                _cfgThumbHeightDefault = 300;


            //读取生成多种规格缩略图宽度参数
            sql = "select value from sys_config where varname='cfg_thumb_size'";
            dbResult = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult == mySqlDB.SUCCESS && counts > 0)
            {
                string temp = dbResult[0]["value"].ToString();
                string[] tempSizeArr = temp.Split('|');
                _cfgThumbSizeList = tempSizeArr.ToList();

            }  //读取生成多种规格缩略图宽度参数结束
        }

        //从数据库获取文章图片URL等参数
        private void getArcpicUrls()
        {
            mySqlDB myDB = new mySqlDB(_coConnString);
            string sResult = "";
            int counts = 0;
            string sql = "select pid,pic_url,pic_path from arc_pics where aid='" + _aid.ToString() + "'";
            List<Dictionary<string, object>> dbResult = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult==mySqlDB.SUCCESS && counts>0)
            {
                _arcPicUrls = new List<Dictionary<string, string>>();
                foreach (Dictionary<string,object> item in dbResult)
                {
                    Dictionary<string, string> picInfo = new Dictionary<string, string>();
                    picInfo["pid"] = item["pid"].ToString();
                    picInfo["pic_url"] = item["pic_url"].ToString();
                    picInfo["extenstion"] = Path.GetExtension(item["pic_path"].ToString());
                    picInfo["short_filename"] = Path.GetFileNameWithoutExtension(item["pic_path"].ToString());
                    picInfo["full_filename"] = Path.GetFileName(item["pic_path"].ToString());
                    _arcPicUrls.Add(picInfo);
                }
            }
            else
            {
                MessageBox.Show("获取文章图片出错！请检查数据库连接是否正确！");
            }
        }

        //根据缩略图规格参数和文章图片获取指定规格的缩略图列表，缩略图的名字使用编号来命名，用于将远程图片下载到当前程序的本地目录
        private void  getDicArcThumbs(string thumbSize,ref Dictionary<string, Dictionary<string, Dictionary<string, string>>>arcThumbs)
        {
            int picCount = 0;
            Dictionary<string, Dictionary<string, string>> dicLocalPics = new Dictionary<string, Dictionary<string, string>>();
            char[] separator = { 'x', 'X' };
            string[] sizeArr = thumbSize.Split(separator);
            string width = sizeArr[0];
            foreach (Dictionary<string, string> arcPic in _arcPicUrls)
            {
                picCount++;
                Dictionary<string, string> dicPicInfo = new Dictionary<string, string>();
                string localPicFilename = picCount.ToString() + arcPic["extenstion"];
                dicPicInfo.Add("pid", arcPic["pid"]);
                dicPicInfo.Add("pic_url", arcPic["pic_url"]);
                string thumbUrl = arcPic["pic_url"].Replace(@"http://img", @"http://thumb");
                string thumbFilename = arcPic["short_filename"] + "." + width + arcPic["extenstion"];
                thumbUrl = thumbUrl.Replace(arcPic["full_filename"],thumbFilename);
                dicPicInfo.Add("thumb_url", thumbUrl);
                dicLocalPics.Add(localPicFilename, dicPicInfo);
            }
            arcThumbs.Add(thumbSize, dicLocalPics);
        }

        //监控缩略图是否下载完毕
        private void downloadWath(object state)
        {
            if ((_thumbRequestFinished==_thumbTotalCount) && (_imgRequestFinished == _imgTotalCount))
            {
                /*
                tboxArticleContent.AppendText(string.Format("Total download thumbs: {0} \n",_thumbDownloadedCount));
                foreach (KeyValuePair<string,Dictionary<string,string>> downloadResult in _thumbDownloadResult)
                {
                    tboxArticleContent.AppendText(string.Format("Url:{0} \n", downloadResult.Key));
                    foreach (KeyValuePair<string,string> item in downloadResult.Value)
                    {
                        tboxArticleContent.AppendText(string.Format("{0} :  {1} \n", item.Key, item.Value));
                    }
                    tboxArticleContent.AppendText("----------------------------------------------------\n");
                }
                */
                cboxThumbSize.Enabled = true;
                cboxPicType.Enabled = true;
                initLoadPictures();
                _timerDownload.Dispose();
            }
        }


        //开始下载缩略图和文章图片前初始化相关下载变量的方法
        private void initDownload()
        {
            _thumbTotalCount = 0;
            _imgTotalCount = 0;
            _thumbDownloadedCount = 0;
            _thumbRequestFinished = 0;
            _imgRequestFinished = 0;
            _imgDownloadedCount = 0;

            if (_arcPicUrls != null)
            {
                _imgTotalCount = _arcPicUrls.Count;   //初始文章图片总数
                _dicArcThumbs = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();  //初始保存缩略图信息的dic数组
                _dicArcPics = new Dictionary<string, Dictionary<string, string>>(); //初始保存文章图片的dic数组
                _thumbDownloadResult = new Dictionary<string, Dictionary<string, string>>();
                _imgDownloadResult = new Dictionary<string, Dictionary<string, string>>();

                //初始化缩略下载相关变量
                getThumbSize();  //从数据库获取缩略图规格参数
                cboxThumbSize.Items.Clear();
                if (_cfgThumbSizeList != null)
                {
                    foreach (string thumbSize in _cfgThumbSizeList)
                    {
                        _thumbTotalCount += _imgTotalCount;
                        cboxThumbSize.Items.Add(thumbSize);
                        getDicArcThumbs(thumbSize, ref _dicArcThumbs); //根据规格参数获取文章图片对应的缩略图列表
                    }
                }
                else
                {
                    string thumbSize = _cfgThumbWidthDefault.ToString() + "x" + _cfgThumbHeightDefault.ToString();
                    getDicArcThumbs(thumbSize, ref _dicArcThumbs);
                }

                //初始化文章图片下载相关变量
                int picCount = 0;
                foreach (Dictionary<string, string> arcPic in _arcPicUrls)
                {
                    picCount++;
                    string localPicFilename = picCount.ToString() + arcPic["extenstion"];
                    _dicArcPics.Add(localPicFilename, arcPic);
                }

                //开启计时器
                _timerDownload = new System.Threading.Timer(
                        downloadWath,              //TimerCallBack委托对象，负责具体监控的方法
                        null,                 //想传入的参数 （null表示没有参数）
                        500,                    //在开始之前，等待多长时间（以毫秒为单位）
                        500               //每次调用的间隔时间（以毫秒为单位）
                        );

            }

        }

        // 下载所有图片
        private void downloadAllpic()
        {
            getArcpicUrls();  //获取文章中所有图片列表，此方法必须先于下载缩略图和下载文章图片运行
             //下载初始化
            initDownload();
            //调用具体负责处理下载的方法
            ThreadPool.QueueUserWorkItem(downloadLitpicAsync);
            ThreadPool.QueueUserWorkItem(downloadArcpicAsync);
            /*
            downloadLitpicAsync();
            downloadArcpicAsync();
            */

        }

        //异步下载文章缩略图
        private void downloadLitpicAsync(object state)
        {
            if (_dicArcThumbs!=null)
            {
                foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string>>> item in _dicArcThumbs)
                {
                    //tboxArticleContent.AppendText(string.Format("规格：{0}\n", item.Key));
                    string thumbSize = item.Key;
                    string currentThumbPath = _thumbRootPath + thumbSize + @"\" + _aid.ToString() + @"\";
                    if (!Directory.Exists(currentThumbPath))
                    {
                        Directory.CreateDirectory(currentThumbPath);
                    }
                    foreach (KeyValuePair<string,Dictionary<string,string>> thumbPic in item.Value)
                    {
                        //tboxArticleContent.AppendText(string.Format("    文件名：{0}\n", thumbPic.Key));
                        string localPicFilename = thumbPic.Key;
                        string localPicFullpath = currentThumbPath + localPicFilename;
                        string thumbURL = thumbPic.Value["thumb_url"];
                        if (!File.Exists(localPicFullpath))
                        {
                            AsyncMethodCaller downloadThumb = new AsyncMethodCaller(DownLoadFileSync);
                            downloadThumb.BeginInvoke(thumbURL, localPicFullpath, ThumbGetResult, null);
                        }
                        else
                        {
                            Interlocked.Add(ref _thumbRequestFinished, 1); 
                        }
                        /*
                        foreach (KeyValuePair<string,string> picInfo in thumbPic.Value)
                        {
                           // tboxArticleContent.AppendText(string.Format("        {0}：{1}\n", picInfo.Key, picInfo.Value));
                        }
                        */
                    }
                }
            }
        }

        //异步下载文章图片
        private void downloadArcpicAsync(object state)
        {
            if (_dicArcPics!=null)
            {
                string currentImgPath = _imgRootPath + _aid.ToString() + @"\";
                if (!Directory.Exists(currentImgPath))
                {
                    Directory.CreateDirectory(currentImgPath);
                }
                foreach (KeyValuePair<string,Dictionary<string,string>> arcPic in _dicArcPics)
                {
                    string localPicFilename = arcPic.Key;
                    string localPicFullpath = currentImgPath + localPicFilename;
                    string arcURL = arcPic.Value["pic_url"];
                    if (!File.Exists(localPicFullpath))
                    {
                        AsyncMethodCaller downloadArcpic = new AsyncMethodCaller(DownLoadFileSync);
                        downloadArcpic.BeginInvoke(arcURL, localPicFullpath, ArcpicGetResult, null);
                    }
                    else
                    {
                        Interlocked.Add(ref _imgRequestFinished, 1);
                    }
                }
            }
        }

        #endregion 文章图片下载处理完成


        #region 异步处理WEB资源下载

        // 定义用来实现异步编程的委托
        private delegate Dictionary<string,string> AsyncMethodCaller(string url,string localSavePath);

        // 同步下载文件的方法
        // 该方法会阻塞主线程，使用户无法对界面进行操作
        // 在文件下载完成之前，用户甚至都不能关闭运行的程序。
        private Dictionary<string,string> DownLoadFileSync(string url,string localSavePath)
        {
            // Create an instance of the RequestState 
            RequestState requestState = new RequestState(localSavePath);
            try
            {
                // Initialize an HttpWebRequest object
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                // assign HttpWebRequest instance to its request field.
                requestState.request = myHttpWebRequest;
                requestState.response = (HttpWebResponse)myHttpWebRequest.GetResponse();
                requestState.streamResponse = requestState.response.GetResponseStream();
                int readSize = requestState.streamResponse.Read(requestState.BufferRead, 0, requestState.BufferRead.Length);

                while (readSize > 0)
                {
                    requestState.filestream.Write(requestState.BufferRead, 0, readSize);
                    readSize = requestState.streamResponse.Read(requestState.BufferRead, 0, requestState.BufferRead.Length);
                }

                // 执行该方法的线程是线程池线程，该线程不是与创建richTextBox控件的线程不是一个线程
                // 如果不把 CheckForIllegalCrossThreadCalls 设置为false，该程序会出现“不能跨线程访问控件”的异常
                //return string.Format("The Length of the File is: {0}", requestState.filestream.Length) + string.Format("  DownLoad Completely, Download path is: {0}\n", requestState.savepath);
                Dictionary<string, string> downloadResult = new Dictionary<string, string>();
                downloadResult["status"] = "success";
                downloadResult["url"] = url;
                downloadResult["filepath"] = localSavePath;
                downloadResult["message"] = "";
                return downloadResult;
            }
            catch (Exception e)
            {
                //return string.Format("Exception occurs in DownLoadFileSync method, Error Message is:{0}\n", e.Message);
                if (File.Exists(localSavePath))
                {
                    requestState.filestream.Close();
                    File.Delete(localSavePath);
                }
                Dictionary<string, string> downloadResult = new Dictionary<string, string>();
                downloadResult["status"] = "fail";
                downloadResult["url"] = url;
                downloadResult["filepath"] = localSavePath;
                downloadResult["message"] = e.Message;
                return downloadResult;
            }
            finally
            {
                if (requestState.response != null)
                {
                    requestState.response.Close();
                }
                if (requestState.filestream != null)
                {
                    requestState.filestream.Close();
                }
            }
        }

        // 缩略图异步下载操作完成时执行的方法
        private object downloadLock = new object();
        private void ThumbGetResult(IAsyncResult result)
        {
            AsyncMethodCaller caller = (AsyncMethodCaller)((AsyncResult)result).AsyncDelegate;
            // 调用EndInvoke去等待异步调用完成并且获得返回值
            // 如果异步调用尚未完成，则 EndInvoke 会一直阻止调用线程，直到异步调用完成
            Dictionary<string,string>downloadResult  = caller.EndInvoke(result);
            lock (downloadLock)
            {
                string url = downloadResult["url"];
                _thumbDownloadResult.Add(url,downloadResult);
                if (downloadResult["status"]=="success")
                {
                    _thumbDownloadedCount++;
                }
            }
            Interlocked.Add(ref _thumbRequestFinished, 1);  //使用原子锁形式将请求处理数+1
        }
        //文章图片异步下载操作完成时执行的方法
        private void ArcpicGetResult(IAsyncResult result)
        {
            AsyncMethodCaller caller = (AsyncMethodCaller)((AsyncResult)result).AsyncDelegate;
            // 调用EndInvoke去等待异步调用完成并且获得返回值
            // 如果异步调用尚未完成，则 EndInvoke 会一直阻止调用线程，直到异步调用完成
            Dictionary<string, string> downloadResult = caller.EndInvoke(result);
            lock (downloadLock)
            {
                string url = downloadResult["url"];
                _imgDownloadResult.Add(url, downloadResult);
                if (downloadResult["status"] == "success")
                {
                    _imgDownloadedCount++;
                }
            }
            Interlocked.Add(ref _imgRequestFinished, 1);  //使用原子锁形式将请求处理数+1
        }

        // This class stores the State of the request.
        public class RequestState
        {
            public int BufferSize = 2048;
            public string savepath;
            public byte[] BufferRead;
            public HttpWebRequest request;
            public HttpWebResponse response;
            public Stream streamResponse;
            public FileStream filestream;

            public RequestState(string localSavePath)
            {
                savepath = localSavePath;
                BufferRead = new byte[BufferSize];
                request = null;
                streamResponse = null;
                if (File.Exists(savepath))
                {
                    File.Delete(savepath);
                }
                filestream = new FileStream(savepath, FileMode.OpenOrCreate);
            }
        }

        #endregion

        //点击 发布分类搜索按钮
        private void btnSearchPubTypename_Click(object sender, EventArgs e)
        {
            loadPubTypeInfo(tboxSearchPubTypename.Text);
        }


    }
}
