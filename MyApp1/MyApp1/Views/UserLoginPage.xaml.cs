using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserLoginPage : ContentPage
	{
		public UserLoginPage ()
		{
			InitializeComponent ();
		}

	    private async void OpenCreateAPlayerProfilePage(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new NavigationPage(new CreateAPlayerProfile()));
	    }


	    private async void Login(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new NavigationPage(new FindRunMapView()));
	    }
    }
}