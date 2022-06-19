using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class CategorySeeds : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Category-1", Description = "Description" },
                new Category { Id = 2, Name = "Category-2", Description = "Description" },
                new Category { Id = 3, Name = "Category-3", Description = "Description" },
                new Category { Id = 4, Name = "Category-4", Description = "Description" },
                new Category { Id = 5, Name = "Category-5", Description = "Description" },
                new Category { Id = 6, Name = "Category-6", Description = "Description" }
            );
        }
    }
}