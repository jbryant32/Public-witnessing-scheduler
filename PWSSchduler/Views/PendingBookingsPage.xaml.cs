using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PendingBookingsPage : ContentPage
    {
        public PendingBookingsPage()
        {
            InitializeComponent();
            
        }



        private async void ListViewPendingBookings_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Booking;
            await DisplayAlert("Set Booking Status", "Please Confirm Booking", "Confirm", "Cancel");
          
        }
    }
}