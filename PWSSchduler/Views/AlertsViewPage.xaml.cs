using PWSSchduler.Model;
using PWSSchduler.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertsViewPage : ContentPage
	{
        private AlertViewModel _ViewModel;
        public AlertViewModel ViewModel { get => _ViewModel ?? new AlertViewModel(); set { _ViewModel = value; } }
       

        public AlertsViewPage ()
		{
            
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            await this.ViewModel.Init();
            base.OnAppearing();
        }

    }
}