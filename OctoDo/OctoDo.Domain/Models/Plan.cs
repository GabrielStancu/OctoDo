namespace OctoDo.Domain.Models;
public class Plan : ModelBase
{
    public IEnumerable<Activity?>? Activities { get; set; }
    public IEnumerable<Routine?>? Routines { get; set; }
    public bool IsActive { get; set; }
}
