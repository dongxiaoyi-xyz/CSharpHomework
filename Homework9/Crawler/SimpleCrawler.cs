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

namespace SimpleCrawler
{
    public delegate void PageDownloadedHandler(string url);
    public class SimpleCrawler
    {
        private Hashtable urls;
        private int count;
        public string startUrl;
        public event PageDownloadedHandler PageDownloaded;


        static void Main(string[] args)
        {
            string startUrl = "https://www.cnblogs.com/dstang2000/";
            SimpleCrawler myCrawler = new SimpleCrawler();
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.startUrl = startUrl;
            myCrawler.PageDownloaded = s => Console.WriteLine(s);
            new Thread(myCrawler.Start).Start();
        }

        public SimpleCrawler()
        {
            urls = new Hashtable();
            count = 0;
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
                Thread.Sleep(1000);
            }
        }

        public void Start()
        {
            urls.Add(startUrl, false);//加入初始页面
            Crawl();
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                PageDownloaded(url);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PageDownloaded(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string currentUrl)
        {
            string strRef = @"(h|H)(r|R)(e|E)(f|F)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                strRef = UrlConvert(strRef, currentUrl);
                if ((strRef.Length == 0)
                    || !(strRef.Contains(startUrl))//不是起始网站上的网页
                    || !(Regex.IsMatch(strRef, @".html+$")))//不是html文件
                    continue;
                if (urls[strRef] == null) urls[strRef] = false;
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
}
