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
    public partial class Form2 : Form
    {
        private Graphics graphics;
        int n;           //迭代次数
        int leng;        //主干长度
        double th1;      //右分支长度比
        double th2;      //左分支长度比
        double per1;     //右分支角度
        double per2;     //左分支角度
        Color color;     //树的颜色

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics == null)graphics = panel1.CreateGraphics();
            drawCayleyTree(n, 150, 300, leng, - Math.PI / 2);
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

        //解析文本框输入，若文本框textbox中是数字且在合法范围（min-max）内则返回true，解析结果保存在result中，否则返回false，并通过标签lblWarning显示错误信息
        bool TxtInputParse(TextBox textBox, out double result, Label lblWarning, double min, double max)
        {
            bool isParseSuccess = Double.TryParse(textBox.Text, out result);
            if (isParseSuccess)//输入的是数字
            {
                if (result >= min && result <= max) //输入的数字在合法范围内
                {
                    lblWarning.Text = "";
                    return true;
                }
                else  //输入的数字不在合法范围内
                {
                    lblWarning.Text = $"合法范围为{min}-{max}";
                    return false;
                }
            }
            else  //输入的不是数字
            {
                lblWarning.Text = "解析失败，请输入数字！";
                return false;
            }
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            double temp;
            TxtInputParse(txtN, out temp, lblWarningN, 0, 20);  //解析文本框输入
            n = (int)temp;   //更新迭代次数
        }

        private void txtLeng_TextChanged(object sender, EventArgs e)
        {
            double temp;
            TxtInputParse(txtLeng, out temp, lblWarningLeng, 0, 200);  //解析文本框输入
            leng = (int)temp;   //更新主干长度
        }

        private void txtPer1_TextChanged(object sender, EventArgs e)
        {
            TxtInputParse(txtPer1, out per1, lblWarningPer1, 0, 1);   //解析文本框输入并更新右分支比例
        }

        private void txtPer2_TextChanged(object sender, EventArgs e)
        {
            TxtInputParse(txtPer2, out per2, lblWarningPer2, 0, 1);   //解析文本框输入并更新左分支比例
        }

        private void txtTh1_TextChanged(object sender, EventArgs e)
        {
            double temp;
            TxtInputParse(txtTh1, out temp, lblWarningTh1, 0, 90);     //解析文本框输入
            th1 = temp * Math.PI / 180;    //更新右分支角度
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double temp;
            TxtInputParse(txtTh2, out temp, lblWarningTh2, 0, 90);     //解析文本框输入
            th2 = temp * Math.PI / 180;    //更新左分支角度
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int index = comboBox.SelectedIndex;
            //更新数的颜色
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
            lblWarningPen.Text = "";
        }
    }
}
