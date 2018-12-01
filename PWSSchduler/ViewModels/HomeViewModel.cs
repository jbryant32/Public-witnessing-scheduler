using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class HomeViewModel
    {
        Command _OpenHome;
        public Command OpenHome { get => _OpenHome ?? new Command(OnHomeClicked); set => _OpenHome = value; }

        private void OnHomeClicked() {

        }
    }
}
