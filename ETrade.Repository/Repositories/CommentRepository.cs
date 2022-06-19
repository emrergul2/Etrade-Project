using ETrade.Core.Modals;
using ETrade.Core.Repository;
using ETrade.Repository.Contexts;

namespace ETrade.Repository.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ETradeMsSqlContext context) : base(context)
        {
        }
    }
}