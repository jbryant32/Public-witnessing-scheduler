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
    public class HomeViewModel :INotifyPropertyChanged
    {


        #region Varibales
        string _CurrentDateTime = DateTime.Today.ToString("MM/dd/yyyy");
        public string CurrentDateTime { get => _CurrentDateTime; set { OnPropertyChange(); _CurrentDateTime = value; } }
        Booking[] _PendingBookings;
        public Booking[] PendingBooks { get => _PendingBookings ?? new Booking[0]; set { OnPropertyChange(); _PendingBookings = value; } }
        #endregion
        #region Delegates
        Command _OpenHome;
        public Command OpenHome { get => _OpenHome ?? new Command(OnHomeClicked); set => _OpenHome = value; }
        public Command TappedBellIcon { get => _TappedBellIcon ?? new Command(OnTappedBellIcon); set => _TappedBellIcon = value; }
        Command _TappedBellIcon;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

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
        private void OnHomeClicked()
        {

        }
        public void OnTappedBellIcon()
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail = new NavigationPage(new PendingBookingsPage());
            Master.IsPresented = false;
        }
    }
}
