namespace WinOrderManage
{
    partial class ModifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.lblItemList = new System.Windows.Forms.Label();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdctQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.txtBoxOrderId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyOrder.Location = new System.Drawing.Point(273, 310);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(94, 31);
            this.btnModifyOrder.TabIndex = 19;
            this.btnModifyOrder.Text = "修改订单";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.Location = new System.Drawing.Point(259, 21);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(67, 15);
            this.lblItemList.TabIndex = 18;
            this.lblItemList.Text = "订单明细";
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemGridView.AutoGenerateColumns = false;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.prdctQuantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.itemGridView.DataSource = this.itembindingSource;
            this.itemGridView.Location = new System.Drawing.Point(251, 36);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 27;
            this.itemGridView.Size = new System.Drawing.Size(347, 217);
            this.itemGridView.TabIndex = 17;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "product";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 125;
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
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itembindingSource
            // 
            this.itembindingSource.DataSource = typeof(OrderManage.OrderItem);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(58, 180);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(123, 30);
            this.btnAddItem.TabIndex = 16;
            this.btnAddItem.Text = "添加订单明细";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(28, 139);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 15);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "客户名";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(28, 89);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(53, 15);
            this.lblCustomerId.TabIndex = 14;
            this.lblCustomerId.Text = "客户id";
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Location = new System.Drawing.Point(106, 136);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.ReadOnly = true;
            this.txtBoxCustomerName.Size = new System.Drawing.Size(100, 25);
            this.txtBoxCustomerName.TabIndex = 13;
            // 
            // txtBoxCustomerId
            // 
            this.txtBoxCustomerId.Location = new System.Drawing.Point(106, 86);
            this.txtBoxCustomerId.Name = "txtBoxCustomerId";
            this.txtBoxCustomerId.ReadOnly = true;
            this.txtBoxCustomerId.Size = new System.Drawing.Size(100, 25);
            this.txtBoxCustomerId.TabIndex = 12;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(28, 39);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(52, 30);
            this.lblOrderId.TabIndex = 10;
            this.lblOrderId.Text = "订单号\r\n\r\n";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(58, 222);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(123, 30);
            this.btnDeleteItem.TabIndex = 20;
            this.btnDeleteItem.Text = "删除订单明细";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtBoxOrderId
            // 
            this.txtBoxOrderId.Location = new System.Drawing.Point(106, 36);
            this.txtBoxOrderId.Name = "txtBoxOrderId";
            this.txtBoxOrderId.ReadOnly = true;
            this.txtBoxOrderId.Size = new System.Drawing.Size(100, 25);
            this.txtBoxOrderId.TabIndex = 21;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 381);
            this.Controls.Add(this.txtBoxOrderId);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnModifyOrder);
            this.Controls.Add(this.lblItemList);
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtBoxCustomerName);
            this.Controls.Add(this.txtBoxCustomerId);
            this.Controls.Add(this.lblOrderId);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.TextBox txtBoxCustomerId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdctQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itembindingSource;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox txtBoxOrderId;
    }
}