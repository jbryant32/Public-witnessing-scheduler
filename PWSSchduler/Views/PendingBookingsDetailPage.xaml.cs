using PWSSchduler.Model;
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
	public partial class PendingBookingsDetailPage : ContentPage
	{
		public PendingBookingsDetailPage (Booking booking)
		{
			InitializeComponent ();
            this.Content.BindingContext = booking;
		}
        public PendingBookingsDetailPage()
        {

        }
	}
}