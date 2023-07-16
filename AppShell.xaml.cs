namespace MauiApp_Test1;

public partial class AppShell : Shell
{

    //By Default "MainPage" is the start page
    public AppShell()
	{
		InitializeComponent();

        // Here we register the new routing 

        //Routing.RegisterRoute("Detail Page", typeof(DetailPage));  // this is Okay too
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        // Next we add Navigations @ mainPage
	}
}
