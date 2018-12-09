using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class ScheduledViewModel:ViewModel
    {
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get => _Bookings; set => _Bookings = value; }
 

        public ScheduledViewModel()
        {

        }

        public async Task LoadBookings() {
            Bookings.Clear();
            await Task.Run( async () =>
            {
                var results = (await DataStore.GetLocalBookings()).Where((b) => b.Status == "Confirmed").Select((b) => b);
                foreach (var booking in results)
                {
                    Bookings.Add(booking);
                }
                Thread.Sleep(4000);
                this.PageBusy = false;
                this.PageInputEnabled = true;

            });
            
        }
    }
}
