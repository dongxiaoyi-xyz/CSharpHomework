using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("樱桃", 20.5), 1)
            };
            List<OrderItem> itemList4 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            Order order3_modified = new Order(3, customer2, itemList4);
            //添加订单order1
            OrderService.AddOrder(order1);
            Console.WriteLine("Add order " + order1);
            //添加订单order2
            OrderService.AddOrder(order2);
            Console.WriteLine("Add order " + order2);
            //添加订单order3
            OrderService.AddOrder(order3);
            //修改订单order3
            Console.WriteLine("Add order " + order3);
            OrderService.ModifyOrder(order3_modified);
            Console.WriteLine("The order has been successfully modified to " + order3_modified);
            //查询订单id为2的订单
            List<Order> orderSearched = OrderService.SearchOrder(2);
            Console.WriteLine("Searched by orderId 2, the orders are");
            foreach (Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
            //查询商品名称为“香蕉”的订单
            orderSearched = OrderService.SearchOrder("香蕉");
            Console.WriteLine("\nSearched by productName \"香蕉\", the orders are");
            foreach (Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
            //查询客户为customer2的订单
            orderSearched = OrderService.SearchOrder(customer2);
            Console.WriteLine($"Searched by customer {customer2}, the orders are");
            foreach (Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
            //删除订单order2
            OrderService.DeleteOrder(order2);
            Console.WriteLine("Succeed to delete " + order2);
            //输出剩余订单
            Console.WriteLine("The remaining orders are");
            orderSearched = OrderService.SearchAllOrder();
            foreach (Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
        }
    }
}
