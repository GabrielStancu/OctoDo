namespace OctoDo.Domain.Models;
public class ToDo : ModelBase
{
    public int? Points { get; set; }
    public Activity? Activity { get; set; }
    public Routine? Routine { get; set; }
}
