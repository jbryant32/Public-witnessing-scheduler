using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class ViewModel : BindableObject
    {
        bool _PageBusy = true;
        public bool PageBusy { get => _PageBusy; set { OnPropertyChanged(); _PageBusy = value; } }
        bool _PageInputEnabled = false;
        public bool PageInputEnabled { get => _PageInputEnabled; set { OnPropertyChanged(); _PageInputEnabled = value; } }
        
    }
}
