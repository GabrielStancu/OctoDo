using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class CompletionRepository : GenericRepository<Completion>, ICompletionRepository
{
    public CompletionRepository(string dbPath) : base(dbPath)
    {
    }
}
