using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WhoIsRunning : ContentPage
	{
		public WhoIsRunning ()
		{
			InitializeComponent ();
		    addHooperImages(); 

		}

	    private void addHooperImages()
	    {
	        for (int i = 0; i < 29; i++)
	        {
	            Image HooperImage = new Image();
	            HooperImage.HeightRequest =80;
	            HooperImage.WidthRequest = 80;
	            HooperImage.BackgroundColor = Color.Gray;
	            HooperImage.Margin = 5;
	            HooperImages.Children.Add(HooperImage);
	        }
	    }

	    private async void JoinButtonClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync((new RunPaymentConfirmed()));
        }
	}
}