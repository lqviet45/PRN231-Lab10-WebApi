using Lab10_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab10_Api;

public class MSSQLDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public MSSQLDbContext(DbContextOptions<MSSQLDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}