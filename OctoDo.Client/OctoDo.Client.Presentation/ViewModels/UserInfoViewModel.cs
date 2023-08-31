using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OctoDo.Client.Presentation.Views;

namespace OctoDo.Client.Presentation.ViewModels;
public partial class UserInfoViewModel : BaseViewModel
{
    public UserInfoViewModel()
    {
        Title = "OctoDo";
    }

    [ObservableProperty] 
    private string _userName;

    [ObservableProperty]
    private string _profilePictureName;

    [ObservableProperty]
    private TimeSpan _dailyScheduleReset;

    [RelayCommand]
    private async Task SaveUserInfoAsync()
    {
        if (string.IsNullOrEmpty(UserName))
        {
            await Shell.Current.DisplayAlert("Missing Data", "Username is required", "OK");
            return;
        }

        Preferences.Default.Set("username", UserName);
        Preferences.Default.Set("profilePictureName",  ProfilePictureName);
        Preferences.Default.Set("dailyScheduleReset", $"{DailyScheduleReset.Hours}:{DailyScheduleReset.Minutes}");

        await Shell.Current.GoToAsync($"{nameof(MainPage)}", true);
    }
}
