using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HoopRunStart : ContentPage
	{
		public HoopRunStart ()
		{
			InitializeComponent ();
		    LogoImage.Source = "hooprunLogo.PNG";
		    //LogoImage.BackgroundColor = Color.Red;
		}

	    private async void OpenAboutPage(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new NavigationPage(new UserLoginPage()));
        }
    }
}