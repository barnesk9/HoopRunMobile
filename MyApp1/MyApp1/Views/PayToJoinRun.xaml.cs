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
	public partial class PayToJoinRun : ContentPage
	{
		public PayToJoinRun ()
		{
			InitializeComponent ();
		}

	    private async void PayButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync((new PayToJoinRun()));
        }
	}
}