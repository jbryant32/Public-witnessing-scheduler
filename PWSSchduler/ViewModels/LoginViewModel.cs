using FormValidation.Validators;
using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{

    public class LoginViewModel : ModelBase
    {

        public LoginViewModel()
        {

        }


        public bool LoginMeIn(string Email, string Password)
        {
            //TODO Check if log creds valid           
            Application.Current.MainPage = new UserDataCheckPage(Email,Password);
            return true;
        }

    }
}
