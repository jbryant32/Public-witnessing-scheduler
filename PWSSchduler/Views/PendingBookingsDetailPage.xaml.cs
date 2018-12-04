using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PendingBookingsDetailPage : ContentPage
    {
        bool _BookingsDetailViewisVisible = true;
        public bool BookingsDetailViewisVisible { get => _BookingsDetailViewisVisible; set { OnPropertyChanged(nameof(BookingsDetailViewisVisible)); _BookingsDetailViewisVisible = value;  ; } }
        
        bool _PageBusy = false;
        public bool PageBusy { get => _PageBusy; set { OnPropertyChanged(nameof(PageBusy)); _PageBusy = value;  } }
        bool _UpdateSucess = false;
        public bool UpdateSucess { get => _UpdateSucess; set { OnPropertyChanged(nameof(UpdateSucess)); _UpdateSucess = value; } }
        bool _UpdateFailed = false;
        public bool UpdateFailed { get => _UpdateFailed; set { OnPropertyChanged(nameof(PageBusy)); _UpdateFailed = value; } }
        Booking _booking;
        public Booking booking { get => _booking ?? new Booking(); set { OnPropertyChanged(nameof(booking)); _booking = value; } }
        public PendingBookingsDetailPage(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
            this.Content.BindingContext = this;
        }
        public PendingBookingsDetailPage()
        {

        }

        private async void ButtonConfirmed_Clicked(object sender, EventArgs e)
        {
            
            await Task.Run(async () =>
            {
                this.BookingsDetailViewisVisible = false;
                this.PageBusy = true;
                this.UpdateSucess = false;
                var Bookings = await Task.Run(async () => { return (await DataStore.GetLocalBookings()).Where((b) => b.Status == "Unconfirmed").ToArray(); });
                var toConfirm = Bookings.Where((b) => booking.ScheduledDate == booking.ScheduledDate).Select(b => b).FirstOrDefault();
                toConfirm.Status = "Confirmed";//TODO check http call completed ok first 
                this.booking.Status = "Confirmed";
                Thread.Sleep(2000);
            });
          
            this.PageBusy= false;
            this.UpdateSucess = true;
        }
    }
}