using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SharpMysql;
using SharpConfig;
using Murmur;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcEdit
{
    public partial class MainForm : Form
    {
        private readonly string RootPath = Application.StartupPath + @"\";     //程序根目录
        private string _configFile;                                                                        //程序配置文件
        private Configuration _sysConfig;                                                           //保存配置的变量
        private string _coConnString;                                                                  //建立采集数据库连接的配置变量
        private string _pubConnString;                                                               //建立发布数据库连接的配置变量
        private string _pubTablePrename;                                                          //CMS数据库中的表前缀
        private int _selectCoTypeID = 0;                                                               //当前选中采集分类ID
        private int _displayCount = 0;                                                                //控制文章列表显示文章数量


        #region Main Form相关
        public MainForm()
        {
            InitializeComponent();
            _configFile = RootPath + "config.ini";
            CheckForIllegalCrossThreadCalls = false;
        }

        //主窗口加载时的处理
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(_configFile))
            {
                _sysConfig = Configuration.LoadFromFile(_configFile);
                loadSysconfig();
            }
            else
            {
                _sysConfig = new Configuration();
                updateSysconfig();
            }
            _coConnString = GetCoConnString();
            _pubConnString = GetPubConnString();
            if (_coConnString != "" && _pubConnString != "")
            {
                loadCoTypeInfo();  //加载采集分类信息
            }
            else
            {
                MessageBox.Show("请将集数据库和发布数据库配置信息填写完整！");
            }
        }

        //当主窗口要关闭时的处理
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("将要关闭程序，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        //主窗口关闭后的处理
        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            updateSysconfig();
            _sysConfig.SaveToFile(_configFile);
        }

        //读取配置文件中的对应配置，并且更新到相应的控件中
        private void loadSysconfig()
        {
            //采集数据库
            tboxCoHostName.Text = _sysConfig["CoDatabase"]["Hostname"].StringValue;
            tboxCoUserName.Text = _sysConfig["CoDatabase"]["Username"].StringValue;
            tboxCoDbName.Text = _sysConfig["CoDatabase"]["Dbname"].StringValue;
            tboxCoPort.Text = _sysConfig["CoDatabase"]["Port"].StringValue;
            tboxCoPassword.Text = _sysConfig["CoDatabase"]["Password"].StringValue;
            cboxCoCharset.Text = _sysConfig["CoDatabase"]["Charset"].StringValue;
            //发布数据库
            tboxPubHostName.Text = _sysConfig["PubDatabase"]["Hostname"].StringValue;
            tboxPubUserName.Text = _sysConfig["PubDatabase"]["Username"].StringValue;
            tboxPubDbName.Text = _sysConfig["PubDatabase"]["Dbname"].StringValue;
            tboxPubPort.Text = _sysConfig["PubDatabase"]["Port"].StringValue;
            tboxPubPassword.Text = _sysConfig["PubDatabase"]["Password"].StringValue;
            cboxPubCharset.Text = _sysConfig["PubDatabase"]["Charset"].StringValue;
            tboxPubTablePrename.Text = _sysConfig["PubDatabase"]["TablePrename"].StringValue;
        }

        //更新sysConfig对象中的配置参数
        private void updateSysconfig()
        {
            //采集数据库
            _sysConfig["CoDatabase"]["Hostname"].SetValue(tboxCoHostName.Text);
            _sysConfig["CoDatabase"]["Username"].SetValue(tboxCoUserName.Text);
            _sysConfig["CoDatabase"]["Dbname"].SetValue(tboxCoDbName.Text);
            _sysConfig["CoDatabase"]["Port"].SetValue(tboxCoPort.Text);
            _sysConfig["CoDatabase"]["Password"].SetValue(tboxCoPassword.Text);
            _sysConfig["CoDatabase"]["Charset"].SetValue(cboxCoCharset.Text);
            //发布数据库
            _sysConfig["PubDatabase"]["Hostname"].SetValue(tboxPubHostName.Text);
            _sysConfig["PubDatabase"]["Username"].SetValue(tboxPubUserName.Text);
            _sysConfig["PubDatabase"]["Dbname"].SetValue(tboxPubDbName.Text);
            _sysConfig["PubDatabase"]["Port"].SetValue(tboxPubPort.Text);
            _sysConfig["PubDatabase"]["Password"].SetValue(tboxPubPassword.Text);
            _sysConfig["PubDatabase"]["Charset"].SetValue(cboxPubCharset.Text);
            _sysConfig["PubDatabase"]["TablePrename"].SetValue(tboxPubTablePrename.Text);
        }

        //通过mysql配置参数生成需要建立采集数据库mysql连接的配置字符串
        private string GetCoConnString()
        {
            updateSysconfig();
            if (tboxCoDbName.Text == "" || tboxCoHostName.Text == "" || tboxCoPort.Text == "" || tboxCoUserName.Text == "" || cboxCoCharset.Text == "" || tboxCoPort.Text == "")
            {
                MessageBox.Show("请将采集数据库配置信息填写完整！", "提示！", MessageBoxButtons.OK);
                return "";
            }
            return (@"Server=" + tboxCoHostName.Text + @";DataBase=" + tboxCoDbName.Text + @";Uid=" + tboxCoUserName.Text + @";Pwd=" + tboxCoPassword.Text + @";charset=" + cboxCoCharset.Text + @";port=" + tboxCoPort.Text);
        }

        //通过mysql配置参数生成需要建立发布数据库mysql连接的配置字符串
        private string GetPubConnString()
        {
            updateSysconfig();
            _pubTablePrename = tboxPubTablePrename.Text;
            if (tboxPubDbName.Text == "" || tboxPubHostName.Text == "" || tboxPubPort.Text == "" || tboxPubUserName.Text == "" || cboxPubCharset.Text == "" || tboxPubPort.Text == "")
            {
                MessageBox.Show("请将发布数据库配置信息填写完整！", "提示！", MessageBoxButtons.OK);
                return "";
            }
            return (@"Server=" + tboxPubHostName.Text + @";DataBase=" + tboxPubDbName.Text + @";Uid=" + tboxPubUserName.Text + @";Pwd=" + tboxPubPassword.Text + @";charset=" + cboxPubCharset.Text + @";port=" + tboxPubPort.Text);
        }

        //保存配置信息到配置文件中
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            updateSysconfig();
            try
            {
                _sysConfig.SaveToFile(_configFile);
                MessageBox.Show("保存配置成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("保存配置失败！");
            }

        }
        #endregion   Main Form 相关方法结束

        #region  控件事件

        //当选中listViewCoTypeinfo中的分类项的时候，讲表单中采集分类ID和采集分类名称更新为选中的值

        // tboxDisplayArcCount内容改变事件触发
        private void tboxDisplayArcCount_TextChanged(object sender, EventArgs e)
        {
            string tempDisplayArcCount = tboxDisplayArcCount.Text;
            if (tempDisplayArcCount=="")
            {
                _displayCount = 100;
            }
            else
            {
                if (int.TryParse(tempDisplayArcCount, out _displayCount))
                {
                    _displayCount = int.Parse(tempDisplayArcCount);
                }
            }

            string searchArcTitle = tboxSearchArcTitle.Text;
            if (_selectCoTypeID != 0)
            {
                displayArticles(_selectCoTypeID, searchArcTitle, _displayCount);
            }
        }

        //只显示未编辑checkbox控件选中状态事件触发
        private void checkBoxOnlyUnedited_CheckedChanged(object sender, EventArgs e)
        {
            string searchArcTitle = tboxSearchArcTitle.Text;
            int displayCount = 0;
            if (int.TryParse(tboxDisplayArcCount.Text,out displayCount))
            {
                displayCount = int.Parse(tboxDisplayArcCount.Text);
            }
            if (checkBoxOnlyUnedited.Checked)
            {
                    displayArticles(_selectCoTypeID, searchArcTitle, displayCount,true);
            }
            else
            {
                displayArticles(_selectCoTypeID, searchArcTitle, displayCount,false);
            }

        }

        //采集分类选择项改变事件触发
        private void listViewCoTypeinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewCoTypeinfo.FocusedItem != null)
                {
                    ListViewItem selectedItem = listViewCoTypeinfo.SelectedItems[0];
                    _selectCoTypeID = int.Parse(selectedItem.SubItems[0].Text);
                    tboxSearchArcTitle.Text = "";
                    int displayArcCount = 0;
                    if (tboxDisplayArcCount.Text != "")
                    {
                        string tempDisplayArcCount = tboxDisplayArcCount.Text;
                        if (int.TryParse(tempDisplayArcCount, out displayArcCount))
                        {
                            displayArcCount = int.Parse(tempDisplayArcCount);
                        }
                    }
                    displayArticles(_selectCoTypeID, "", displayArcCount);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void listViewArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewArticles.FocusedItem != null)
                {
                    ListViewItem selectedItem = listViewArticles.SelectedItems[0];
                    int aid = 0;
                    string tempAidString = selectedItem.SubItems[0].Text;
                    if (int.TryParse(tempAidString, out aid))
                    {
                        if (aid != 0)
                        {
                            ArticleEditForm editArticleForm = new ArticleEditForm(_coConnString, _pubConnString, aid, _pubTablePrename, this);
                            editArticleForm.Text = "编辑发布文章-文章ID："+aid.ToString();
                            editArticleForm.Show();
                            this.Enabled = false;
                            editArticleForm.FormClosed += ArticleEditModify_FormClosed;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

        }


        private void ArticleEditModify_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            string searchArcTitle = tboxSearchArcTitle.Text;
            displayArticles(_selectCoTypeID, searchArcTitle, _displayCount);
        }

        #endregion 控件事件结束

        #region 选择采集分类和发布分类
        //加载采集分类信息
        private void loadCoTypeInfo(string searchCondition = "")
        {
            listViewCoTypeinfo.Items.Clear();
            mySqlDB myDB = new mySqlDB(_coConnString);
            string sResult = "";
            int counts = 0;
            string sql = "select tid,type_name,unused_nums from arc_type";
            if (searchCondition != "")
            {
                sql = sql + " where type_name like '%" + searchCondition + "%'";
            }
            List<Dictionary<string, object>> listCoTypeinfo = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult == mySqlDB.SUCCESS && counts > 0)
            {
                listViewCoTypeinfo.BeginUpdate();
                foreach (Dictionary<string, object> item in listCoTypeinfo)
                {
                    List<string> subItems = new List<string>();
                    foreach (KeyValuePair<string, object> kvp in item)
                    {
                        subItems.Add(kvp.Value.ToString());
                    }
                    ListViewItem listItem = new ListViewItem(subItems.ToArray());
                    listViewCoTypeinfo.Items.Add(listItem);
                }
                listViewCoTypeinfo.EndUpdate();
                listViewCoTypeinfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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

        #endregion 选择分类结束


        #region 获取文章内容
        private void displayArticles(int typeID, string searchArcTitle = "", int displayCount = 0,bool onlyUnEdited=false)
        {
            if (typeID!=0)
            {
                mySqlDB myDB = new mySqlDB(_coConnString);
                string sResult = "";
                int counts = 0;
                string sql = "select aid,pic_count,is_edited,title from arc_contents where usedby_pc='no' and  type_id='" + typeID.ToString() + "'";
                if (onlyUnEdited)
                {
                    sql = sql + " and is_edited='no'";
                }
                if (searchArcTitle != "")
                {
                    sql = sql + " and title like '%" + searchArcTitle + "%'";
                }
                if (displayCount!=0)
                {
                    sql = sql + " limit " + displayCount.ToString();
                }
                else
                {
                    sql = sql + " limit 100";
                }
                List<Dictionary<string, object>> listArticles = myDB.GetRecords(sql, ref sResult, ref counts);
                listViewArticles.Items.Clear();
                if (sResult == mySqlDB.SUCCESS && counts > 0)
                {
                    listViewArticles.BeginUpdate();
                    foreach (Dictionary<string, object> item in listArticles)
                    {
                        List<string> subItems = new List<string>();
                        foreach (KeyValuePair<string, object> kvp in item)
                        {
                            subItems.Add(kvp.Value.ToString());
                        }
                        ListViewItem listItem = new ListViewItem(subItems.ToArray());
                        listViewArticles.Items.Add(listItem);
                    }
                    listViewArticles.EndUpdate();
                    listViewArticles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                else
                {
                    if (counts==0)
                    {
                        //MessageBox.Show("当前分类没有可发布文章！");
                    }
                    else
                    {
                        MessageBox.Show("获取文章出错！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择文章分类！");
            }

        }

        #endregion

  

        //点击 采集分类搜索按钮
        private void btnSearchCoTypename_Click(object sender, EventArgs e)
        {
            loadCoTypeInfo(tboxSearchCoTypename.Text);

        }


        //点击 搜索文章标题按钮
        private void btnSearchArcTitle_Click(object sender, EventArgs e)
        {
            if (_selectCoTypeID!=0 && tboxSearchArcTitle.Text!="")
            {
                int displayArcCount = 0;
                string tempDisplayArcCount = tboxDisplayArcCount.Text;
                if (int.TryParse(tempDisplayArcCount, out displayArcCount))
                {
                    displayArcCount = int.Parse(tempDisplayArcCount);
                }
                displayArticles(_selectCoTypeID, tboxSearchArcTitle.Text, displayArcCount);
            }
        }


    }
}
