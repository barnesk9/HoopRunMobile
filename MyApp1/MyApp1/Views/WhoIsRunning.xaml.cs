using MyApp1.Models;
using MyApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WhoIsRunning : ContentPage
	{
        public List<Player> Players { get; private set; }
        RestService restService = new RestService();

        public WhoIsRunning()
		{
			InitializeComponent ();
		    addHooperImages();
            GymImage.Source = "https://www.telegraph.co.uk/content/dam/luxury/2017/03/21/Gym_2_trans_NvBQzQNjv4BqgsaO8O78rhmZrDxTlQBjdGcv5yZLmao6LolmWYJrXns.jpg?imwidth=1400";
        }

        public WhoIsRunning(Gym currentGym)
        {
            InitializeComponent();
            addHooperImages();
            GymImage.Source = "https://www.telegraph.co.uk/content/dam/luxury/2017/03/21/Gym_2_trans_NvBQzQNjv4BqgsaO8O78rhmZrDxTlQBjdGcv5yZLmao6LolmWYJrXns.jpg?imwidth=1400";
            GymInfo.Text = currentGym.Summary;
        }

	    private async void addHooperImages()
	    {
            Players = await restService.returnPlayerList();

            foreach (Player p in Players )
	        {
	            Image HooperImage = new Image();
	            HooperImage.HeightRequest =80;
	            HooperImage.WidthRequest = 80;
	            HooperImage.BackgroundColor = Color.Gray;
	            HooperImage.Margin = 5;
                HooperImage.Source = p.ProfilePicture;
	            HooperImages.Children.Add(HooperImage);
	        }
	    }

        private async void JoinButtonClicked(object sender, EventArgs e)
	    {
            await DisplayAlert("Congrats You've joined the run", "", "OK");
            await Navigation.PushModalAsync((new RunPaymentConfirmed()));
        }
	}
}