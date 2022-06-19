using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class CustomerSeeds : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer { Id = 1, Name = "Noah", LastName = "EE", City = "London", District = "-", Street = "-", Address = "-" },
                new Customer { Id = 2, Name = "John", LastName = "AA", City = "Springfield", District = "-", Street = "-", Address = "-" },
                new Customer { Id = 3, Name = "Jack", LastName = "BB", City = "Washington", District = "-", Street = "-", Address = "-" },
                new Customer { Id = 4, Name = "Taylor", LastName = "HH", City = "London", District = "-", Street = "-", Address = "-" },
                new Customer { Id = 5, Name = "Liam", LastName = "SS", City = "Georgetown", District = "-", Street = "-", Address = "-" }
            );
        }
    }
}