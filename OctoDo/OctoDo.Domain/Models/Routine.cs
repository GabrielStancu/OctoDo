namespace OctoDo.Domain.Models;
public class Routine : ModelBase
{
    public DateTime? Date { get; set; }
    public Plan? Plan { get; set; }
    public IEnumerable<Activity?>? Activities { get; set; }
}
