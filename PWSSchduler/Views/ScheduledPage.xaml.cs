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
	public partial class ScheduledPage : ContentPage
	{
       
        public ScheduledPage ()
		{
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            await this.ViewModel.LoadBookings();
         
            base.OnAppearing(); 
        }

        private async void ListScheduledBookings_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new BookingItemDetailPage(e.Item as Booking));
        }
    }
}