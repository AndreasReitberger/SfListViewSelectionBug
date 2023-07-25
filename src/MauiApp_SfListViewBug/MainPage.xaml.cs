using MauiApp_SfListViewBug.ViewModels;

namespace MauiApp_SfListViewBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}

