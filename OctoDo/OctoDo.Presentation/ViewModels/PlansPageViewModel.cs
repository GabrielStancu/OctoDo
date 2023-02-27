using System.Windows.Input;
using OctoDo.Presentation.Commands;
using OctoDo.Presentation.Stores;

namespace OctoDo.Presentation.ViewModels;

public class PlansPageViewModel : ViewModelBase
{
    public ICommand LoadPlansCommand { get; }
    public ICommand CreatePlanCommand { get; }
    public ICommand UpdatePlanCommand { get; }
    public ICommand SelectPlanCommand { get; }

    private bool _isLoading;
    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            _isLoading = value;
            OnPropertyChanged();
        }
    }

    public PlansPageViewModel(PlansStore plansStore)
    {
        LoadPlansCommand = new LoadPlansCommand(this, plansStore);
    }

    public static PlansPageViewModel LoadViewModel(PlansStore plansStore)
    {
        var viewModel = new PlansPageViewModel(plansStore);
        viewModel.LoadPlansCommand.Execute(null);
        return viewModel;
    }
}