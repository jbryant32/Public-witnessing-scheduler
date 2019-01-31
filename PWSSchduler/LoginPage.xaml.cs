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
        LoginViewModel ViewModel { get; set; } = new LoginViewModel();

        public LoginPage ()
		{
           
			InitializeComponent ();
      
		}

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            if(EmailEntry.isEntryValid && PasswordEntry.isEntryValid)
            {
                ViewModel.LoginMeIn(EmailEntry.EntryValue, PasswordEntry.EntryValue);
            }
        }
    }
}