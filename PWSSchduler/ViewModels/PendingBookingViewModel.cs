using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading;

namespace PWSSchduler.ViewModels
{
    public class PendingBookingViewModel : ViewModel
    {

     
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get { return _Bookings; } set { _Bookings = value; } }
        public Command RefreshList => RefreshList ?? new Command(async () =>
        {
            Bookings.Clear();
            var listing = await Task.Run(async () => { return (await DataStore.GetLocalBookings()).Where((b) => b.Status == "Unconfirmed"); });
            foreach (var booking in listing)
            {
                Bookings.Add(booking);
            }
        });
    

        public PendingBookingViewModel()
        {

        }
        public async Task GetLocalBookings()
        {
            PageBusy = true;
            await Task.Run(async () =>
            {
                Bookings.Clear();
                var listing = await Task.Run(async () => { return (await DataStore.GetLocalBookings()).Where((b) => b.Status == "Unconfirmed"); });
                Thread.Sleep(3000);
                foreach (var booking in listing)
                {
                    Bookings.Add(booking);
                }
            });
            PageBusy = false;
            PageInputEnabled = true;
        }

    }
}
