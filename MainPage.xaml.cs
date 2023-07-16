using MauiApp_Test1.ViewModel;

namespace MauiApp_Test1;

public partial class MainPage : ContentPage
{
	//Sample with URI shell-based navigation 
	// URI-based navigations & passing data between pages 

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		// We can do Binding MainViewModel to the Main page by as below:
		//BindingContext = new MainViewModel();  this is one way to do it

		// Or we can use DI by passing in (Binding at the Constructor). And do the below line
		BindingContext = vm; // Now we need to register to the system as dependency service @ MauiProgram.cs 
	}

	
}

