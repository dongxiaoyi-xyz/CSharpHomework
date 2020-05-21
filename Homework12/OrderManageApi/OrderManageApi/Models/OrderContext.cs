using Microsoft.EntityFrameworkCore;

namespace OrderManageApi.Models
{
    public class OrderContext: DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options): base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
