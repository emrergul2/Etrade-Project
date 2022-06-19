using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Core.Service;
using ETrade.Core.UnitOfWork;

namespace ETrade.Service.Services
{
    public class BrandService : GenericService<Brand>, IBrandService
    {
        public BrandService(IUnitOfWork unitOfWork, IGenericRepository<Brand> repository) : base(unitOfWork, repository)
        {
        }
    }
}