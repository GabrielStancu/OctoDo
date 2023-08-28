using SQLite;

namespace OctoDo.Client.Core.Models;
public class BaseModel
{
    public BaseModel()
    {
        Id = Guid.NewGuid();
    }

    [PrimaryKey]
    public Guid Id { get; set; }
    public bool Disabled { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
