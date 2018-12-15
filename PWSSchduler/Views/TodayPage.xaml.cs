using PWSSchduler.Model;
using PWSSchduler.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodayPage : ContentPage
    {
        TodayViewModel _ViewModel = new TodayViewModel();
        public TodayViewModel ViewModel { get => _ViewModel; set => _ViewModel = value; }

        public TodayPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await this.ViewModel.SimulateHttpGet();

            base.OnAppearing();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var SelectedItem = (e.Item as Booking);
            var List = sender as ListView;
            await Navigation.PushAsync(new BookingItemDetailPage(SelectedItem), true);
        }
    }
}