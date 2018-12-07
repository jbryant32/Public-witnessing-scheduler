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

namespace PWSSchduler.ViewModels
{
    public class PendingBookingViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get { return _Bookings; } set { _Bookings = value; } }
        public Command RefreshList => RefreshList ?? new Command(async () => {
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
        public async void GetLocalBookings()
        {
            Bookings.Clear();
            var listing = await Task.Run(async () => { return (await DataStore.GetLocalBookings()).Where((b) => b.Status == "Unconfirmed"); });
            foreach (var booking in listing)
            {
                Bookings.Add(booking);
            }
        }
      
    }
}
