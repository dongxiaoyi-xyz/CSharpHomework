using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace OrderManage
{
    public class OrderService
    {
        //查询所有订单
        static public List<Order> SearchAllOrder()
        {
            List<Order> orderList;
            using (var context = new OrderContext())
            {
                orderList = context.orders
                                .Include(o => o.itemList)
                                .Include(o => o.customer)
                                .Include(o => o.itemList.Select(i => i.product))
                                .OrderBy(o => o.Id).ToList();
            }
            return orderList;
        }

        //根据订单号查询订单
        static public List<Order> SearchOrder(int orderId)
        {
            List<Order> orderSearched;
            using (var context = new OrderContext())
            {
                orderSearched = context.orders
                                    .Include(o => o.itemList)
                                    .Include(o => o.customer)
                                    .Include(o => o.itemList.Select(i => i.product))
                                    .Where(o => o.Id == orderId)
                                    .OrderBy(o => o.totalPrice).ToList();
            }
            return orderSearched;
        }

        //根据产品名查询订单
        static public List<Order> SearchOrder(string productName)
        {
            List<Order> orderSearched;
            using (var context = new OrderContext())
            {
                orderSearched = context.orders
                                    .Include(o => o.itemList)
                                    .Include(o => o.customer)
                                    .Include(o => o.itemList.Select(i => i.product))
                                    .Where(o => o.itemList.Any(item => item.product.name == productName))
                                    .OrderBy(o => o.totalPrice).ToList();
            }
            return orderSearched;
        }

        //根据顾客查询订单
        static public List<Order> SearchOrder(Customer customer)
        {
            List<Order> orderSearched;
            using (var context = new OrderContext())
            {
                orderSearched = context.orders
                                    .Include(o => o.itemList)
                                    .Include(o => o.customer)
                                    .Include(o => o.itemList.Select(i => i.product))
                                    .Where(o => o.customer.Id == customer.Id)
                                    .OrderBy(o => o.totalPrice).ToList();
            }
            return orderSearched;
        }

        //添加订单
        static public void AddOrder(Order orderToAdd)
        {
            using (var context = new OrderContext())
            {
                var order = new Order(orderToAdd.Id, orderToAdd.customer, orderToAdd.itemList);
                var customer = context.customers.Where(c => c.Id == orderToAdd.customer.Id).FirstOrDefault();
                if (customer != null) order.customer = customer;//若orderToAdd的customer已存在于数据库中，则将数据库中的对应实体赋值给order.customer
                context.orders.Add(order);
                context.SaveChanges();
            }
        }

        //删除订单
        static public void DeleteOrder(Order orderToDelete)
        {
            using (var context = new OrderContext())
            {
                var order = context.orders.Include("itemList").FirstOrDefault(o => o.Id == orderToDelete.Id);
                if (order != null)
                {
                    context.orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        //修改订单
        static public void ModifyOrder(Order newOrder)
        {
            using (var context = new OrderContext())
            {
                var order = context.orders.Include(o => o.itemList).FirstOrDefault(o => o.Id == newOrder.Id);
                if (order != null)
                {
                    order.ModifyItemList(newOrder.itemList);
                    context.SaveChanges();
                }
            }
        }

        //将数据库中所有订单序列化为XML文件,filePath是XML文件的路径
        static public void Export(string filePath)
        {
            List<Order> orderList;
            using (var context = new OrderContext())
            {
                orderList = context.orders
                                .Include(o => o.itemList)
                                .Include(o => o.customer)
                                .Include(o => o.itemList.Select(i => i.product))
                                .OrderBy(o => o.Id).ToList();
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orderList);
            }
        }

        //从文件路径为filePath的XML文件中载入订单并存入数据库
        static public void Import(string filePath)
        {
            List<Order> orderList;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                orderList = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            foreach (Order order in orderList)
            {
                AddOrder(order);
            }
        }
    }
}
