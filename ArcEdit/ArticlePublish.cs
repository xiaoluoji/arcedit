using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using SharpMysql;
using System.Text.RegularExpressions;


namespace ArcEdit
{
    class ArticlePublish
    {
        #region Fields

        private string _coConnString;                                           //采集数据库连接配置
        private string _pubConnString;                                        //发布数据库连接配置
        private string _pubTablePrename;                                   //发布数据库表前缀
        private string _cmsType;                                                  //发布CMS类型
        private int _aid;                                                                //发布文章ID，如果是人工发布，则需要指定文章ID
        private int _coTypeid;                                                      //采集文章分类
        private int _pubTypeid;                                                    //发布文章分类
        private int _pubNums;                                                     //发布数量
        private string _randomDateStart;                                    //随机发布时间的随机区间开始，如果参数为空则发布日期使用当前日期
        private string _randomDateStop;                                    //随机发布时间的随机区间结束，
        private bool _isRecordError;                                           //是否开启错误记录
        private CancellationTokenSource _cancelTokenSource;  //用来获取取消事件的对象
        private string _pubState = "";                                         //保存当前采集状态
        private int _exportedArticleNums = 0;                            //保存当前已经储存到数据库的采集文章数
        private List<Exception> _pubExceptions;                       //记录异常错误
        private Exception _cancelException;                               //出发取消任务时候的取消异常
        private long _lastExportedCoid;                                     //最后导出的采集文章ID
        private long _lastExportedCmsid;                                  //最后导出的CMS文章ID


        #endregion

        #region Constructors
        public ArticlePublish(string coConnString,string pubConnString,string pubTablePrename, string cmsType,int pubNums=0, string randomDateStart="",string randomDateStop="",int aid=0)
        {
            _coConnString = coConnString;
            _pubConnString = pubConnString;
            _pubTablePrename = pubTablePrename;
            _cmsType = cmsType;
            _aid = aid;
            _pubNums = pubNums;
            _randomDateStart = randomDateStart;
            _randomDateStop = randomDateStop;
            _pubExceptions = new List<Exception>();
            _lastExportedCoid = -1;
            _lastExportedCmsid = -1;
            _cancelTokenSource = new CancellationTokenSource();
        }
        #endregion Constructors

        #region Properties

        //采集分类ID
        public int CoTypeID
        {
            get { return _coTypeid; }
        }

        //获取或修改是否保存错误异常
        public bool IsRecordError
        {
            get { return _isRecordError; }
            set
            {
                _isRecordError = value;
            }
        }

        //获取或修改取消令牌
        public CancellationTokenSource CancelTokenSource
        {
            get { return _cancelTokenSource; }
            set
            {
                _cancelTokenSource = value;
            }
        }
        //返回采集错误异常集合
        public List<Exception> PubException
        {
            get { return _pubExceptions; }
        }
        //返回取消异常
        public Exception CancelException
        {
            get { return _cancelException; }
        }

        //当前导出文章数量
        public int CurrentExportedArticles
        {
            get { return _exportedArticleNums; }
        }

        //当前发布状态
        public string PubState
        {
            get { return _pubState; }
            set { _pubState = value; }
        }
        //最后导出的采集文章ID
        public long LastExportedCoid
        {
            get { return _lastExportedCoid; }
        }
        //最后导出的CMS文章ID
        public long LastExportedCmsid
        {
            get { return _lastExportedCmsid; }
        }

        #endregion


        //通过datetime变量获取unix时间戳
        private long getUnixTime(DateTime dt)
        {
            TimeSpan ts;
            ts = dt.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0);
            return (long)ts.TotalSeconds;
        }

        //通过_randomDateStart 和randomDateStop获取随机发布时间，时间的范围是早上9点到晚上8点，及模拟正常的工作时间
        private long getRandomPubDate()
        {
            long pubDateUnixtime = 0;
            try
            {
                DateTime randomDateStart = DateTime.Parse(_randomDateStart);
                DateTime randomDateStop = DateTime.Parse(_randomDateStop);
                DateTime pubDate = DateTime.Parse(_randomDateStart);
                TimeSpan ts = randomDateStop - randomDateStart;
                int rndDays = (int)ts.TotalDays;
                double rndD;
                Random ran = new Random();
                if (rndDays!=0)
                {
                    rndD = ran.Next(0, rndDays);
                }
                else
                {
                    rndD = 0;
                }
                double rndM = ran.Next(0, 60);
                double rndH = ran.Next(9, 20);
                double rndS = ran.Next(0, 60);
                pubDate = pubDate.AddDays(rndD);
                pubDate = pubDate.AddHours(rndH);
                pubDate = pubDate.AddMinutes(rndM);
                pubDate = pubDate.AddSeconds(rndS);
                pubDateUnixtime = getUnixTime(pubDate);
                return pubDateUnixtime;
            }
            catch (Exception ex)
            {
                _pubExceptions.Add(ex);
                return pubDateUnixtime;
            }
        }


        //随机获取一条符合发布条件的文章记录
        private Dictionary<string,object> getOneRecord()
        {
            List<Dictionary<string, object>> dbResult;
            mySqlDB myDB = new mySqlDB(_coConnString);
            string sResult = "";
            int counts = 0;
            //查寻符合发布条件的文章记录，满足条件必须包括 is_edited字段为yes, usedby_pc字段为no, cms_typeid字段不能为null, 如果传入参数aid，则查寻指定aid的文章
            string sql = "select aid,litpic,title,type_id,cms_typeid,source_site,description,keywords,content from arc_contents where is_edited='yes' and usedby_pc='no' and cms_typeid<>'null'";
            if (_aid!=0)
            {
                sql = sql + " and aid='" + _aid.ToString() + "'";
            }
            else
            {
                sql = sql + " order by aid limit 1";
            }

            dbResult = myDB.GetRecords(sql, ref sResult, ref counts);
            if (sResult==mySqlDB.SUCCESS && counts>0)
            {
                return dbResult[0];
            }
            else
            {
                if (sResult!=mySqlDB.SUCCESS)
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "获取未发布文章错误");
                    _pubExceptions.Add(ex);
                }
                if (counts==0)
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("提示信息", "没有可发布的文章");
                    _cancelException = ex;
                }
                return null;
            }
        }

        //处理文章分页
        private List<string> getPageContent(string arcContent)
        {
            Regex regSplit = new Regex("<hr.*?class=[^>]*>");
            string[] pageContent = regSplit.Split(arcContent);
            return pageContent.ToList();
        }

        //导出一篇文章到CMS中
        private bool exportOneRecord(Dictionary<string, object> coArticle,ref long cmsAid)
        {
            cmsAid = -1;                            //news表中插入记录后的ID值
            string title = coArticle["title"].ToString();
            string litpic = coArticle["litpic"].ToString();
            string sourceSite = coArticle["source_site"].ToString();
            string content = coArticle["content"].ToString();
            string keywords = coArticle["keywords"].ToString();
            string description = coArticle["description"].ToString();
            string username = "admin";
            List<string> pageContent = new List<string>();
            Regex regSplit = new Regex("<hr.*?class=[^>]*>");
            //获取文章内容字段，处理文章分页信息
            if (regSplit.IsMatch(content))
            {
                pageContent = getPageContent(content);
            }
            //获取发布时间
            long pubDateUnixtime = 0;
            if (_randomDateStart != "" && _randomDateStop != "")
            {
                pubDateUnixtime = getRandomPubDate();
            }
            else
            {
                DateTime currentTime = DateTime.Now;
                pubDateUnixtime = getUnixTime(currentTime);
            }

            //创建mysql连接对象
            mySqlDB pubMyDB = new mySqlDB(_pubConnString);
            string sResult = "";
            int counts = 0;

            //如果发布CMS为phpcms
            if (_cmsType=="phpcms")
            {
                string url = "";
                string status = "99";
                string sysadd = "1";
                string typeid = "0";
                if (keywords!="")
                {
                    keywords= keywords.Replace(",", " ");
                }
                //将文章信息插入到news表中
                string sql = "insert into " + _pubTablePrename + "_news(catid,typeid,title,thumb,keywords,description,url,status,sysadd,username,inputtime,updatetime)";
                sql = sql + " values ('" + _pubTypeid + "'";
                sql = sql + ",'" + typeid + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(title) + "'";
                sql = sql + ",'" + litpic + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(keywords) + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(description) + "'";
                sql = sql + ",'" + url + "'";
                sql = sql + ",'" + status + "'";
                sql = sql + ",'" + sysadd + "'";
                sql = sql + ",'" + username + "'";
                sql = sql + ",'" + pubDateUnixtime + "'";
                sql = sql + ",'" + pubDateUnixtime + "')";
                counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                if (sResult == mySqlDB.SUCCESS && counts > 0)
                {
                    cmsAid = pubMyDB.LastInsertedId;
                }
                else
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "发布文章至news表错误");
                    _pubExceptions.Add(ex);
                    return false;
                }
                //将相应的文章数据插入到news_data表中
                string maxcharperpage = "3000";  //文章按多少字分页
                string paginationtype = "1";           //表示文章自动分页
                string groupids_view = "";
                string template = "";
                if (pageContent.Count>1)
                {
                    paginationtype = "2";  //表示手工分页
                    content = "";
                    for (int i = 0; i < pageContent.Count-1; i++)
                    {
                        content += pageContent[i];
                        content += "<br /> [page] <br />";
                    }
                    content += pageContent[pageContent.Count - 1];
                }
                sql = "insert into " + _pubTablePrename + "_news_data(id,content,groupids_view,paginationtype,maxcharperpage,template,copyfrom)";
                sql = sql + " values ('" + cmsAid.ToString() + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(content) + "'";
                sql = sql + ",'" + groupids_view + "'";
                sql = sql + ",'" + paginationtype + "'";
                sql = sql + ",'" + maxcharperpage + "'";
                sql = sql + ",'" + template + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(sourceSite) + "')";
                counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                if (sResult == mySqlDB.SUCCESS && counts > 0)
                {
                }
                else
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "发布文章至news_data表错误");
                    ex.Data.Add("发布文章ID", cmsAid);
                    _pubExceptions.Add(ex);
                    return false;
                }
                //将相应的文章数据插入到hits表中
                string hitsid = "c-1-" + cmsAid.ToString();
                sql = "INSERT IGNORE INTO " + _pubTablePrename + "_hits(hitsid,catid) Values('" + hitsid + "','" + _pubTypeid + "')";
                counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                if (sResult == mySqlDB.SUCCESS && counts > 0)
                {
                    return true;
                }
                else
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "发布文章-添加点击数记录至hits表错误");
                    ex.Data.Add("发布文章ID", cmsAid);
                    _pubExceptions.Add(ex);
                }
                //更新分类表中栏目文章数统计字段
                sql = "update " + _pubTablePrename + "_category set items=items+1 where catid='" + _pubTypeid.ToString() + "'";
                if (sResult != mySqlDB.SUCCESS)
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "更新分类表中items字段和allitems字段错误");
                    ex.Data.Add("发布分类ID", _pubTypeid);
                    _pubExceptions.Add(ex);
                }

            }

            //如果发布CMS为phpcms
            if (_cmsType=="akcms")
            {
                int pagenum = 0;
                if (pageContent.Count>1)
                {
                    pagenum = pageContent.Count - 1;
                }
                string sql = "insert into " + _pubTablePrename + "_items(category,module,title,picture,pagenum,keywords,digest,editor,dateline,lastupdate)";
                sql = sql + " values ('" + _pubTypeid + "'";
                sql = sql + ",'1'";
                sql = sql + ",'" + mySqlDB.EscapeString(title) + "'";
                sql = sql + ",'" + litpic + "'";
                sql = sql + ",'" + pagenum.ToString() + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(keywords) + "'";
                sql = sql + ",'" + mySqlDB.EscapeString(description) + "'";
                sql = sql + ",'" + username + "'";
                sql = sql + ",'" + pubDateUnixtime + "'";
                sql = sql + ",'" + pubDateUnixtime + "')";
                counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                if (sResult == mySqlDB.SUCCESS && counts > 0)
                {
                    cmsAid = pubMyDB.LastInsertedId;
                }
                else
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "发布文章至news表错误");
                    _pubExceptions.Add(ex);
                    return false;
                }
                //将相应的文章数据插入到news_data表中
                if (pagenum==0)  //如果文章没分页
                {
                    sql = "insert into " + _pubTablePrename + "_texts(itemid,text,page)";
                    sql = sql + " values ('" + cmsAid.ToString() + "'";
                    sql = sql + ",'" + mySqlDB.EscapeString(content) + "'";
                    sql = sql + "," + pagenum.ToString()+"')";
                    counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                    if (sResult == mySqlDB.SUCCESS && counts > 0)
                    {
                    }
                    else
                    {
                        Exception ex = new Exception(sResult);
                        ex.Data.Add("错误信息", "发布文章至texts表错误");
                        ex.Data.Add("发布文章ID", cmsAid);
                        _pubExceptions.Add(ex);
                        return false;
                    }
                }
                else  //如果文章有分页
                {
                    int count = 0;
                    foreach (string pageText in pageContent)
                    {
                        sql = "insert into " + _pubTablePrename + "_texts(itemid,text,page)";
                        sql = sql + " values ('" + cmsAid.ToString() + "'";
                        sql = sql + ",'" + mySqlDB.EscapeString(pageText) + "'";
                        sql = sql + ",'" + count.ToString() + "')";
                        counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                        if (sResult == mySqlDB.SUCCESS && counts > 0)
                        {
                        }
                        else
                        {
                            Exception ex = new Exception(sResult);
                            ex.Data.Add("错误信息", "发布文章至texts表错误");
                            ex.Data.Add("发布文章ID", cmsAid);
                            _pubExceptions.Add(ex);
                            return false;
                        }
                        count++;  //分页编号+1
                    }
                }
                //更新栏目文章计数
                sql = "update " + _pubTablePrename + "_categories set items=items+1,allitems=allitems+1 where id='" + _pubTypeid.ToString() + "'";
                counts = pubMyDB.executeDMLSQL(sql, ref sResult);
                if (sResult!=mySqlDB.SUCCESS)
                {
                    Exception ex = new Exception(sResult);
                    ex.Data.Add("错误信息", "更新分类表中items字段和allitems字段错误");
                    ex.Data.Add("发布分类ID", _pubTypeid);
                    _pubExceptions.Add(ex);
                }

            }

            return true;
        }
        
        //成功发布一篇文章后，更新采集文章库中对应文章的信息
        private bool updateCoArticle(long aid, long cmsAid)
        {
            bool isCorrectUpdated = true;
            mySqlDB myDB = new mySqlDB(_coConnString);
            string sResult = "";
            int counts = 0;
            //更新采集数据库arc_contents表中cms_aid字段
            string sql = "update arc_contents set cms_aid='" + cmsAid.ToString() + "' where aid='" + aid.ToString() + "'";
            counts = myDB.executeDMLSQL(sql, ref sResult);
            if (sResult != mySqlDB.SUCCESS || counts == 0)
            {
                isCorrectUpdated = false;
                Exception ex = new Exception(sResult);
                ex.Data.Add("错误信息", "发布文章后更新cms_aid字段信息错误");
                ex.Data.Add("采集文章ID", aid);
                ex.Data.Add("发布文章ID", cmsAid);
            }
            //更新采集数据库arc_contents表中usedby_pc字段
            sql = "update arc_contents set usedby_pc='yes' where aid='" + aid.ToString() + "'";
            counts = myDB.executeDMLSQL(sql, ref sResult);
            if (sResult != mySqlDB.SUCCESS || counts == 0)
            {
                isCorrectUpdated = false;
                Exception ex = new Exception(sResult);
                ex.Data.Add("错误信息", "发布文章后更新usedby_pc字段信息错误");
                ex.Data.Add("采集文章ID", aid);
                ex.Data.Add("发布文章ID", cmsAid);
            }
            //更新采集数据库arc_type表中unused_nums字段
            sql = "update arc_type set unused_nums=unused_nums-1 where tid='" + _coTypeid+ "'";
            counts = myDB.executeDMLSQL(sql, ref sResult);
            if (sResult != mySqlDB.SUCCESS || counts == 0)
            {
                isCorrectUpdated = false;
                Exception ex = new Exception(sResult);
                ex.Data.Add("错误信息", "发布文章后更新usedby_pc字段信息错误");
                ex.Data.Add("采集文章ID", aid);
                ex.Data.Add("发布文章ID", cmsAid);
            }

            return isCorrectUpdated;
        }

        //发布指定 _pubNums 数量的文章
        public void ProcessPublishArticles()
        {
            _pubState = "发布文章";
            _exportedArticleNums = 0;
            if (_aid != 0)
            {
                _pubNums = 1;
            }
            CancellationToken forCancelToken = _cancelTokenSource.Token;
            for (int i = 0; i < _pubNums; i++)
            {
                if (forCancelToken.IsCancellationRequested)
                {
                    Exception ex = new Exception("取消发布文章");
                    _cancelException = ex;
                    break;
                }
                Dictionary<string, object> oneArticle = getOneRecord();
                if (oneArticle!=null)
                {
                    long cmsAid=-1;
                    bool isCorrectExported;
                    long aid = long.Parse(oneArticle["aid"].ToString());
                    _coTypeid = int.Parse(oneArticle["type_id"].ToString());
                    _pubTypeid = int.Parse(oneArticle["cms_typeid"].ToString());
                    isCorrectExported = exportOneRecord(oneArticle, ref  cmsAid);
                    if (isCorrectExported)
                    {
                        bool isCorrectUpdated;
                        isCorrectUpdated = updateCoArticle(aid, cmsAid);
                        if (!isCorrectUpdated)
                        {
                            //如果不能正确更新已经发布文章的信息，则终止发布处理
                            break;
                        }
                        _lastExportedCoid = aid;
                        _lastExportedCmsid = cmsAid;
                        _exportedArticleNums += 1;
                    }
                    else
                    {
                        //如果不能正确发布一篇文章，则终止发布处理
                        break;
                    }
                }
                else
                {
                    //如果不能获取到文章了，说明要么是数据库连接出错了，要么是当前采集分类下可发布的文章已经没有了，所以退出发布处理过程
                    break;
                }
            }
        }

    }
}
