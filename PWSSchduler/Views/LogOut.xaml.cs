using PWSSchduler.Model;
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
    public partial class LogOut : ContentPage
    {
        public LogOut()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            LogoutUser();
            base.OnAppearing();
        }

        public async void LogoutUser()
        {
            await UserLogin.LogOutUser();
            Application.Current.MainPage = new LoginPage();

        }
    }
}