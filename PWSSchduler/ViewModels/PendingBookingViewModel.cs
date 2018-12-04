using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
        Booking[] _Bookings;
        public Booking[] Bookings { get { return (_Bookings ?? new Booking[0]); } set { OnPropertyChanged(); _Bookings = value; } }
        public PendingBookingViewModel()
        {

        }
        public async void GetLocalBookings()
        {
            Bookings = await Task.Run(async () => { return (await DataStore.GetLocalBookings()).Where((b) => b.Status == "Unconfirmed").ToArray(); });
        }
      
    }
}
