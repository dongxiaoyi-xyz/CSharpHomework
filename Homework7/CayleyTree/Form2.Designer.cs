namespace CayleyTree
{
    partial class Form2
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
            this.btnDrawTree = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.lblLeng = new System.Windows.Forms.Label();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.lblTh1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.txtTh1 = new System.Windows.Forms.TextBox();
            this.lblTh2 = new System.Windows.Forms.Label();
            this.txtTh2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.lblWarningN = new System.Windows.Forms.Label();
            this.lblWarningLeng = new System.Windows.Forms.Label();
            this.lblWarningPer1 = new System.Windows.Forms.Label();
            this.lblWarningPer2 = new System.Windows.Forms.Label();
            this.lblWarningTh1 = new System.Windows.Forms.Label();
            this.lblWarningTh2 = new System.Windows.Forms.Label();
            this.lblWarningPen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDrawTree
            // 
            this.btnDrawTree.Location = new System.Drawing.Point(77, 412);
            this.btnDrawTree.Name = "btnDrawTree";
            this.btnDrawTree.Size = new System.Drawing.Size(115, 36);
            this.btnDrawTree.TabIndex = 0;
            this.btnDrawTree.Text = "生成Cayley树";
            this.btnDrawTree.UseVisualStyleBackColor = true;
            this.btnDrawTree.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(30, 33);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(67, 15);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "递归深度";
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(30, 88);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(67, 15);
            this.lblLeng.TabIndex = 3;
            this.lblLeng.Text = "主干长度";
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Location = new System.Drawing.Point(30, 143);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(97, 15);
            this.lblPer1.TabIndex = 6;
            this.lblPer1.Text = "右分支长度比";
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Location = new System.Drawing.Point(30, 198);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(97, 15);
            this.lblPer2.TabIndex = 8;
            this.lblPer2.Text = "左分支长度比";
            // 
            // lblTh1
            // 
            this.lblTh1.AutoSize = true;
            this.lblTh1.Location = new System.Drawing.Point(30, 253);
            this.lblTh1.Name = "lblTh1";
            this.lblTh1.Size = new System.Drawing.Size(82, 15);
            this.lblTh1.TabIndex = 10;
            this.lblTh1.Text = "右分支角度";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(134, 32);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 25);
            this.txtN.TabIndex = 11;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(134, 87);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(100, 25);
            this.txtLeng.TabIndex = 12;
            this.txtLeng.TextChanged += new System.EventHandler(this.txtLeng_TextChanged);
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(133, 140);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(100, 25);
            this.txtPer1.TabIndex = 13;
            this.txtPer1.TextChanged += new System.EventHandler(this.txtPer1_TextChanged);
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(134, 195);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(100, 25);
            this.txtPer2.TabIndex = 14;
            this.txtPer2.TextChanged += new System.EventHandler(this.txtPer2_TextChanged);
            // 
            // txtTh1
            // 
            this.txtTh1.Location = new System.Drawing.Point(134, 250);
            this.txtTh1.Name = "txtTh1";
            this.txtTh1.Size = new System.Drawing.Size(100, 25);
            this.txtTh1.TabIndex = 15;
            this.txtTh1.TextChanged += new System.EventHandler(this.txtTh1_TextChanged);
            // 
            // lblTh2
            // 
            this.lblTh2.AutoSize = true;
            this.lblTh2.Location = new System.Drawing.Point(30, 308);
            this.lblTh2.Name = "lblTh2";
            this.lblTh2.Size = new System.Drawing.Size(82, 15);
            this.lblTh2.TabIndex = 16;
            this.lblTh2.Text = "左分支角度";
            // 
            // txtTh2
            // 
            this.txtTh2.Location = new System.Drawing.Point(134, 305);
            this.txtTh2.Name = "txtTh2";
            this.txtTh2.Size = new System.Drawing.Size(100, 25);
            this.txtTh2.TabIndex = 17;
            this.txtTh2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "红色",
            "黄色",
            "蓝色",
            "绿色"});
            this.comboBox1.Location = new System.Drawing.Point(134, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(350, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 320);
            this.panel1.TabIndex = 20;
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(30, 363);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(67, 15);
            this.lblPenColor.TabIndex = 18;
            this.lblPenColor.Text = "画笔颜色";
            // 
            // lblWarningN
            // 
            this.lblWarningN.AutoSize = true;
            this.lblWarningN.ForeColor = System.Drawing.Color.Red;
            this.lblWarningN.Location = new System.Drawing.Point(131, 14);
            this.lblWarningN.Name = "lblWarningN";
            this.lblWarningN.Size = new System.Drawing.Size(129, 15);
            this.lblWarningN.TabIndex = 21;
            this.lblWarningN.Text = "请输入0-20的整数";
            // 
            // lblWarningLeng
            // 
            this.lblWarningLeng.AutoSize = true;
            this.lblWarningLeng.ForeColor = System.Drawing.Color.Red;
            this.lblWarningLeng.Location = new System.Drawing.Point(130, 69);
            this.lblWarningLeng.Name = "lblWarningLeng";
            this.lblWarningLeng.Size = new System.Drawing.Size(137, 15);
            this.lblWarningLeng.TabIndex = 22;
            this.lblWarningLeng.Text = "请输入0-200的整数";
            // 
            // lblWarningPer1
            // 
            this.lblWarningPer1.AutoSize = true;
            this.lblWarningPer1.ForeColor = System.Drawing.Color.Red;
            this.lblWarningPer1.Location = new System.Drawing.Point(131, 122);
            this.lblWarningPer1.Name = "lblWarningPer1";
            this.lblWarningPer1.Size = new System.Drawing.Size(121, 15);
            this.lblWarningPer1.TabIndex = 23;
            this.lblWarningPer1.Text = "请输入0-1的实数";
            // 
            // lblWarningPer2
            // 
            this.lblWarningPer2.AutoSize = true;
            this.lblWarningPer2.ForeColor = System.Drawing.Color.Red;
            this.lblWarningPer2.Location = new System.Drawing.Point(131, 177);
            this.lblWarningPer2.Name = "lblWarningPer2";
            this.lblWarningPer2.Size = new System.Drawing.Size(121, 15);
            this.lblWarningPer2.TabIndex = 24;
            this.lblWarningPer2.Text = "请输入0-1的实数";
            // 
            // lblWarningTh1
            // 
            this.lblWarningTh1.AutoSize = true;
            this.lblWarningTh1.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTh1.Location = new System.Drawing.Point(131, 232);
            this.lblWarningTh1.Name = "lblWarningTh1";
            this.lblWarningTh1.Size = new System.Drawing.Size(129, 15);
            this.lblWarningTh1.TabIndex = 25;
            this.lblWarningTh1.Text = "请输入0-90的实数";
            // 
            // lblWarningTh2
            // 
            this.lblWarningTh2.AutoSize = true;
            this.lblWarningTh2.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTh2.Location = new System.Drawing.Point(131, 287);
            this.lblWarningTh2.Name = "lblWarningTh2";
            this.lblWarningTh2.Size = new System.Drawing.Size(129, 15);
            this.lblWarningTh2.TabIndex = 26;
            this.lblWarningTh2.Text = "请输入0-90的实数";
            // 
            // lblWarningPen
            // 
            this.lblWarningPen.AutoSize = true;
            this.lblWarningPen.ForeColor = System.Drawing.Color.Red;
            this.lblWarningPen.Location = new System.Drawing.Point(131, 342);
            this.lblWarningPen.Name = "lblWarningPen";
            this.lblWarningPen.Size = new System.Drawing.Size(112, 15);
            this.lblWarningPen.TabIndex = 27;
            this.lblWarningPen.Text = "请选择画笔颜色";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarningPen);
            this.Controls.Add(this.lblWarningTh2);
            this.Controls.Add(this.lblWarningTh1);
            this.Controls.Add(this.lblWarningPer2);
            this.Controls.Add(this.lblWarningPer1);
            this.Controls.Add(this.lblWarningLeng);
            this.Controls.Add(this.lblWarningN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.txtTh2);
            this.Controls.Add(this.lblTh2);
            this.Controls.Add(this.txtTh1);
            this.Controls.Add(this.txtPer2);
            this.Controls.Add(this.txtPer1);
            this.Controls.Add(this.txtLeng);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblTh1);
            this.Controls.Add(this.lblPer2);
            this.Controls.Add(this.lblPer1);
            this.Controls.Add(this.lblLeng);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnDrawTree);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawTree;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.Label lblTh1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.TextBox txtTh1;
        private System.Windows.Forms.Label lblTh2;
        private System.Windows.Forms.TextBox txtTh2;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWarningN;
        private System.Windows.Forms.Label lblWarningLeng;
        private System.Windows.Forms.Label lblWarningPer1;
        private System.Windows.Forms.Label lblWarningPer2;
        private System.Windows.Forms.Label lblWarningTh1;
        private System.Windows.Forms.Label lblWarningTh2;
        private System.Windows.Forms.Label lblWarningPen;
    }
}

