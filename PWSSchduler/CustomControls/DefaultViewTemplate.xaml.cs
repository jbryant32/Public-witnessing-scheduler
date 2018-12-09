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
	public partial class DefaultViewTemplate : ContentView
	{
        #region Activity Indicator Bindings
        public string ActivityMessage { get => (string)GetValue(ActivityMessageProperty); set => SetValue(ActivityMessageProperty, value); }
        public static readonly BindableProperty ActivityMessageProperty = BindableProperty.Create(nameof(ActivityMessage), typeof(string), typeof(BookingDetailView), "");
        public bool PageIsBusy { get => (bool)GetValue(PageIsBusyProperty); set => SetValue(PageIsBusyProperty, value); }
        public static readonly BindableProperty PageIsBusyProperty = BindableProperty.Create(nameof(PageIsBusy), typeof(bool), typeof(BookingDetailView), false);
        public bool IndicatorRunning { get => (bool)GetValue(IndicatorRunningProperty); set => SetValue(IndicatorRunningProperty, value); }
        public static readonly BindableProperty IndicatorRunningProperty = BindableProperty.Create(nameof(IndicatorRunning), typeof(bool), typeof(BookingDetailView), false);
        public bool PageInputEnabled { get => (bool)GetValue(PageInputEnabledProperty); set => SetValue(PageInputEnabledProperty, value); }
        public static readonly BindableProperty PageInputEnabledProperty = BindableProperty.Create(nameof(PageInputEnabled), typeof(bool), typeof(BookingDetailView), false);
        #endregion
        public DefaultViewTemplate ()
		{
			InitializeComponent ();
		}

        
    }
}