using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryAuthView : ContentView
	{
        public string invalidMessage { get=>(string)GetValue(invalidMessageProperty); set=>SetValue(invalidMessageProperty,value); }
        static readonly BindableProperty invalidMessageProperty = BindableProperty.Create(nameof(invalidMessage), typeof(string), typeof(EntryAuthView), null);
        public bool isEntryPassword { get=>(bool)GetValue(isEntryPasswordProperty); set=>SetValue(isEntryPasswordProperty,value); }
        static readonly BindableProperty isEntryPasswordProperty = BindableProperty.Create(nameof(isEntryPassword), typeof(bool), typeof(EntryAuthView), false);

        public bool isEmail { get=>(bool)GetValue(isEmailProperty); set=>SetValue(isEmailProperty,value); }
        static readonly BindableProperty isEmailProperty = BindableProperty.Create(nameof(isEmail), typeof(bool), typeof(EntryAuthView), null);
        public string EntryValue { get=>(string)GetValue(EntryValueProperty); set=>SetValue(EntryValueProperty,value); }
        static readonly BindableProperty EntryValueProperty = BindableProperty.Create(nameof(EntryValue), typeof(string), typeof(EntryAuthView), string.Empty);
        bool _isEntryValid=false;
        public bool isEntryValid { get=>_isEntryValid; set{ OnPropertyChanging();_isEntryValid = value; OnPropertyChanged(); } }
        public string currentText { get; private set; }
        bool _isErrorVisible=true;
        public bool isErrorVisible { get=>_isErrorVisible; set { OnPropertyChanging(); _isErrorVisible=value; OnPropertyChanged(); } }
        string _PlaceHolder;
        public string PlaceHolder { get=>_PlaceHolder; set { OnPropertyChanging(); _PlaceHolder = value; OnPropertyChanged(); } }
        public EntryAuthView ()
		{
           
			InitializeComponent ();
            if (isEntryPassword)
                PlaceHolder = "PASSWORD";
            if (isEmail)
                PlaceHolder = "EMAIL";
		}
        
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            currentText = e.NewTextValue;
            EntryValue = currentText;
            if (isEntryPassword)
            {
                isEntryValid = CheckPasswordValid(currentText);
            }
            if (isEmail)
            {
                isEntryValid = CheckEmailValid(currentText);
            }
            ToggleVisibilityOnError();

        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            EntryValue = currentText;
            if (isEntryPassword) {
                isEntryValid = CheckPasswordValid(currentText);
            }
            if (isEmail)
            {
                isEntryValid = CheckEmailValid(currentText);
            }
            ToggleVisibilityOnError();
        }
        private bool CheckPasswordValid(string Password)
        {
            if (!String.IsNullOrEmpty(Password))
                return true;
            else
                return false;
        }

        private bool CheckEmailValid(string Email) {
            if (String.IsNullOrEmpty(Email))
                return false;
            try
            {
                return Regex.IsMatch(Email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        public void ToggleVisibilityOnError() {
            isErrorVisible = !isEntryValid;
        }
    }
}