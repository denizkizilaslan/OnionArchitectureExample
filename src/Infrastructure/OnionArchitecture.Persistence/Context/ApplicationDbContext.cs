using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Context;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Product 1 Name", Description = "Product 1 Description", Price = 1000, Stock = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Product 2 Name", Description = "Product 2 Description", Price = 2000, Stock = 20 }
                );
        }
    }
}