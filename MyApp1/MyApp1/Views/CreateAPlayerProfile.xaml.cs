using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAPlayerProfile : ContentPage
	{
		public CreateAPlayerProfile ()
		{
			InitializeComponent ();
		}

	    private async void JoinButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync((new FindRunMapView()));
        }
	}
}