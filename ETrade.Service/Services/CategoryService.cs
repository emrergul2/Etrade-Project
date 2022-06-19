using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Core.Service;
using ETrade.Core.UnitOfWork;

namespace ETrade.Service.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> repository = null) : base(unitOfWork, repository)
        {
        }
    }
}