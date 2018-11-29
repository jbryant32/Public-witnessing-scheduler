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

    public class LoginViewModel : INotifyPropertyChanged
    {
        public bool LoginEnabled { get; set; }
        public string EntryEmail { get; set; }
        IValidation _EmailBehaviorValidator;
        public IValidation EmailBehaviorValidator { get => _EmailBehaviorValidator ?? (new EmailValidation()); set { _EmailBehaviorValidator = value; OnPropertyChanged(); } }
        IValidation _PasswordBehaviorValidator;
        public IValidation PasswordBehaviorValidator { get => _PasswordBehaviorValidator ?? (new StringEmptyOrNullValidation()); set { _PasswordBehaviorValidator = value; OnPropertyChanged(); } }
        public Action OnFocus { get; set; }

        Command _Login_Button_Clicked;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public Command OnLoginButtonClicked => _Login_Button_Clicked ?? (_Login_Button_Clicked = new Command(Login_Button_Clicked));

      
        public LoginViewModel()
        {

        }

        public void EntryPassword_Unfocused(object sender, FocusEventArgs e)
        {
            if (this.EmailBehaviorValidator.IsValid == true && this.PasswordBehaviorValidator.IsValid == true)
            {
                this.LoginEnabled = true;
            }
            else
                this.LoginEnabled = false;
        }

        public void EntryEmail_Unfocused(object sender, FocusEventArgs e)
        {
            if (this.EmailBehaviorValidator.IsValid == true && this.PasswordBehaviorValidator.IsValid == true)
            {
                this.LoginEnabled = true;
            }
            else
                this.LoginEnabled = false;

        }
        private void Login_Button_Clicked()
        {
            UserLogin.CurrentLoggedInUser = this.EntryEmail;
            Application.Current.MainPage = new UserDataCheckPage();
        }

    }
}
