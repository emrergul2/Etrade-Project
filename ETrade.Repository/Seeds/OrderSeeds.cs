using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class OrderSeeds : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
            new Order { Id = 1,CustomerId = 5, PaymentId = 1, OrderDate = DateTime.Now, TotalPrice = 10m },
            new Order { Id = 2,CustomerId = 2, PaymentId = 2, OrderDate = DateTime.Now, TotalPrice = 11.5m, }
            );
        }
    }
}