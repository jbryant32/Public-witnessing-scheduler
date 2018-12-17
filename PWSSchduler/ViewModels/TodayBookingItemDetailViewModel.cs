using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class TodayBookingItemDetailViewModel:ModelBase
    {
        public ICommand _OpenMapDetailCommand;
        public ICommand OpenMapDetailCommand { get => _OpenMapDetailCommand ?? new Command(OpenMapPage) ; set { _OpenMapDetailCommand = value; } }
        public Booking _booking;
        public Booking booking { get => _booking; set { OnPropertyChanging(); _booking = value; OnPropertyChanged(); } }
        public TodayBookingItemDetailViewModel()
        {
                
        }

        private async void OpenMapPage() {
            await Application.Current.MainPage.Navigation.PushModalAsync(new MapsPage(booking));
        }
    }
}
