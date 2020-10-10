using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern
{

    public class ShoppingContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder
            // .UseLazyLoadingProxies()
            //.UseSqlite("Data Source=orders.db");
        }
    }
}
