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

       

       
    }
}