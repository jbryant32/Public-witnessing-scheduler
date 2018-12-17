using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class TodayViewModel:ModelBase
    {
        ObservableCollection<Booking> _Bookings = new ObservableCollection<Booking>();
        public ObservableCollection<Booking> Bookings { get { return _Bookings; } set { OnPropertyChanging(); _Bookings = value; OnPropertyChanged();  } }
        public ICommand _OpenBookingDetailCommand = new Command(() => { });
        public ICommand OpenBookingDetailCommand { get => OpenBookingDetailCommand; set { OpenBookingDetailCommand = value; } }
 

        public TodayViewModel()
        {
           
            if (Bookings.Count > 0) {
                Bookings.Clear();
            }
        }
        public async void OnOpenBookingDetail(object booking) {
            var _booking = (Booking)booking;
            await Application.Current.MainPage.Navigation.PushAsync(new TodayBookingItemDetailPage(_booking), true);
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
       
            isActive = false;
           
        }
    }
}
