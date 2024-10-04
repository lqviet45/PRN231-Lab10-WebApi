using Lab10_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab10_Api;

public class MySqlDbcontext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public MySqlDbcontext(DbContextOptions<MySqlDbcontext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}