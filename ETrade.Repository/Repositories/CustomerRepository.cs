using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Repository.Contexts;

namespace ETrade.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ETradeMsSqlContext context) : base(context)
        {
        }
    }
}