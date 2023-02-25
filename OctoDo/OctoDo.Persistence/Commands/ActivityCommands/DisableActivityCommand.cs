using OctoDo.Domain.Commands.ActivityCommands;
using OctoDo.Domain.Models;

namespace OctoDo.Persistence.Commands.ActivityCommands;

public class DisableActivityCommand : IDisableActivityCommand
{
    public async Task<Activity> ExecuteAsync(Activity activity)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}