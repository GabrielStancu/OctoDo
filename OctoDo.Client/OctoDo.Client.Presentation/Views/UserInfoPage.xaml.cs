using OctoDo.Client.Presentation.ViewModels;

namespace OctoDo.Client.Presentation.Views;

public partial class UserInfoPage : ContentPage
{
	public UserInfoPage(UserInfoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}