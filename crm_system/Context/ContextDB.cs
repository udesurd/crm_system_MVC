using crm_system.Models;
using Microsoft.EntityFrameworkCore;

namespace crm_system.Context
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Sell> Sells { get; set; }
    }
}
