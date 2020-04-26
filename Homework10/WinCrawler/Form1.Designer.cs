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
            this.components = new System.ComponentModel.Container();
            this.lblStartUrl = new System.Windows.Forms.Label();
            this.txtStartUrl = new System.Windows.Forms.TextBox();
            this.btnCrawl = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvCrawlResult = new System.Windows.Forms.DataGridView();
            this.bindingSourceResult = new System.Windows.Forms.BindingSource(this.components);
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResult)).BeginInit();
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
            this.txtStartUrl.Size = new System.Drawing.Size(762, 25);
            this.txtStartUrl.TabIndex = 1;
            this.txtStartUrl.Text = "https://www.cnblogs.com/dstang2000/";
            // 
            // btnCrawl
            // 
            this.btnCrawl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrawl.Location = new System.Drawing.Point(937, 61);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(95, 34);
            this.btnCrawl.TabIndex = 3;
            this.btnCrawl.Text = "开始爬取";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(64, 107);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 4;
            // 
            // dgvCrawlResult
            // 
            this.dgvCrawlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCrawlResult.AutoGenerateColumns = false;
            this.dgvCrawlResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrawlResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.URL,
            this.status});
            this.dgvCrawlResult.DataSource = this.bindingSourceResult;
            this.dgvCrawlResult.Location = new System.Drawing.Point(67, 137);
            this.dgvCrawlResult.Name = "dgvCrawlResult";
            this.dgvCrawlResult.RowHeadersWidth = 51;
            this.dgvCrawlResult.RowTemplate.Height = 27;
            this.dgvCrawlResult.Size = new System.Drawing.Size(965, 350);
            this.dgvCrawlResult.TabIndex = 5;
            // 
            // index
            // 
            this.index.DataPropertyName = "Index";
            this.index.HeaderText = "序号";
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.Width = 420;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "状态";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 518);
            this.Controls.Add(this.dgvCrawlResult);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCrawl);
            this.Controls.Add(this.txtStartUrl);
            this.Controls.Add(this.lblStartUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartUrl;
        private System.Windows.Forms.TextBox txtStartUrl;
        private System.Windows.Forms.Button btnCrawl;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvCrawlResult;
        private System.Windows.Forms.BindingSource bindingSourceResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

