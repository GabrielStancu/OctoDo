using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Core.Interfaces;
public interface ICompletionRepository
{
    Task CreateCompletionAsync(Completion completion);
    Task DeleteCompletionAsync(Completion completion);
}
