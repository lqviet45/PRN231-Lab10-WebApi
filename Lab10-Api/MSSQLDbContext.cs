using Bogus;
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
        var faker = new Faker<Product>()
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Price, f => f.Random.Decimal(1, 1000));
        
        modelBuilder.Entity<Product>().HasData(faker.Generate(5));
        base.OnModelCreating(modelBuilder);
    }
}