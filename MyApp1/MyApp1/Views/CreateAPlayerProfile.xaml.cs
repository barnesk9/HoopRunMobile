using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyApp1.Models;
using MyApp1.Services;

namespace MyApp1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAPlayerProfile : ContentPage
	{
        RestService restService = new RestService();
		public CreateAPlayerProfile ()
		{
			InitializeComponent();
		}

	    private async void JoinButton_OnClicked(object sender, EventArgs e)
	    {
            Player player = new Player()
            {
                Firstname = FirstNameEntry.Text,
                Lastname = LastNameEntry.Text,
                Username = FirstNameEntry.Text + LastNameEntry.Text,
                Email = EmailEntry.Text,
                DateOfBirth = DateTime.Now,
                Password = PasswordEntry.Text,
                Gender = "Male",
                Status = true
            };

            if(await restService.AddPlayerAsync(player,true))
            { await Navigation.PushModalAsync((new FindRunMapView())); }
        }


	}
}