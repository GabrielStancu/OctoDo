using OctoDo.Domain.Commands.ActivityCommands;
using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.Commands.ActivityCommands;

public class CreateActivityCommand : ICreateActivityCommand
{
    public async Task<Activity> ExecuteAsync(Activity activity)
    {
        await Task.Delay(10);
        throw new NotImplementedException();
    }
}