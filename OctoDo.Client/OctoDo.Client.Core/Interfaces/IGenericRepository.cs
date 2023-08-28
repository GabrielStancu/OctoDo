using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;
public interface IGenericRepository<T> where T : BaseModel
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> ListAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
