namespace OctoDo.Domain.Models;

public class Activity : ModelBase
{
    public int? Points { get; set; }
    public Plan? Plan { get; set; }
    public IEnumerable<ToDo?>? ToDos { get; set; }
    public bool IsDisabled { get; set; }
}
