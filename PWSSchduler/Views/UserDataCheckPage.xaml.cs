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
	public partial class UserDataCheckPage : ContentPage
	{
		public UserDataCheckPage ()
		{
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            //DataStore.OpenDBConnection();
            //await DataStore.CreateLocalStore();
            //await DataStore.SetUsersData();
            //await DataStore.GetLocalBookings();
            await Task.Run(() => { Thread.Sleep(1000); });
            Application.Current.MainPage =  new MainPage();

            base.OnAppearing();
        }
    
    }
}