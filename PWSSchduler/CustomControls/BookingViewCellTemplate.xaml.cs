using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookingView : ContentView
	{
        public string Email { get => (string)GetValue(EmailProperty); set => SetValue(EmailProperty, value); }
        public static readonly BindableProperty EmailProperty = BindableProperty.Create(nameof(Email), typeof(string), typeof(BookingView), "");
        public string ScheduledStartTime { get => (string)GetValue(ScheduledStartTimeProperty); set => SetValue(ScheduledStartTimeProperty, value); }
        public static readonly BindableProperty ScheduledStartTimeProperty = BindableProperty.Create(nameof(ScheduledStartTime), typeof(string), typeof(BookingView), "");
        public string LocationName { get => (string)GetValue(LocationNameProperty); set => SetValue(LocationNameProperty, value); }
        public static readonly BindableProperty LocationNameProperty = BindableProperty.Create(nameof(LocationName), typeof(string), typeof(BookingView), "");

        public BookingView()
        {
			InitializeComponent ();
            
		}
	}
}