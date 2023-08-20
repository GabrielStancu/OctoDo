namespace OctoDo.Client.Core.Models;
public class Completion
{
    public DateTime Date { get; set; }
    public Routine? Routine { get; set; }
    public IEnumerable<ActivityStatus>? ActivityStatuses { get; set; }
}
