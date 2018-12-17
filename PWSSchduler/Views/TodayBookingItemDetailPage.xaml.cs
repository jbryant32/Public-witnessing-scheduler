using PWSSchduler.CustomControls;
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
	public partial class TodayBookingItemDetailPage : ContentPage
	{
        public TodayBookingItemDetailViewModel _ViewModel = new TodayBookingItemDetailViewModel();
        public TodayBookingItemDetailViewModel ViewModel { get => _ViewModel; set => _ViewModel = value; }

        public TodayBookingItemDetailPage (Booking booking)
		{

            ViewModel.booking = booking;
            InitializeComponent ();
          
        }

        public TodayBookingItemDetailPage()
        {
            	InitializeComponent ();
        }

        private void ViewGallery_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TodayImageGalleryPage());
        }
    }
}