using Ecommerce.Customers.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Customers.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }


}
