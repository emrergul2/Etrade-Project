using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class OrderProductSeeds : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            // builder.HasData(
            //     new OrderProduct { OrderId = 1, ProductId = 5, Quantity = 1, Discount = 0, Price = 5m },
            //     new OrderProduct { OrderId = 1, ProductId = 3, Quantity = 1, Discount = 0, Price = 3m },
            //     new OrderProduct { OrderId = 1, ProductId = 2, Quantity = 2, Discount = 0.5m, Price = 2m },
            //     new OrderProduct { OrderId = 2, ProductId = 10, Quantity = 1, Discount = 0.25m, Price = 10m },
            //     new OrderProduct { OrderId = 2, ProductId = 4, Quantity = 1, Discount = 0, Price = 4m }
            // );
        }
    }
}