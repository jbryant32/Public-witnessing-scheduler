using PWSSchduler.Model;
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
    public partial class ProfilePage : ContentPage
    {
        private readonly ProfileViewModel _ViewModel = new ProfileViewModel();
        public ProfileViewModel ViewModel => _ViewModel;
        public ProfilePage()
        {
            InitializeComponent();

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ProfilePageItem;
            Navigation.PushModalAsync(new ProfileUserDetailsPage(item));
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await this.ViewModel.getUserInfo();
        }
    }
}