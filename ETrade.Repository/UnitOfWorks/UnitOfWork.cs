
using ETrade.Core.UnitOfWork;

namespace ETrade.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}