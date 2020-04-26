using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace SimpleCrawler
{
    public class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> urls;//所有已下载和待下载URL，key是URL，value表示是否下载成功
        private ConcurrentQueue<string> pending;//待下载队列
        public string startUrl;//起始网址
        public event Action<string, string> PageDownloaded;
        public event Action<string> CrawlerStopped;
        public int MaxPage;//最大下载数量
        public PageDownLoadedCount count;//已下载的页面数量，在某一时刻只允许一个线程访问

        public SimpleCrawler()
        {
            urls = new ConcurrentDictionary<string, bool>();
            pending = new ConcurrentQueue<string>();
            MaxPage = 100;
            count = new PageDownLoadedCount();
        }

        public void Start()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            urls.Clear();
            pending = new ConcurrentQueue<string>();
            count = new PageDownLoadedCount();
            urls.TryAdd(startUrl, false);//加入初始页面
            pending.Enqueue(startUrl);
            while (pending.Count > 0)//有页面待下载
            {
                Action action = () =>
                {
                    string current = null;
                    if (pending.TryDequeue(out current))
                    {
                        string html = DownLoad(current); // 下载
                        urls[current] = true;
                        Parse(html, current);//解析,并加入新的链接
                    }
                };
                Task[] tasks = { Task.Run(action), Task.Run(action) };
                Task.WaitAll(tasks);
            }
            sw.Stop();
            CrawlerStopped($"爬行结束，用时{sw.ElapsedMilliseconds}");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.GetCount().ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                PageDownloaded(url, "success");
                return html;
            }
            catch (Exception ex)
            {
                PageDownloaded(url, "Error:" + ex.Message);
                return "";
            }
        }

        private void Parse(string html, string currentUrl)
        {
            string strRef = @"(h|H)(r|R)(e|E)(f|F)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                if (urls.Count == MaxPage)//达到最大下载数量
                    break;
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                strRef = UrlConvert(strRef, currentUrl);
                if ((strRef.Length == 0)
                    || !(strRef.Contains(startUrl))//不是起始网站上的网页
                    || !(Regex.IsMatch(strRef, @".html+$")))//不是html文件
                    continue;
                if (urls.TryAdd(strRef, false))
                {
                    pending.Enqueue(strRef);
                }
            }
        }

        //将url转化为绝对url并将转化后的绝对url返回，currentUrl为当前文件的绝对url
        private string UrlConvert(string url, string currentUrl)
        {
            int index;
            if (Regex.IsMatch(url, @"^[^/]+://"))//绝对url
                return url;
            if (Regex.IsMatch(url, @"^//"))//相对于协议url
            {
                index = currentUrl.IndexOf(':');
                return currentUrl.Substring(0, index + 1) + url;
            }
            if (Regex.IsMatch(url, @"^/[^/]"))//根相对url
            {
                int firstSlash = currentUrl.IndexOf('/');
                index = currentUrl.Substring(firstSlash + 2).IndexOf('/');
                return currentUrl.Substring(0, firstSlash + 2 + index) + url;
            }
            if (Regex.IsMatch(url, @"^../"))//相对于上一级
            {
                index = currentUrl.LastIndexOf('/');
                if (index == -1) return "";
                return UrlConvert(url.Substring(3), currentUrl.Substring(0, index));
            }
            //相对于当前文件
            index = currentUrl.LastIndexOf('/');
            if (index == -1) return "";
            return currentUrl.Substring(0, index + 1) + url;
        }
    }

    public class PageDownLoadedCount
    {
        private int count = 0;//当前已下载的页面数量
       
        //返回当前已下载的页面数量，同时count加一
        public int GetCount()
        {
            lock(this) //加锁，保证同一时刻最多有一个线程访问count
            {
                count++;
                return count;
            }
        }
    }
}
