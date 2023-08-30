namespace OctoDo.Client.Core.Models;
public class Routine : BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public RecurrenceType RecurrenceType { get; set; }
    public string? DaysOfWeek { get; set; }
    public string? DaysOfMonth { get; set; }
    public string? Month { get; set; }
    public string? Year { get; set; }
    public IEnumerable<Activity>? Activities { get; set; }
    public IEnumerable<Completion>? Completions { get; set; }
}
