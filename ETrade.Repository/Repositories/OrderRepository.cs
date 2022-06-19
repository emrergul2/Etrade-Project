using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Repository.Contexts;

namespace ETrade.Repository.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ETradeMsSqlContext context) : base(context)
        {
        }
    }
}