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

        List<Gym> gymList;

		public FindRunMapView ()
		{
			InitializeComponent ();
		    isMapView = true;
		    isListView = false;
		    MapView.Source = "c:/temp/hooprunLogo.PNG";
		}

	    public void ChangeView(object sender, EventArgs e)
	    {
            //Map View Is Visible, change to list
	        if (isMapView)
	        {
                EnableListView();
            }
            // List view is visible, change to map view
	       else
	        {
                EnableMapView();
           }
	    }

        private void EnableListView()
        {
            MapView.IsVisible = false;
            ListOfRuns.IsVisible = true;
            MapButton.BackgroundColor = Color.White;
            ListButton.BackgroundColor = Color.Green;
            isListView = true;
            isMapView = false;
            getGymList();
        }

        private void EnableMapView()
        {
            ListOfRuns.IsVisible = false;
            MapButton.BackgroundColor = Color.Green;
            ListButton.BackgroundColor = Color.White;
            MapView.IsVisible = true;
            isListView = false;
            isMapView = true;
        }

        private async void getGymList()
        {
            RestService ab = new RestService();
            gymList = await ab.returnGymList();

            ListOfRuns.ItemsSource = gymList;
            ListOfRuns.ItemTemplate = new DataTemplate(typeof(TextCell));
            ListOfRuns.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
        }

	    private async void Advance(object sender, SelectedItemChangedEventArgs e)
	    {
            Gym a = (Gym)e.SelectedItem;
	        await Navigation.PushModalAsync((new WhoIsRunning((Gym)e.SelectedItem)));
        }
	}
}