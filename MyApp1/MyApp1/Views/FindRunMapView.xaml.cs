using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FindRunMapView : ContentPage
	{
	    private bool isMapView;
	    private bool isListView;
	    private Image mapView; 

		public FindRunMapView ()
		{
			InitializeComponent ();
		    isMapView = true;
		    isListView = false;
		    ListOfRuns.ItemsSource = createRunList();
		    MapView.Source = "c:/temp/hooprunLogo.PNG";
		}

	    private void ChangeView(object sender, EventArgs e)
	    {
            //Map View Is Visible, change to list
	        if (isMapView)
	        {
	            MapView.IsVisible = false;
	            ListOfRuns.IsVisible = true;
	            MapButton.BackgroundColor = Color.White;
	            ListButton.BackgroundColor = Color.Orange;
                isListView = true;
	            isMapView = false;
	        }
            // List view is visible, change to map view
	       else
	        {
	           ListOfRuns.IsVisible = false;
	            MapButton.BackgroundColor = Color.Orange;
                ListButton.BackgroundColor = Color.White;
	           MapView.IsVisible = true;
	           isListView = false;
	           isMapView = true;
           }
	    }

	    private List<String> createRunList()
	    {
            var runList = new List<String>();
	        int i = 0;

	        while (i != 30)
	        {
	            runList.Add("test run: " + i);
                i++;
            }

	        return runList;
	    }

	    private async void testMethod(object sender, SelectedItemChangedEventArgs e)
	    {
            RestService ab = new RestService();
	        await Navigation.PushModalAsync((new WhoIsRunning()));
        }
	}
}