using OctoDo.Presentation.Stores;
using OctoDo.Presentation.ViewModels;

namespace OctoDo.Presentation.Commands;

public class LoadPlansCommand : AsyncCommandBase
{
    private readonly PlansPageViewModel _plansPageViewModel;
    private readonly PlansStore _plansStore;

    public LoadPlansCommand(PlansPageViewModel plansPageViewModel, PlansStore plansStore)
    {
        _plansPageViewModel = plansPageViewModel;
        _plansStore = plansStore;
    }

    public override async Task ExecuteAsync(object? parameter)
    {
        _plansPageViewModel.IsLoading = true;

        try
        {
            await _plansStore.LoadAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            // TODO: maybe display the error frontend or log it properly
        }
        finally
        {
            _plansPageViewModel.IsLoading = false;
        }
    }
}