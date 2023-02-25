using OctoDo.Domain.Models;

namespace OctoDo.Persistence.DTOs;
public class ToDoDto : ModelBase
{
    public int? Points { get; set; }

    //public ActivityDto? Activity { get; set; }
    public int? ActivityId { get; set; }

    //public RoutineDto? Routine { get; set; }
    public int RoutineId { get; set; }
}
