namespace OctoDo.Domain.Models;
public class Plan : ModelBase
{
    public bool IsDisabled { get; set; }
    public bool IsSelectedForToday { get; set; }
}
