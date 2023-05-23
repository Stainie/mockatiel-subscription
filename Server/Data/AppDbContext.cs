using Microsoft.EntityFrameworkCore;
using SharedResources.Models;

namespace Server.Data
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const int amountOfProductsToSeed = 10;

            var productsToSeed = new Product[amountOfProductsToSeed];

            for (var i = 0; i < amountOfProductsToSeed; i++)
            {
                productsToSeed[i] = new Product
                {
                    Name = $"Product {i + 1}",
                    Description = $"Description for product {i + 1}",
                    Price = (i + 1) * 10,
                    ImageUrl = $"https://picsum.photos/seed/{i + 1}/200/300"
                };
            }

            modelBuilder.Entity<Product>().HasData(productsToSeed);
        }
    }
}
