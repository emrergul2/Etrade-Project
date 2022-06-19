using ETrade.Core.Modals;

namespace ETrade.Core.Repository
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}