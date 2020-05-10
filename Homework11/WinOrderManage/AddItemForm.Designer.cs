namespace WinOrderManage
{
    partial class AddItemForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrdctPrice = new System.Windows.Forms.Label();
            this.lblPrdctQuantity = new System.Windows.Forms.Label();
            this.txtBoxPrdctName = new System.Windows.Forms.TextBox();
            this.txtBoxPrdctPrice = new System.Windows.Forms.TextBox();
            this.txtBoxPrdctQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(69, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(52, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "商品名";
            // 
            // lblPrdctPrice
            // 
            this.lblPrdctPrice.AutoSize = true;
            this.lblPrdctPrice.Location = new System.Drawing.Point(69, 83);
            this.lblPrdctPrice.Name = "lblPrdctPrice";
            this.lblPrdctPrice.Size = new System.Drawing.Size(67, 15);
            this.lblPrdctPrice.TabIndex = 1;
            this.lblPrdctPrice.Text = "商品单价";
            // 
            // lblPrdctQuantity
            // 
            this.lblPrdctQuantity.AutoSize = true;
            this.lblPrdctQuantity.Location = new System.Drawing.Point(69, 125);
            this.lblPrdctQuantity.Name = "lblPrdctQuantity";
            this.lblPrdctQuantity.Size = new System.Drawing.Size(67, 15);
            this.lblPrdctQuantity.TabIndex = 2;
            this.lblPrdctQuantity.Text = "商品数量";
            // 
            // txtBoxPrdctName
            // 
            this.txtBoxPrdctName.Location = new System.Drawing.Point(152, 37);
            this.txtBoxPrdctName.Name = "txtBoxPrdctName";
            this.txtBoxPrdctName.Size = new System.Drawing.Size(100, 25);
            this.txtBoxPrdctName.TabIndex = 3;
            // 
            // txtBoxPrdctPrice
            // 
            this.txtBoxPrdctPrice.Location = new System.Drawing.Point(152, 80);
            this.txtBoxPrdctPrice.Name = "txtBoxPrdctPrice";
            this.txtBoxPrdctPrice.Size = new System.Drawing.Size(100, 25);
            this.txtBoxPrdctPrice.TabIndex = 4;
            // 
            // txtBoxPrdctQuantity
            // 
            this.txtBoxPrdctQuantity.Location = new System.Drawing.Point(152, 122);
            this.txtBoxPrdctQuantity.Name = "txtBoxPrdctQuantity";
            this.txtBoxPrdctQuantity.Size = new System.Drawing.Size(100, 25);
            this.txtBoxPrdctQuantity.TabIndex = 5;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(117, 181);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 29);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "添加";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 236);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtBoxPrdctQuantity);
            this.Controls.Add(this.txtBoxPrdctPrice);
            this.Controls.Add(this.txtBoxPrdctName);
            this.Controls.Add(this.lblPrdctQuantity);
            this.Controls.Add(this.lblPrdctPrice);
            this.Controls.Add(this.lblProductName);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrdctPrice;
        private System.Windows.Forms.Label lblPrdctQuantity;
        private System.Windows.Forms.TextBox txtBoxPrdctName;
        private System.Windows.Forms.TextBox txtBoxPrdctPrice;
        private System.Windows.Forms.TextBox txtBoxPrdctQuantity;
        private System.Windows.Forms.Button btnAddItem;
    }
}