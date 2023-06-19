using RoboAPI.Domain.Entities;

namespace RoboAPI.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(long id);
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync();

    }
}
