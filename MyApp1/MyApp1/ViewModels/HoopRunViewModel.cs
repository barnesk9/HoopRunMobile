using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MyApp1.Models;
using Xamarin.Forms;


namespace MyApp1.ViewModels
{
    public class HoopRunViewModel : BaseViewModel
    {
        public Item ab { get; set; }
        public Command UpdateCommand { get; set; }
        DemoCustomer dc = new DemoCustomer();
        public event PropertyChangedEventHandler PropertyChanged;

        Item newStuff = new Item();

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public HoopRunViewModel()
        {
            LabelText = "This is a test of the label";
            //UpdateCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        /*
        async Task ExecuteLoadItemsCommand()
        {

            newStuff.Text = "text";
        }
        */

        public string LabelText;

        public string CustomerName
        {
            get
            {
                return newStuff.Text;
            }

            set
            {
                if (value != newStuff.Text)
                {
                    newStuff.Text = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
