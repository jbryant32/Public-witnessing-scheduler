using PWSSchduler.Model;
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
    public partial class PendingBookingsPage : ContentPage
    {
        public PendingBookingsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ViewModel.GetLocalBookings();
            base.OnAppearing();
        }
        private async  void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           await Navigation.PushAsync( new PendingBookingsDetailPage((e.Item as Booking)),true);
        }
    }
}