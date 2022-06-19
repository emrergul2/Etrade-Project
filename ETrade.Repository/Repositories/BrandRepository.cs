using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Repository.Contexts;

namespace ETrade.Repository.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ETradeMsSqlContext context) : base(context)
        {
        }
    }
}