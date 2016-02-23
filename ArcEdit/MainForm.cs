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


    }
}
