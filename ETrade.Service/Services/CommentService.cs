using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Core.Service;
using ETrade.Core.UnitOfWork;

namespace ETrade.Service.Services
{
    public class CommentService : GenericService<Comment>, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork, IGenericRepository<Comment> repository = null) : base(unitOfWork, repository)
        {
        }
    }
}