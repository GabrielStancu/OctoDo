using OctoDo.Client.Presentation.Views;

namespace OctoDo.Client.Presentation;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
