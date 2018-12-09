using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        public HomePage()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {
            await this.ViewModel.InitViewModel();
            base.OnAppearing();
        }
        private void ButtonToday_Clicked(object sender, EventArgs e)
        {
            
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail = new NavigationPage(new TodayPage());
            Master.IsPresented = false;

        }

        private   void ButtonPendingApproval_Clicked(object sender, EventArgs e)
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail = new NavigationPage(new PendingBookingsPage());
            Master.IsPresented = false;
        }

        private   void ButtonScheduled_Clicked(object sender, EventArgs e)
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail = new NavigationPage(new ScheduledPage());
            Master.IsPresented = false;
        }

        private   void ButtonSendRequest_Clicked(object sender, EventArgs e)
        {
            var Master = Application.Current.MainPage as MainPage;
            Master.Detail = new NavigationPage(new SendRequestPage());
            Master.IsPresented = false;
        }
    }
}