namespace OctoDo.Domain.Models;
public class ToDo : ModelBase
{
    public int? Points { get; set; }
    public int ActivityId { get; set; }
    public int RoutineId { get; set; }
}
