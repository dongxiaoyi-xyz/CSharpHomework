using System;
using System.Data.Entity;
using System.Linq;

namespace OrderManage
{

    public class OrderContext : DbContext
    {
        
        public OrderContext()
            : base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
    }

}