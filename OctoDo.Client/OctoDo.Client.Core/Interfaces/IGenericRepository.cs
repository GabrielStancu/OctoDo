using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;
public interface IGenericRepository<T> where T : BaseModel
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> ListAllAsync();
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
