using System.Data.Entity;

namespace Muse.Model
{
    public class RestoContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}