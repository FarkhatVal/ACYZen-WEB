using Microsoft.EntityFrameworkCore;

namespace ACYZenWEBAPP.Models;

public class ActionYaZenContext : DbContext
{
    public DbSet<ActionYaZen> ActionYaZens { get; set; }
    public DbSet<Order> Orders { get; set; }
 
    public ActionYaZenContext(DbContextOptions<ActionYaZenContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}