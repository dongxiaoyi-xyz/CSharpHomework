using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int n;           //迭代次数
        int leng;        //主干长度
        double th1;      //右分支长度比
        double th2;      //左分支长度比
        double per1;     //右分支角度
        double per2;     //左分支角度
        Color color;     //树的颜色

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawTree_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel1.CreateGraphics();
            drawCayleyTree(n, 150, 300, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
            {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
            new Pen(color),
            (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            n = (int)numericUpDown.Value;           //更新迭代次数
        }

        private void numericUpDownLeng_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            leng = (int)numericUpDown.Value;        //更新主干长度
        }

        private void trackBarPer1_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            per1 = (double)trackBar.Value / 100;         //更新右分支比例
            lblDispPer1.Text = $"{per1}";                //显示右分支比例
        }

        private void trackBarPer2_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            per2 = (double)trackBar.Value / 100;   //更新左分支比例
            lblDispPer2.Text = $"{per2}";          //显示左分支比例
        }

        private void trackBarTh1_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            double temp = trackBar.Value;
            lblDispTh1.Text = $"{temp}";   //显示右分支角度
            th1 = temp * Math.PI / 180;   //角度转化为弧度，更新右分支角度
        }

        private void trackBarTh2_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            double temp = trackBar.Value;
            lblDispTh2.Text = $"{temp}";  //显示左分支角度
            th2 = temp * Math.PI / 180;  //角度转化为弧度，更新左分支角度
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int index = comboBox.SelectedIndex;
            //更新树的颜色
            switch (index)
            {
                case 0:
                    color = Color.Red;
                    break;
                case 1:
                    color = Color.Yellow;
                    break;
                case 2:
                    color = Color.Blue;
                    break;
                case 3:
                    color = Color.Green;
                    break;
            }
        }
    }
}
