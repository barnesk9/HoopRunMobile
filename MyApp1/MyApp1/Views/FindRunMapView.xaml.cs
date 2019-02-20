using MyApp1.Models;
using MyApp1.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        List<Player> playerList;

		public FindRunMapView ()
		{
			InitializeComponent ();
		    isMapView = true;
		    isListView = false;
		    MapView.Source = "c:/temp/hooprunLogo.PNG";
		}

	    public async void ChangeView(object sender, EventArgs e)
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
                ListOfRuns.ItemsSource = await getPlayers();
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

        private async Task<List<Player>> getPlayers()
        {
            RestService ab = new RestService();
            playerList = await ab.returnPlayerList();

            return playerList;
        }

	    private List<string> createRunList()
	    {
            var runList = new List<string>();
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
            //RestService ab = new RestService();
	        await Navigation.PushModalAsync((new WhoIsRunning()));
        }
	}
}