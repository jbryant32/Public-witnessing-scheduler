using PWSSchduler.ViewModels;
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
        HomeViewModel _ViewModel = new HomeViewModel();
        public HomeViewModel ViewModel { get=>_ViewModel; set=>_ViewModel=value; }
        public HomePage()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {
            await this.ViewModel.Init();
            base.OnAppearing();
        }
        public async void onOpenCreatNewAppointment()
        {
            await Navigation.PushAsync(new AppoinmentManagerView());
        }
    }
}