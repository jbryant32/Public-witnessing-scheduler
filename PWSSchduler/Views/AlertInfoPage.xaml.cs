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
	public partial class AlertInfoPage : ContentPage
	{
        private Alert AlertInfo { get; set; }
        Booking _booking;
        public Booking booking { get=>_booking; set{ _booking = value; OnPropertyChanged(); } }
        public AlertInfoPage (Alert AlertInfo)
		{
            this.AlertInfo = AlertInfo;
			InitializeComponent ();
		}
        public AlertInfoPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await GetAlert();
            base.OnAppearing();
        }
        private async Task GetAlert() {

            var bookings= await DataStore.GetLocalBookings();
            booking = bookings.Where((b) => { return b.GID == this.AlertInfo.GID; }).FirstOrDefault();
        }
    }
}