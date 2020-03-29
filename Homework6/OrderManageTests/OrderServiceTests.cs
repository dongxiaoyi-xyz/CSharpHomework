using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace OrderManage.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest()//测试构造函数
        {
            OrderService orderService = new OrderService();
            CollectionAssert.AreEqual(new List<Order>(), orderService.orderList);
        }

        [TestMethod()]
        public void SearchOrderTest()//测试按订单号查询订单
        {
            OrderService orderService = new OrderService();
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
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.orderList.Add(order3);
            List<Order> orderSearched = orderService.SearchOrder(1);
            CollectionAssert.AreEqual(new List<Order> { order1 }, orderSearched);
        }

        [TestMethod()]
        public void SearchOrderTest1()//测试按商品名查询订单
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.orderList.Add(order3);
            List<Order> orderSearched = orderService.SearchOrder("香蕉");
            CollectionAssert.AreEqual(new List<Order> { order2,order1 }, orderSearched);
        }

        [TestMethod()]
        public void SearchOrderTest2()//测试按客户查询订单
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.orderList.Add(order3);
            List<Order> orderSearched = orderService.SearchOrder(customer2);
            CollectionAssert.AreEqual(new List<Order> { order3, order2 }, orderSearched);
        }

        [TestMethod()]
        public void AddOrderTest()//测试添加订单
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            bool isSuccess = orderService.AddOrder(order1);
            Assert.AreEqual(true, isSuccess);
            CollectionAssert.AreEqual(new List<Order> { order1 }, orderService.orderList);
            isSuccess = orderService.AddOrder(order2);
            Assert.AreEqual(true, isSuccess);
            CollectionAssert.AreEqual(new List<Order> { order1, order2 }, orderService.orderList);
            isSuccess = orderService.AddOrder(order1);
            Assert.AreEqual(false, isSuccess);
            CollectionAssert.AreEqual(new List<Order> { order1, order2 }, orderService.orderList);
        }

        [TestMethod()]
        public void DeleteOrderTest()//测试删除订单
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.orderList.Add(order3);
            orderService.DeleteOrder(order2);
            CollectionAssert.AreEqual(new List<Order> { order1, order3 }, orderService.orderList);
        }

        [TestMethod()]
        [ExpectedException(typeof(DeleteException))]
        public void DeleteOrderTest1()//测试删除订单，删除不存在的订单，预期结果为抛出删除异常
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.DeleteOrder(order3);
        }

        [TestMethod()]
        public void ModifyOrderTest()//测试修改订单
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order2_modified = new Order(2, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.ModifyOrder(order2_modified);
            CollectionAssert.AreEqual(new List<Order> { order1, order2_modified }, orderService.orderList);
        }

        [TestMethod()]
        [ExpectedException(typeof(ModifyException))]
        public void ModifyOrderTest1()//测试修改订单，修改不存在的订单，预期结果为抛出修改异常
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order2_modified = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order2);
            orderService.ModifyOrder(order2_modified);
        }

        [TestMethod()]
        public void SortedTest()//测试按订单号将订单排序
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order2);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order3);
            orderService.Sorted();
            CollectionAssert.AreEqual(new List<Order> { order1, order2, order3 }, orderService.orderList);
        }

        [TestMethod()]
        public void ExportTest()//测试将订单序列化为XML文件
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order3 = new Order(3, customer2, itemList3);
            orderService.orderList.Add(order1);
            orderService.orderList.Add(order3);
            orderService.Export("orderList.xml");
            Assert.AreEqual(true, File.Exists("orderList.xml"));
            using (HashAlgorithm hash = HashAlgorithm.Create())
            {
                using (FileStream fileExpected = new FileStream("testEmportExpected.xml", FileMode.Open), fileActual = new FileStream("orderList.xml", FileMode.Open))
                {
                    byte[] hashByteExpected = hash.ComputeHash(fileExpected);
                    byte[] hashByteActual = hash.ComputeHash(fileActual);
                    string strExpected = BitConverter.ToString(hashByteExpected);
                    string strActual = BitConverter.ToString(hashByteActual);
                    Assert.AreEqual(strExpected, strActual);
                }
            }
        }

        [TestMethod()]
        public void ImportTest()//测试从XML文件中导入订单
        {
            OrderService orderService = new OrderService();
            orderService.Import("testImportIn.xml");
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
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            CollectionAssert.AreEqual(new List<Order> { order1, order2, order3 }, orderService.orderList);
        }
    }
}