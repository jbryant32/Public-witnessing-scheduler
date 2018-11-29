using PWSSchduler.Model;
using PWSSchduler.ViewModels;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {
        
        bool _LoginEnabled = false;
        public bool LoginEnabled { get => _LoginEnabled; set { _LoginEnabled = value; base.OnPropertyChanged(); } }

        public LoginPage ()
		{
           
			InitializeComponent ();
      
		}

        private void EntryPassword_Unfocused(object sender, FocusEventArgs e)
        {
            ViewModel.EntryPassword_Unfocused(sender, e);
        }

        private void EntryEmail_Unfocused(object sender, FocusEventArgs e)
        {
            ViewModel.EntryEmail_Unfocused(sender, e);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UserLogin.CurrentLoggedInUser = this.EntryEmail.Text;
            Application.Current.MainPage = new UserDataCheckPage();
        }

       
    }
}