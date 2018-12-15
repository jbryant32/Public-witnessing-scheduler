using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class HomeViewModel : ModelBase
    {


        #region Varibales
        DateTime _CurrentDateTime = DateTime.Today;
        public DateTime CurrentDateTime { get => _CurrentDateTime; set { OnPropertyChanged(); _CurrentDateTime = value; } }
        ObservableCollection<Alert> _Alerts = new ObservableCollection<Alert>();
        public ObservableCollection<Alert> Alerts { get => _Alerts; set { OnPropertyChanging(); _Alerts = value; OnPropertyChanged(); } }
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
        public Command CommandTappedBell
        { get => _CommandTappedBell ?? new Command(OnTappedBellIcon); set => _CommandTappedBell = value; }
        Command _CommandTappedBell;
        #endregion

        public HomeViewModel()
        {

        }
        public async override Task Init()
        {
            
            var Results = await DataStore.GetAlerts();
            foreach (var alert in Results)
            {
                Alerts.Add(alert);

            }
            await base.Init();
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
