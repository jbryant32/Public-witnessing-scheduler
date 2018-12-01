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
        public string ScheduledTime { get => (string)GetValue(ScheduledTimeProperty); set => SetValue(ScheduledTimeProperty, value); }
        public static readonly BindableProperty ScheduledTimeProperty = BindableProperty.Create(nameof(ScheduledTime), typeof(string), typeof(BookingView), "");
        public string Location { get => (string)GetValue(LocationProperty); set => SetValue(LocationProperty, value); }
        public static readonly BindableProperty LocationProperty = BindableProperty.Create(nameof(Location), typeof(string), typeof(BookingView), "");
        public BookingView()
        {
			InitializeComponent ();
            this.BindingContext = this;
		}
	}
}