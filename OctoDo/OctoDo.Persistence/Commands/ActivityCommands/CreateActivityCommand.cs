using OctoDo.Domain.Commands.ActivityCommands;
using OctoDo.Domain.Models;

namespace OctoDo.Persistence.Commands.ActivityCommands;

public class CreateActivityCommand : ICreateActivityCommand
{
    private readonly DbContext _context;

    public CreateActivityCommand(DbContext context)
    {
        _context = context;
    }

    public async Task<Activity> ExecuteAsync(Activity activity)
    {
        _context.Connection.Insert(activity);
        await Task.Delay(10);

        return activity;
    }
}