using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.ActivityCommands;

public interface ICreateActivityCommand
{
    public Task<Activity> ExecuteAsync(Activity activity);
}