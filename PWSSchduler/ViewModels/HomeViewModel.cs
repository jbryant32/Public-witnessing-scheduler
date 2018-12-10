using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class HomeViewModel :BindableObject
    {


        #region Varibales
        string _CurrentDateTime = DateTime.Today.ToString("MM/dd/yyyy");
        public string CurrentDateTime { get => _CurrentDateTime; set { OnPropertyChanged(); _CurrentDateTime = value; } }
        Booking[] _PendingBookings;
        public Booking[] PendingBooks { get => _PendingBookings ?? new Booking[0]; set { OnPropertyChanged(); _PendingBookings = value; } }
        #endregion
        #region Delegates
        Command _CommandOpenToday;
        public Command CommandOpenToday { get => _CommandOpenToday ?? new Command(OnTodayButtonClicked); set => _CommandOpenToday = value; }
        Command _CommandOpenPending;
        public Command CommandOpenPending { get => _CommandOpenPending ?? new Command(OnPendingButtonClicked); set => _CommandOpenPending = value; }
        Command _CommandOpenScheduled;
        public Command CommandOpenScheduled { get => _CommandOpenScheduled ?? new Command(OnScheduledButtonClicked); set => _CommandOpenScheduled = value; }
        Command _CommandOpenSendRequest;
        public Command CommandOpenSendRequest { get => _CommandOpenSendRequest ?? new Command(OnSendingButtonClicked); set => _CommandOpenSendRequest = value; }
        public Command CommandTappedBell { get => _CommandTappedBell ?? new Command(OnTappedBellIcon); set => _CommandTappedBell = value; }
        Command _CommandTappedBell;
        #endregion
        public HomeViewModel()
        {

        }

        public async Task InitViewModel() {
          new Thread(()=> StartClock());
            await LoadPendingBookings();
        }
        public async Task LoadPendingBookings() {
            await Task.Run(async () => {
                var Local = (await DataStore.GetLocalBookings());
                if (Local != null) {
                    PendingBooks = Local.Where((b) => b.Status == "Unconfirmed").ToArray();
                }
            });
        }
        public   void StartClock()
        {
            while (true)
            {
                Thread.Sleep(3600000);
            CurrentDateTime = DateTime.Today.ToString("MM/dd/yyyy");
            }
           
        }
        private void OnTodayButtonClicked()
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail.Navigation.PushAsync(new TodayPage());
            Master.IsPresented = false;
        }
        private void OnPendingButtonClicked()
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail.Navigation.PushAsync(new PendingBookingsPage());
            Master.IsPresented = false;
        }
        private void OnScheduledButtonClicked()
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail.Navigation.PushAsync(new ScheduledPage());
            Master.IsPresented = false;
        }
        private void OnSendingButtonClicked()
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail.Navigation.PushAsync(new SendRequestPage());
            Master.IsPresented = false;
        }
        public void OnTappedBellIcon()
        {
            var Main = Application.Current.MainPage as MainPage;
            Main.Navigation.PushModalAsync(new AlertsViewPage());
        }
    }
}
