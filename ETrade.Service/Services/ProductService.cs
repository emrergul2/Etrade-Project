using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Core.Service;
using ETrade.Core.UnitOfWork;

namespace ETrade.Service.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public readonly IProductRepository _productRepository;
        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> repository, IProductRepository productRepository) : base(unitOfWork, repository)
        {
            _productRepository = productRepository;
        }
    }
}