namespace CayleyTree
{
    partial class Form1
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
            this.lblN = new System.Windows.Forms.Label();
            this.lblLeng = new System.Windows.Forms.Label();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.lblTh1 = new System.Windows.Forms.Label();
            this.lblTh2 = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeng = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trackBarPer1 = new System.Windows.Forms.TrackBar();
            this.trackBarPer2 = new System.Windows.Forms.TrackBar();
            this.trackBarTh1 = new System.Windows.Forms.TrackBar();
            this.trackBarTh2 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDrawTree = new System.Windows.Forms.Button();
            this.lblDispPer1 = new System.Windows.Forms.Label();
            this.lblDispPer2 = new System.Windows.Forms.Label();
            this.lblDispTh1 = new System.Windows.Forms.Label();
            this.lblDispTh2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(33, 34);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(67, 15);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "递归深度";
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(33, 89);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(67, 15);
            this.lblLeng.TabIndex = 4;
            this.lblLeng.Text = "主干长度";
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Location = new System.Drawing.Point(33, 144);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(97, 15);
            this.lblPer1.TabIndex = 7;
            this.lblPer1.Text = "右分支长度比";
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Location = new System.Drawing.Point(33, 199);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(97, 15);
            this.lblPer2.TabIndex = 9;
            this.lblPer2.Text = "左分支长度比";
            // 
            // lblTh1
            // 
            this.lblTh1.AutoSize = true;
            this.lblTh1.Location = new System.Drawing.Point(33, 254);
            this.lblTh1.Name = "lblTh1";
            this.lblTh1.Size = new System.Drawing.Size(82, 15);
            this.lblTh1.TabIndex = 11;
            this.lblTh1.Text = "右分支角度";
            // 
            // lblTh2
            // 
            this.lblTh2.AutoSize = true;
            this.lblTh2.Location = new System.Drawing.Point(33, 309);
            this.lblTh2.Name = "lblTh2";
            this.lblTh2.Size = new System.Drawing.Size(82, 15);
            this.lblTh2.TabIndex = 17;
            this.lblTh2.Text = "左分支角度";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(33, 364);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(67, 15);
            this.lblPenColor.TabIndex = 19;
            this.lblPenColor.Text = "画笔颜色";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(144, 32);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownN.TabIndex = 20;
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // numericUpDownLeng
            // 
            this.numericUpDownLeng.Location = new System.Drawing.Point(144, 87);
            this.numericUpDownLeng.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownLeng.Name = "numericUpDownLeng";
            this.numericUpDownLeng.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownLeng.TabIndex = 21;
            this.numericUpDownLeng.ValueChanged += new System.EventHandler(this.numericUpDownLeng_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trackBarPer1
            // 
            this.trackBarPer1.Location = new System.Drawing.Point(144, 144);
            this.trackBarPer1.Maximum = 100;
            this.trackBarPer1.Name = "trackBarPer1";
            this.trackBarPer1.Size = new System.Drawing.Size(104, 56);
            this.trackBarPer1.TabIndex = 23;
            this.trackBarPer1.Scroll += new System.EventHandler(this.trackBarPer1_Scroll);
            // 
            // trackBarPer2
            // 
            this.trackBarPer2.Location = new System.Drawing.Point(144, 199);
            this.trackBarPer2.Maximum = 100;
            this.trackBarPer2.Name = "trackBarPer2";
            this.trackBarPer2.Size = new System.Drawing.Size(104, 56);
            this.trackBarPer2.TabIndex = 24;
            this.trackBarPer2.Scroll += new System.EventHandler(this.trackBarPer2_Scroll);
            // 
            // trackBarTh1
            // 
            this.trackBarTh1.Location = new System.Drawing.Point(144, 254);
            this.trackBarTh1.Maximum = 90;
            this.trackBarTh1.Name = "trackBarTh1";
            this.trackBarTh1.Size = new System.Drawing.Size(104, 56);
            this.trackBarTh1.TabIndex = 25;
            this.trackBarTh1.Scroll += new System.EventHandler(this.trackBarTh1_Scroll);
            // 
            // trackBarTh2
            // 
            this.trackBarTh2.Location = new System.Drawing.Point(144, 309);
            this.trackBarTh2.Maximum = 90;
            this.trackBarTh2.Name = "trackBarTh2";
            this.trackBarTh2.Size = new System.Drawing.Size(104, 56);
            this.trackBarTh2.TabIndex = 26;
            this.trackBarTh2.Scroll += new System.EventHandler(this.trackBarTh2_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "红色",
            "黄色",
            "蓝色",
            "绿色"});
            this.comboBox1.Location = new System.Drawing.Point(143, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(373, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 320);
            this.panel1.TabIndex = 28;
            // 
            // btnDrawTree
            // 
            this.btnDrawTree.Location = new System.Drawing.Point(79, 402);
            this.btnDrawTree.Name = "btnDrawTree";
            this.btnDrawTree.Size = new System.Drawing.Size(115, 36);
            this.btnDrawTree.TabIndex = 29;
            this.btnDrawTree.Text = "生成Cayley树";
            this.btnDrawTree.UseVisualStyleBackColor = true;
            this.btnDrawTree.Click += new System.EventHandler(this.btnDrawTree_Click);
            // 
            // lblDispPer1
            // 
            this.lblDispPer1.AutoSize = true;
            this.lblDispPer1.Location = new System.Drawing.Point(273, 144);
            this.lblDispPer1.Name = "lblDispPer1";
            this.lblDispPer1.Size = new System.Drawing.Size(15, 15);
            this.lblDispPer1.TabIndex = 30;
            this.lblDispPer1.Text = "0";
            // 
            // lblDispPer2
            // 
            this.lblDispPer2.AutoSize = true;
            this.lblDispPer2.Location = new System.Drawing.Point(273, 199);
            this.lblDispPer2.Name = "lblDispPer2";
            this.lblDispPer2.Size = new System.Drawing.Size(15, 15);
            this.lblDispPer2.TabIndex = 31;
            this.lblDispPer2.Text = "0";
            // 
            // lblDispTh1
            // 
            this.lblDispTh1.AutoSize = true;
            this.lblDispTh1.Location = new System.Drawing.Point(273, 254);
            this.lblDispTh1.Name = "lblDispTh1";
            this.lblDispTh1.Size = new System.Drawing.Size(15, 15);
            this.lblDispTh1.TabIndex = 32;
            this.lblDispTh1.Text = "0";
            // 
            // lblDispTh2
            // 
            this.lblDispTh2.AutoSize = true;
            this.lblDispTh2.Location = new System.Drawing.Point(273, 309);
            this.lblDispTh2.Name = "lblDispTh2";
            this.lblDispTh2.Size = new System.Drawing.Size(15, 15);
            this.lblDispTh2.TabIndex = 33;
            this.lblDispTh2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDispTh2);
            this.Controls.Add(this.lblDispTh1);
            this.Controls.Add(this.lblDispPer2);
            this.Controls.Add(this.lblDispPer1);
            this.Controls.Add(this.btnDrawTree);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBarTh2);
            this.Controls.Add(this.trackBarTh1);
            this.Controls.Add(this.trackBarPer2);
            this.Controls.Add(this.trackBarPer1);
            this.Controls.Add(this.numericUpDownLeng);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.lblTh2);
            this.Controls.Add(this.lblTh1);
            this.Controls.Add(this.lblPer2);
            this.Controls.Add(this.lblPer1);
            this.Controls.Add(this.lblLeng);
            this.Controls.Add(this.lblN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.Label lblTh1;
        private System.Windows.Forms.Label lblTh2;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.NumericUpDown numericUpDownLeng;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar trackBarPer1;
        private System.Windows.Forms.TrackBar trackBarPer2;
        private System.Windows.Forms.TrackBar trackBarTh1;
        private System.Windows.Forms.TrackBar trackBarTh2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDrawTree;
        private System.Windows.Forms.Label lblDispPer1;
        private System.Windows.Forms.Label lblDispPer2;
        private System.Windows.Forms.Label lblDispTh1;
        private System.Windows.Forms.Label lblDispTh2;
    }
}