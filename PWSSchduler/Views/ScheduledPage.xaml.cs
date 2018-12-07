﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScheduledPage : ContentPage
	{
		public ScheduledPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {

            this.ViewModel.LoadBookings();
            base.OnAppearing(); 
        }
    }
}