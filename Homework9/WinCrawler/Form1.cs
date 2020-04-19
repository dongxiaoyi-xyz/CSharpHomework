using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrawler;
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
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            string startUrl = txtStartUrl.Text;
            crawler.startUrl =startUrl;
            listBoxCrawReault.Items.Clear();
            new Thread(crawler.Start).Start();
        }

        private void Crawler_PageDownloaded(string url)
        {
            if (this.listBoxCrawReault.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }

        private void AddUrl(string url)
        {
            listBoxCrawReault.Items.Add(url);
        }
    }

}

