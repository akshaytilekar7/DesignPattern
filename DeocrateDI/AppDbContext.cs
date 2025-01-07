using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeocrateDI;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Payment> Payment { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}

public class Payment
{
    public int Id { get; set; }
    public string Name { get; set; }
}
