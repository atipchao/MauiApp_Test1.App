using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp_Test1.ViewModel
{
    [QueryProperty("Text", "Passing_Text_From_Main_Page")] // for passing qurey data from another page
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        // NOTE Data binding also needs to be done @ Detail-page UI
        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync(".."); // Goback 
        }
    }
}
