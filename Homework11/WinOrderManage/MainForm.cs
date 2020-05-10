using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage;

namespace WinOrderManage
{
    public partial class MainForm : Form
    {
        public List<Order> orderSearched { get; set; }       //查询的订单链表
        public int srchMtdIndex { get; set; }                //查询方式索引，0--查询所有订单，1--按订单号查询，2--按商品名查询，3--按客户id查询
        public string srchKey { get; set; }                  //查询关键字

        public MainForm()
        {
            InitializeComponent();
            orderSearched = new List<Order>();
        }

        //当前选择的订单改变，则将itembindingSource数据源设为当前选择订单的订单明细链表
        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Order current = orderBindingSource.Current as Order;
            if (current != null) itembindingSource.DataSource = current.itemList;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderSearched;
            cmbBoxSrchMtd.DataBindings.Add("SelectedIndex", this, "srchMtdIndex");
            txtBoxSrchKey.DataBindings.Add("text", this, "srchKey");
        }

        //点击查询订单按钮
        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            bool isCanParseToInt;     //查询关键字是否可被解析为整数
            int parseResultInt;       //查询关键字解析为整数的结果
            switch (srchMtdIndex)//查询方式
            {
                case 0:    //查询所有订单
                    orderSearched = OrderService.SearchAllOrder();
                    break;
                case 1:   //按订单号查询
                    isCanParseToInt = int.TryParse(srchKey, out parseResultInt);   //解析查询关键字
                    if (isCanParseToInt) orderSearched = OrderService.SearchOrder(parseResultInt); //查询关键字可以解析为整数则查询订单
                    else txtBoxSrchKey.Text = "0"; //查询关键字文本框显示"0"
                    break;
                case 2:   //按产品名查询
                    orderSearched = OrderService.SearchOrder(srchKey);
                    break;
                case 3:   //按客户id查询
                    isCanParseToInt = int.TryParse(srchKey, out parseResultInt);  //解析查询关键字
                    if (isCanParseToInt) orderSearched = OrderService.SearchOrder(new Customer(parseResultInt, ""));  //查询关键字可以解析为整数则查询订单
                    else txtBoxSrchKey.Text = "0"; //查询关键字文本框显示"0"
                    break;
                default:
                    break;
            }
            orderBindingSource.DataSource = orderSearched;
            orderBindingSource.ResetBindings(false);
        }

        //点击添加订单按钮
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OrderService.AddOrder(addForm.newOrder);  //添加订单
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnSearchOrder_Click(new object(), new EventArgs());
            }
        }

        //点击删除订单按钮
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            Order current = orderBindingSource.Current as Order;
            if (current != null)
            {
                OrderService.DeleteOrder(current);   //删除当前所选订单
                btnSearchOrder_Click(new object(), new EventArgs());
            }
        }

        //点击修改订单按钮
        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            Order current = orderBindingSource.Current as Order;
            if (current != null)
            {
                ModifyForm modifyForm = new ModifyForm(current);
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    OrderService.ModifyOrder(modifyForm.newOrder);   //修改订单
                    btnSearchOrder_Click(new object(), new EventArgs());
                }
            }
        }

        //点击导入订单按钮
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "xml文件(*.xml)|*.xml";   //导入的文件的类型须为xml文件
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OrderService.Import(openFile.FileName);  //导入文件
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //点击导出文件按钮
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "xml文件(*.xml)|*.xml";  //导出的文件的类型须为xml文件
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                OrderService.Export(saveFile.FileName);   //导出文件
            }
        }
    }
}
