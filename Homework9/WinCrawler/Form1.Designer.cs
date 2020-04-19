namespace WinCrawler
{
    partial class Form1
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
            this.lblStartUrl = new System.Windows.Forms.Label();
            this.txtStartUrl = new System.Windows.Forms.TextBox();
            this.listBoxCrawReault = new System.Windows.Forms.ListBox();
            this.btnCrawl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartUrl
            // 
            this.lblStartUrl.AutoSize = true;
            this.lblStartUrl.Location = new System.Drawing.Point(64, 64);
            this.lblStartUrl.Name = "lblStartUrl";
            this.lblStartUrl.Size = new System.Drawing.Size(67, 15);
            this.lblStartUrl.TabIndex = 0;
            this.lblStartUrl.Text = "起始网站";
            // 
            // txtStartUrl
            // 
            this.txtStartUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartUrl.Location = new System.Drawing.Point(147, 61);
            this.txtStartUrl.Name = "txtStartUrl";
            this.txtStartUrl.Size = new System.Drawing.Size(463, 25);
            this.txtStartUrl.TabIndex = 1;
            // 
            // listBoxCrawReault
            // 
            this.listBoxCrawReault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCrawReault.FormattingEnabled = true;
            this.listBoxCrawReault.ItemHeight = 15;
            this.listBoxCrawReault.Location = new System.Drawing.Point(67, 121);
            this.listBoxCrawReault.Name = "listBoxCrawReault";
            this.listBoxCrawReault.Size = new System.Drawing.Size(657, 259);
            this.listBoxCrawReault.TabIndex = 2;
            // 
            // btnCrawl
            // 
            this.btnCrawl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrawl.Location = new System.Drawing.Point(638, 61);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(95, 34);
            this.btnCrawl.TabIndex = 3;
            this.btnCrawl.Text = "开始爬取";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrawl);
            this.Controls.Add(this.listBoxCrawReault);
            this.Controls.Add(this.txtStartUrl);
            this.Controls.Add(this.lblStartUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartUrl;
        private System.Windows.Forms.TextBox txtStartUrl;
        private System.Windows.Forms.ListBox listBoxCrawReault;
        private System.Windows.Forms.Button btnCrawl;
    }
}

