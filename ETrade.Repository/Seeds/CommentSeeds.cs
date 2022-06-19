using ETrade.Core.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETrade.Repository.Seeds
{
    public class CommentSeeds : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            // builder.HasData(
            //     new Comment { Id = 1, ProductId = 10, CustomerId = 1, CustomerComment = "Good" },
            //     new Comment { Id = 2, ProductId = 2, CustomerId = 4, CustomerComment = "Good" },
            //     new Comment { Id = 3, ProductId = 4, CustomerId = 5, CustomerComment = "Good" },
            //     new Comment { Id = 4, ProductId = 5, CustomerId = 4, CustomerComment = "Good" },
            //     new Comment { Id = 5, ProductId = 5, CustomerId = 5, CustomerComment = "Good" },
            //     new Comment { Id = 6, ProductId = 7, CustomerId = 4, CustomerComment = "Good" },
            //     new Comment { Id = 7, ProductId = 7, CustomerId = 3, CustomerComment = "Good" },
            //     new Comment { Id = 8, ProductId = 8, CustomerId = 3, CustomerComment = "Good" },
            //     new Comment { Id = 9, ProductId = 9, CustomerId = 2, CustomerComment = "Good" },
            //     new Comment { Id = 10, ProductId = 8, CustomerId = 1, CustomerComment = "Good" },
            //     new Comment { Id = 11, ProductId = 1, CustomerId = 1, CustomerComment = "Good" }
            //     );
        }
    }
}