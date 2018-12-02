using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class HomeViewModel
    {
        Command _OpenHome;
        public Command OpenHome { get => _OpenHome ?? new Command(OnHomeClicked); set => _OpenHome = value; }
        Command _TappedBellIcon;
        public Command TappedBellIcon { get => _TappedBellIcon ?? new Command(OnTappedBellIcon); set => _TappedBellIcon = value; }
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
