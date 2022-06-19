using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Repository.Contexts;

namespace ETrade.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ETradeMsSqlContext context) : base(context)
        {
        }
    }
}