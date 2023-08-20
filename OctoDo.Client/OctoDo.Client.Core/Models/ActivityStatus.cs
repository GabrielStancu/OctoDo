namespace OctoDo.Client.Core.Models;
public class ActivityStatus : BaseModel
{
    public Completion? Completion { get; set; }
    public Activity? Activity { get; set; }
    public bool Completed { get; set; }
}
