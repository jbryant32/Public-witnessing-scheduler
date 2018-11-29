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
	public partial class HomePage : ContentPage
	{
         
		public HomePage ()
		{
			InitializeComponent ();
          
		}

        private async void ButtonToday_Clicked(object sender, EventArgs e)
        {
            TodayPage Today = new TodayPage();
            await Navigation.PushModalAsync(Today);
        }

        private async void ButtonPendingApproval_Clicked(object sender, EventArgs e)
        {
            PendingBookingsPage pendingBookings = new PendingBookingsPage();
            await Navigation.PushModalAsync(pendingBookings);
        }

        private async void ButtonScheduled_Clicked(object sender, EventArgs e)
        {
            ScheduledPage scheduledPage = new ScheduledPage();
            await Navigation.PushModalAsync(scheduledPage);
        }

        private async void ButtonSendRequest_Clicked(object sender, EventArgs e)
        {
            SendRequestPage sendRequestPage = new SendRequestPage();
            await Navigation.PushModalAsync(sendRequestPage);
        }
    }
}