using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataAccessLayer.Context;
using PWSSchduler.ViewModels;

namespace PWSSchduler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDataCheckPage : ContentPage
    {
        UserDataCheckViewModel _ViewModel = new UserDataCheckViewModel();
        public UserDataCheckViewModel ViewModel => _ViewModel;
        public UserDataCheckPage()
        {
            InitializeComponent();
        }
        public UserDataCheckPage(string Email, string Password)
        {
            this.ViewModel.SetUserEmailPassword(Email, Password);
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            Application.Current.MainPage = new MainPage();
            await this.ViewModel.SetUserLocalStorageData();
            base.OnAppearing();
        }

    }
}