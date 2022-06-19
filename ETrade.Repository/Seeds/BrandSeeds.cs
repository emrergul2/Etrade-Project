using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class BrandSeeds : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, Name = "Brand-1" },
                new Brand { Id = 2, Name = "Brand-2" },
                new Brand { Id = 3, Name = "Brand-3" },
                new Brand { Id = 4, Name = "Brand-4" },
                new Brand { Id = 5, Name = "Brand-5" },
                new Brand { Id = 6, Name = "Brand-6" },
                new Brand { Id = 7, Name = "Brand-7" },
                new Brand { Id = 8, Name = "Brand-8" },
                new Brand { Id = 9, Name = "Brand-9" },
                new Brand { Id = 10, Name = "Brand-10" },
                new Brand { Id = 11, Name = "Brand-11" }
            );
        }
    }
}