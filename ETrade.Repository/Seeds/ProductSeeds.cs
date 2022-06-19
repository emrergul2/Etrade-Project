using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, BrandId = 5, Name = "Product-1", Price = 1m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 2, CategoryId = 3, BrandId = 2, Name = "Product-2", Price = 2m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 3, CategoryId = 4, BrandId = 3, Name = "Product-3", Price = 3m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 4, CategoryId = 6, BrandId = 7, Name = "Product-4", Price = 4m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 5, CategoryId = 6, BrandId = 1, Name = "Product-5", Price = 5m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 6, CategoryId = 4, BrandId = 4, Name = "Product-6", Price = 6m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 7, CategoryId = 3, BrandId = 10, Name = "Product-7", Price = 7m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 8, CategoryId = 2, BrandId = 9, Name = "Product-8", Price = 8m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 9, CategoryId = 3, BrandId = 8, Name = "Product-9", Price = 9m, Color = "-", ModelYear = DateTime.Now, Discount = 0 },
                new Product { Id = 10, CategoryId = 1, BrandId = 6, Name = "Product-10", Price = 10m, Color = "-", ModelYear = DateTime.Now, Discount = 0 }
            );
        }
    }
}