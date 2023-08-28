using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;
using SQLite;

namespace OctoDo.Client.Infrastructure.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel, new()
{
    private readonly string _dbPath;
    protected SQLiteAsyncConnection? Connection;

    public string StatusMessage { get; set; }

    public GenericRepository(string dbPath)
    {
        _dbPath = dbPath;
        StatusMessage = string.Empty;
    }

    protected async Task InitAsync()
    {
        if (Connection != null)
            return;

        Connection = new SQLiteAsyncConnection(_dbPath);
        await Connection.CreateTableAsync<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        try
        {
            await InitAsync();
            return await Connection!
                .Table<T>()
                .FirstOrDefaultAsync(e => e.Id == id && !e.Disabled);
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to retrieve entity of type {typeof(T)} with id {id}. {ex.Message}";
        }

        return null;
    }

    public async Task<IEnumerable<T>> ListAllAsync()
    {
        try
        {
            await InitAsync();
            return await Connection!
                .Table<T>()
                .Where(e => !e.Disabled)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to retrieve entities of type {typeof(T)}. {ex.Message}";
        }

        return Enumerable.Empty<T>();
    }

    public async Task AddAsync(T entity)
    {
        try
        {
            await InitAsync();
            await Connection!.InsertAsync(entity);
            StatusMessage = $"Entity with id {entity.Id} was added";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to add entity with id {entity.Id}. {ex.Message}";
        }
    }

    public async Task UpdateAsync(T entity)
    {
        try
        {
            await InitAsync();
            await Connection!.UpdateAsync(entity);
            StatusMessage = $"Entity with id {entity.Id} was updated";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to update entity with id {entity.Id}. {ex.Message}";
        }
    }

    public async Task DeleteAsync(T entity)
    {
        try
        {
            await InitAsync();
            entity.Disabled = true;
            await Connection!.UpdateAsync(entity);
            StatusMessage = $"Entity with id {entity.Id} was deleted";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to delete entity with id {entity.Id}. {ex.Message}";
        }
    }
}
