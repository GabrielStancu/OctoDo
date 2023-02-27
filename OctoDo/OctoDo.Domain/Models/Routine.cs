namespace OctoDo.Domain.Models;
public class Routine : ModelBase
{
    public DateTime? Date { get; set; }
    public int PlanId { get; set; }
}
