using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PWSSchduler.ViewModels
{
    public class TodayViewModel:ViewModel 
    {
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get { return _Bookings; } set { _Bookings = value;  } }

         public TodayViewModel()
        {
            if (Bookings.Count > 0) {
                Bookings.Clear();
            }
        }


        public async Task<Booking[]> LoadBookings()
        {
            throw new NotImplementedException();
        }
        public async Task SimulateHttpGet()
        {
            if (Bookings.Count > 0)
            {
                Bookings.Clear();
            }
            await Task.Run( async () => {
                Thread.Sleep(2000);
                foreach (var booking in await DataStore.GetLocalBookings())
                {
                    if (DateTime.Today.ToString() == booking.ScheduledDate)
                        Bookings.Add(booking);
                }

            });
            this.PageBusy = false;
            this.PageInputEnabled = true;
           
        }
    }
}
