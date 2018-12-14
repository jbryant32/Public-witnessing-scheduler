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
    public partial class HomeViewTemplate : ContentView
    {
        public Command OpenAlertViewPageCommand { get => (Command)GetValue(OpenAlertViewPageCommandProperty); set => SetValue(OpenAlertViewPageCommandProperty, value); }
        public static readonly BindableProperty OpenAlertViewPageCommandProperty = BindableProperty.Create(nameof(OpenAlertViewPageCommand), typeof(Command), typeof(HomeViewTemplate), null);
        public DateTime CurrentDate { get => (DateTime)GetValue(CurrentDateProperty); set => SetValue(CurrentDateProperty, value); }
        public static readonly BindableProperty CurrentDateProperty = BindableProperty.Create(nameof(CurrentDate), typeof(DateTime), typeof(HomeViewTemplate), null);
        public int TotalAlerts { get => (int)GetValue(TotalAlertsProperty); set => SetValue(TotalAlertsProperty, value); }
        public static readonly BindableProperty TotalAlertsProperty = BindableProperty.Create(nameof(TotalAlerts), typeof(int), typeof(HomeViewTemplate), null);

        public HomeViewTemplate ()
		{
			InitializeComponent ();
		}
	}
}