using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManageApi.Models;

namespace OrderManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext orderDb;

        public OrdersController(OrderContext context)
        {
            orderDb = context;
        }
       
        //按产品名、用户查询订单
        // GET: api/Orders?productName=产品名&&customer=用户对象
        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string productName, Customer customer)
        {
            IQueryable<Order> query = orderDb.orders
                                          .Include(o => o.customer)
                                          .Include(o => o.itemList)
                                          .ThenInclude(itemList => itemList.product)
                                          .OrderBy(o => o.totalPrice);
            if (productName != null)
            {
                query = query
                            .Where(o => o.itemList.Any(item => item.product.name == productName))
                            .OrderBy(o => o.totalPrice);     
            }
            if(customer.Id != 0)
            {
                query = query
                            .Where(o => o.customer.Id == customer.Id)
                            .OrderBy(o => o.totalPrice);
            }
            if(query == null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        //按订单号查询订单
        // GET: api/Orders/{id}
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            Order order = orderDb.orders
                              .Include(o => o.customer)
                              .Include(o => o.itemList)
                              .ThenInclude(itemList => itemList.product)
                              .Where(o => o.Id == id).FirstOrDefault();
            if(order == null)
            {
                return NotFound();
            }
            return order;
        }

        //修改订单
        // PUT: api/Orders/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                Order orderToModify = orderDb.orders
                                          .Include(o => o.itemList)
                                          .Include(o => o.customer)
                                          .Where(o => o.Id == id)
                                          .FirstOrDefault();
                if(orderToModify == null)
                {
                    return BadRequest("The order to be modified doesn't exist!");
                }
                orderToModify.ModifyItemList(order.itemList);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //添加订单
        // POST: api/Orders
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                var customer = orderDb.customers.Where(c => c.Id == order.customer.Id).FirstOrDefault();
                if (customer != null) order.customer = customer;//若order的customer已存在于数据库中，则将数据库中的对应实体赋值给order.customer
                orderDb.orders.Add(order);
                orderDb.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        //删除订单
        // DELETE: api/Orders/{id}
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            try
            {
                var order = orderDb.orders.Include("itemList").FirstOrDefault(o => o.Id == id);
                if (order != null)
                {
                    orderDb.orders.Remove(order);
                    orderDb.SaveChanges();
                }
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}
