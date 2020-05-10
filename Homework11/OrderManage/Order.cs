using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Order : IComparable
    {
        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }                   //订单号
        public int CustomerId { get; set; }              //订购该订单的客户的Id
        [ForeignKey("CustomerId")]
        public Customer customer { get; set; }           //订购该订单的客户
        public List<OrderItem> itemList { get; set; }           //订单明细链表
        public double totalPrice { get; set; }               //订单总金额

        //创建一个空订单
        public Order()
        {
            this.Id = 0;
            itemList = new List<OrderItem>();
            this.customer = null;
            totalPrice = 0;
        }

        //创建一个空订单
        public Order(int orderId, Customer customer)
        {
            Id = orderId;
            itemList = new List<OrderItem>();
            this.customer = customer;
            totalPrice = 0;
        }

        //创建一个有产品的订单
        public Order(int orderId, Customer customer, List<OrderItem> items)
        {
            Id = orderId;
            itemList = new List<OrderItem>();
            this.customer = customer;
            totalPrice = 0;
            foreach (OrderItem item in items)
            {
                itemList.Add(item);
                totalPrice += item.totalPrice;
            }
        }

        //修改订单明细链表
        public void ModifyItemList(List<OrderItem> items)
        {
            totalPrice = 0;
            itemList = new List<OrderItem>();
            foreach (OrderItem item in items)
            {
                itemList.Add(item);
                totalPrice += item.totalPrice;
            }
        }

        //添加订单明细，添加成功则返回true，添加失败返回false
        public bool AddItem(OrderItem item)
        {
            bool isCanAdd = true;
            for(int i = 0; i < itemList.Count; i++)
            {
                if (item.Equals(itemList[i]))
                {
                    isCanAdd = false;
                    break;
                }
            }
            if (isCanAdd)
            {
                itemList.Add(item);
                totalPrice += item.totalPrice;
            }
            return isCanAdd;
        }

        //删除订单明细，删除成功则返回true，删除失败则返回false
        public bool DeleteItem(OrderItem item)
        {
            bool isCanDelete = false;
            int i;
            for (i = 0; i < itemList.Count; i++)
            {
                if (item.Equals(itemList[i]))
                {
                    isCanDelete = true;
                    break;
                }
            }
            if (isCanDelete)
            {
                itemList.RemoveAt(i);
                totalPrice -= item.totalPrice;
            }
            return isCanDelete;
        }

        //重写Equals方法
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return Id == order.Id;
        }

        //重写GetHashCode方法
        public override int GetHashCode()
        {
            var hashCode = -462789907;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(itemList);
            hashCode = hashCode * -1521134295 + totalPrice.GetHashCode();
            return hashCode;
        }

        //重写ToString方法
        public override string ToString()
        {
            StringBuilder allItems = new StringBuilder();
            foreach (OrderItem item in itemList)
            {
                allItems.Append(item + "\n");
            }
            return "Order:" + "\tid--" + Id + "\n" + customer + "\n" + "totalPrice--" + totalPrice + "\n" + allItems;
        }

        //IComparable接口的CompareTo方法实现
        public int CompareTo(object object2)
        {
            Order order2 = object2 as Order;
            return Id - order2.Id;
        }
    }
}
