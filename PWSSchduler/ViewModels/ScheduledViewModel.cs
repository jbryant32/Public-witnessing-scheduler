using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PWSSchduler.ViewModels
{
    public class ScheduledViewModel
    {
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get => _Bookings; set => _Bookings = value; }
        public ScheduledViewModel()
        {

        }

        public async void LoadBookings() {
            Bookings.Clear();
             var results =   (await DataStore.GetLocalBookings()).Where((b)=>b.Status == "Confirmed").Select((b)=>b);
            foreach (var booking in results)
            {
                Bookings.Add(booking);
            }
        }
    }
}
