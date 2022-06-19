using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Core.Service;
using ETrade.Core.UnitOfWork;

namespace ETrade.Service.Services
{
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        public CustomerService(IUnitOfWork unitOfWork, IGenericRepository<Customer> repository = null) : base(unitOfWork, repository)
        {
        }
    }
}