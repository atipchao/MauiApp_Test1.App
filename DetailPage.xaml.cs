using MauiApp_Test1.ViewModel;

namespace MauiApp_Test1;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm) // Associate DetailViewModel with the DetailPage
    {
        
        InitializeComponent();
        BindingContext = vm; // Set Binding Context to vm - the code behind - don't forget to register it
                             // @ MauiProgram.cs
	}
}