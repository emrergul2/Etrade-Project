using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Core.Service;
using ETrade.Core.UnitOfWork;

namespace ETrade.Service.Services
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork, IGenericRepository<Order> repository = null) : base(unitOfWork, repository)
        {
        }
    }
}