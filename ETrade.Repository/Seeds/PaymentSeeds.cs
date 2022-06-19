using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class PaymentSeeds : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                new Payment { Id = 1, TotalPrice = 10m },
                new Payment { Id = 2, TotalPrice = 11.5m }
            );
        }
    }
}