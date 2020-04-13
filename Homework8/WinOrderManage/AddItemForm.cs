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
    public partial class AddItemForm : Form
    {
        public OrderItem newItem { get; set; }      //要添加的新订单明细

        public AddItemForm()
        {
            InitializeComponent();
            newItem = new OrderItem(new Product("西红柿",5),1);
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            txtBoxPrdctName.DataBindings.Add("text", newItem.product, "name");
            txtBoxPrdctPrice.DataBindings.Add("text", newItem.product, "price");
            txtBoxPrdctQuantity.DataBindings.Add("text", newItem, "prdctQuantity");
        }

        //点击添加订单明细
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
