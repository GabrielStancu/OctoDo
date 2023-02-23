using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.ActivityCommands;

public interface IDisableActivityCommand
{
    public Task<Activity> ExecuteAsync(Activity activity);
}