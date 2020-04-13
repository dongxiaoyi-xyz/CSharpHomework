namespace WinOrderManage
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbBoxSrchMtd = new System.Windows.Forms.ComboBox();
            this.txtBoxSrchKey = new System.Windows.Forms.TextBox();
            this.lblSrchMtd = new System.Windows.Forms.Label();
            this.lblSrchKey = new System.Windows.Forms.Label();
            this.lblSrchResult = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdctQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.orderGridView);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 314);
            this.panel1.TabIndex = 0;
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AutoGenerateColumns = false;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderGridView.DataSource = this.orderBindingSource;
            this.orderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGridView.Location = new System.Drawing.Point(0, 0);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 27;
            this.orderGridView.Size = new System.Drawing.Size(427, 312);
            this.orderGridView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.itemGridView);
            this.panel2.Location = new System.Drawing.Point(439, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 314);
            this.panel2.TabIndex = 1;
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AutoGenerateColumns = false;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.prdctQuantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.itemGridView.DataSource = this.itembindingSource;
            this.itemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGridView.Location = new System.Drawing.Point(0, 0);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 27;
            this.itemGridView.Size = new System.Drawing.Size(371, 312);
            this.itemGridView.TabIndex = 0;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(464, 30);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(82, 32);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "创建订单";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(580, 12);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(82, 32);
            this.btnDeleteOrder.TabIndex = 3;
            this.btnDeleteOrder.Text = "删除订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Location = new System.Drawing.Point(580, 50);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(82, 32);
            this.btnModifyOrder.TabIndex = 4;
            this.btnModifyOrder.Text = "修改订单";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(22, 28);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(82, 32);
            this.btnSearchOrder.TabIndex = 5;
            this.btnSearchOrder.Text = "查询订单";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(692, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 32);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbBoxSrchMtd
            // 
            this.cmbBoxSrchMtd.FormattingEnabled = true;
            this.cmbBoxSrchMtd.Items.AddRange(new object[] {
            "查询所有订单",
            "按订单号查询",
            "按产品名查询",
            "按顾客id查询"});
            this.cmbBoxSrchMtd.Location = new System.Drawing.Point(130, 36);
            this.cmbBoxSrchMtd.Name = "cmbBoxSrchMtd";
            this.cmbBoxSrchMtd.Size = new System.Drawing.Size(151, 23);
            this.cmbBoxSrchMtd.TabIndex = 8;
            // 
            // txtBoxSrchKey
            // 
            this.txtBoxSrchKey.Location = new System.Drawing.Point(312, 36);
            this.txtBoxSrchKey.Name = "txtBoxSrchKey";
            this.txtBoxSrchKey.Size = new System.Drawing.Size(129, 25);
            this.txtBoxSrchKey.TabIndex = 9;
            // 
            // lblSrchMtd
            // 
            this.lblSrchMtd.AutoSize = true;
            this.lblSrchMtd.Location = new System.Drawing.Point(144, 16);
            this.lblSrchMtd.Name = "lblSrchMtd";
            this.lblSrchMtd.Size = new System.Drawing.Size(67, 15);
            this.lblSrchMtd.TabIndex = 10;
            this.lblSrchMtd.Text = "查询方式";
            // 
            // lblSrchKey
            // 
            this.lblSrchKey.AutoSize = true;
            this.lblSrchKey.Location = new System.Drawing.Point(319, 16);
            this.lblSrchKey.Name = "lblSrchKey";
            this.lblSrchKey.Size = new System.Drawing.Size(112, 15);
            this.lblSrchKey.TabIndex = 11;
            this.lblSrchKey.Text = "输入查询关键字";
            // 
            // lblSrchResult
            // 
            this.lblSrchResult.AutoSize = true;
            this.lblSrchResult.Location = new System.Drawing.Point(12, 85);
            this.lblSrchResult.Name = "lblSrchResult";
            this.lblSrchResult.Size = new System.Drawing.Size(67, 15);
            this.lblSrchResult.TabIndex = 0;
            this.lblSrchResult.Text = "查询结果";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(692, 50);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(82, 32);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "product";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 180;
            // 
            // prdctQuantityDataGridViewTextBoxColumn
            // 
            this.prdctQuantityDataGridViewTextBoxColumn.DataPropertyName = "prdctQuantity";
            this.prdctQuantityDataGridViewTextBoxColumn.HeaderText = "prdctQuantity";
            this.prdctQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prdctQuantityDataGridViewTextBoxColumn.Name = "prdctQuantityDataGridViewTextBoxColumn";
            this.prdctQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.prdctQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // itembindingSource
            // 
            this.itembindingSource.DataSource = typeof(OrderManage.OrderItem);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 180;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderManage.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 427);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblSrchResult);
            this.Controls.Add(this.btnModifyOrder);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblSrchKey);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblSrchMtd);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.txtBoxSrchKey);
            this.Controls.Add(this.cmbBoxSrchMtd);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbBoxSrchMtd;
        private System.Windows.Forms.TextBox txtBoxSrchKey;
        private System.Windows.Forms.Label lblSrchMtd;
        private System.Windows.Forms.Label lblSrchKey;
        private System.Windows.Forms.Label lblSrchResult;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.BindingSource itembindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdctQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
    }
}

