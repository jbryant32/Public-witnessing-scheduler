using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
namespace PWSSchduler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PendingBookingsDetailPage : ContentPage
    {

        bool _PageBusy;
        public bool PageBusy { get => _PageBusy; set { OnPropertyChanged(nameof(PageBusy)); _PageBusy = value; } }
        bool _UpdateSucess;
        public bool UpdateSucess { get => _UpdateSucess; set { OnPropertyChanged(nameof(UpdateSucess)); _UpdateSucess = value; } }
        string _IsBusyMessage = "Updating Booking.....";
        public string IsBusyMessage { get => _IsBusyMessage; set { OnPropertyChanged(nameof(IsBusyMessage)); _IsBusyMessage = value; } }
        bool _IndicatorRunning;
        public bool IndicatorRunning { get => _IndicatorRunning; set { OnPropertyChanged(nameof(IndicatorRunning)); _IndicatorRunning = value; } }
        Booking _booking;
        public Booking booking { get => _booking ?? new Booking(); set { OnPropertyChanged(nameof(booking)); _booking = value; } }
        public PendingBookingsDetailPage(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
            this.BindingContext = this;
        }
        public PendingBookingsDetailPage()
        {

        }

        private async void ButtonConfirmed_Clicked(object sender, EventArgs e)
        {

            await Task.Run(async () =>
            {
                this.IndicatorRunning = true;
                this.PageBusy = true;
                this.UpdateSucess = false;
                var Bookings = (await DataStore.GetLocalBookings());
                var Results = Bookings.Where((b) => b.ScheduledDate == booking.ScheduledDate).FirstOrDefault();
                Bookings[Bookings.IndexOf(Results)].Status = "Confirmed";
                await DataStore.UpdateLocal(Bookings);
                Thread.Sleep(2000);
            });

            this.IndicatorRunning = false;
            this.UpdateSucess = true;
            this.IsBusyMessage = "Update Completed";
        }
    }
}