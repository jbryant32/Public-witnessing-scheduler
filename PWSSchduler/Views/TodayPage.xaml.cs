using PWSSchduler.Model;
using PWSSchduler.ViewModels;
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
	public partial class TodayPage : ContentPage
	{
      
 
         public TodayPage ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            await this.viewModel.SimulateHttpGet();
       
            base.OnAppearing();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedItem = (e.SelectedItem as Booking);
            var List= sender as ListView;
            await Navigation.PushAsync(new BookingItemDetailPage(SelectedItem),true);
        }

       

      
    }
}