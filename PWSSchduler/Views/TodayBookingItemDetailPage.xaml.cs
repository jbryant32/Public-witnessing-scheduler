﻿using PWSSchduler.CustomControls;
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
	public partial class BookingItemDetailPage : ContentPage
	{
        
		public BookingItemDetailPage (Booking Context)
		{
            
            InitializeComponent ();
            this.Content.BindingContext = Context;
        }

        public BookingItemDetailPage()
        {
            	InitializeComponent ();
        }

        private void ViewGallery_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TodayImageGalleryPage());
        }
    }
}