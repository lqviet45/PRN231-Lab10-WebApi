using Bogus;
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
        var faker = new Faker<Product>()
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Price, f => f.Random.Decimal(1, 1000));
        
        modelBuilder.Entity<Product>().HasData(faker.Generate(5));
        base.OnModelCreating(modelBuilder);
    }
}