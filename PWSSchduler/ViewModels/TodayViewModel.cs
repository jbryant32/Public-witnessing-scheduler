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
    public class TodayViewModel:INotifyPropertyChanged
    {
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get { return _Bookings; } set { _Bookings = value;  } }
        bool Fetch = false;
        public bool FetchComplete { get { return Fetch; } set { Fetch = value; OnPropertyChanged(); } }
        bool Show = true;
        public bool ShowBusyIndicator { get { return Show; } set { Show = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

         public TodayViewModel()
        {
            
        }

        public async Task<Booking[]> LoadBookings()
        {
            throw new NotImplementedException();
        }
        public async Task SimulateHttpGet()
        {
            await Task.Run(() => Thread.Sleep(2000));
          
            foreach (var booking in await DataStore.FetchBookings())
            {
                if(DateTime.Today.ToString() == booking.ScheduledDate)
                Bookings.Add(booking);
            }
            this.ShowBusyIndicator = false;
            this.FetchComplete = true;
        }
    }
}
