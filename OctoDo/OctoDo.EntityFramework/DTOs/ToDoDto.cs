using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.DTOs;
public class ToDoDto : ModelBase
{
    public int? Points { get; set; }

    public ActivityDto? Activity { get; set; }

    public RoutineDto? Routine { get; set; }
}
