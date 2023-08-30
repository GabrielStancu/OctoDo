using OctoDo.Client.Core.Interfaces;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Repositories;
public class ActivityStatusRepository : GenericRepository<ActivityStatus>, IActivityStatusRepository
{
    public ActivityStatusRepository(string dbPath) : base(dbPath)
    {
    }
}
