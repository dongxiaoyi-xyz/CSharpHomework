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
    public partial class ModifyForm : Form
    {
        public Order newOrder { get; set; }      //修改后的新订单

        public ModifyForm()
        {
            InitializeComponent();
        }

        //构造函数，传入要修改的订单oldOrder初始化newOrder
        public ModifyForm(Order oldOrder)
        {
            InitializeComponent();
            newOrder = new Order(oldOrder.Id,oldOrder.customer,oldOrder.itemList);
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            txtBoxOrderId.DataBindings.Add("text", newOrder, "Id");
            txtBoxCustomerId.DataBindings.Add("text", newOrder.customer, "Id");
            txtBoxCustomerName.DataBindings.Add("text", newOrder.customer, "name");
            itembindingSource.DataSource = newOrder.itemList;
        }

        //点击添加订单明细按钮
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                newOrder.AddItem(addItemForm.newItem);    //添加订单明细
            }
            itembindingSource.DataSource = newOrder.itemList;
            itembindingSource.ResetBindings(false);
        }

        //点击删除订单明细按钮
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            OrderItem current = itembindingSource.Current as OrderItem;
            if (current != null) newOrder.DeleteItem(current);   //删除订单明细
            itembindingSource.DataSource = newOrder.itemList;
            itembindingSource.ResetBindings(false);
        }

        //点击修改订单按钮
        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
