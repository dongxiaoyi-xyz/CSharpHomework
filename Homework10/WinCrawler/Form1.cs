using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinCrawler
{
    public partial class Form1 : Form
    {
        SimpleCrawler.SimpleCrawler crawler;
        public Form1()
        {
            InitializeComponent();
            crawler = new SimpleCrawler.SimpleCrawler();
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            string startUrl = txtStartUrl.Text;
            crawler.startUrl =startUrl;
            bindingSourceResult.Clear();
            new Thread(crawler.Start).Start();
            lblInfo.Text = "爬虫已启动...";
        }

        private void Crawler_PageDownloaded(string url,string status)
        {
            var pageInfo = new { Index = bindingSourceResult.Count + 1, URL = url, Status = status };
            Action action = () => bindingSourceResult.Add(pageInfo);
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_CrawlerStopped(string runningTime)
        {

            Action<string> action = s => lblInfo.Text = s;
            if (this.InvokeRequired)
            {
                this.Invoke(action, new object[] { runningTime });
            }
            else
            {
                action(runningTime);
            }
        }
    }

}

