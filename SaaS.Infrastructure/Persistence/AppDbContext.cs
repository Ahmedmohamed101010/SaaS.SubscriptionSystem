using Microsoft.EntityFrameworkCore;
using SaaS.Domain;

namespace SaaS.Infrastructure.Persistence
{
   public class AppDbContext : DbContext
{
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
}