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
    public partial class AddForm : Form
    {
        public Order newOrder { get; set; }          //要添加的新订单
        
        public AddForm()
        {
            InitializeComponent();
            newOrder = new Order(4, new Customer(396, "dxy"));
        }

        private void AddForm_Load(object sender, EventArgs e)
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
                newOrder.AddItem(addItemForm.newItem);       //添加订单明细
            }
            itembindingSource.DataSource = newOrder.itemList;
            itembindingSource.ResetBindings(false);
        }

        //点击添加订单
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
