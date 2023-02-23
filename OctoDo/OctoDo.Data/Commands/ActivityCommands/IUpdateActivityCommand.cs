using OctoDo.Domain.Models;

namespace OctoDo.Domain.Commands.ActivityCommands;

public interface IUpdateActivityCommand
{
    public Task<Activity> ExecuteAsync(Activity activity);
}