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
    public partial class BookingDetailView : ContentView
    {

        #region Booking Detail Bindings
        public string Email { get => (string)GetValue(EmailProperty); set => SetValue(EmailProperty, value); }
        public static readonly BindableProperty EmailProperty = BindableProperty.Create(nameof(Email), typeof(string), typeof(BookingDetailView), "None");
        public string BookingType { get => (string)GetValue(BookingTypeProperty); set => SetValue(BookingTypeProperty, value); }
        public static readonly BindableProperty BookingTypeProperty = BindableProperty.Create(nameof(BookingType), typeof(string), typeof(BookingDetailView), "");
        public string Status { get => (string)GetValue(StatusProperty); set => SetValue(StatusProperty, value); }
        public static readonly BindableProperty StatusProperty = BindableProperty.Create(nameof(Status), typeof(string), typeof(BookingDetailView), "");
        public string LocationName { get => (string)GetValue(LocationNameProperty); set => SetValue(LocationNameProperty, value); }
        public static readonly BindableProperty LocationNameProperty = BindableProperty.Create(nameof(LocationName), typeof(string), typeof(BookingDetailView), "");
        public string LocationAddress { get => (string)GetValue(LocationAddressProperty); set => SetValue(LocationAddressProperty, value); }
        public static readonly BindableProperty LocationAddressProperty = BindableProperty.Create(nameof(LocationAddress), typeof(string), typeof(BookingDetailView), "");
        public string ScheduledDate { get => (string)GetValue(ScheduledDateProperty); set => SetValue(ScheduledDateProperty, value); }
        public static readonly BindableProperty ScheduledDateProperty = BindableProperty.Create(nameof(ScheduledDate), typeof(string), typeof(BookingDetailView), "");
        public string ScheduledStartTime { get => (string)GetValue(ScheduledStartTimeProperty); set => SetValue(ScheduledStartTimeProperty, value); }
        public static readonly BindableProperty ScheduledStartTimeProperty = BindableProperty.Create(nameof(ScheduledStartTime), typeof(string), typeof(BookingDetailView), "");
        public string ScheduledEndTime { get => (string)GetValue(ScheduledEndTimeProperty); set => SetValue(ScheduledEndTimeProperty, value); }
        public static readonly BindableProperty ScheduledEndTimeProperty = BindableProperty.Create(nameof(ScheduledStartTime), typeof(string), typeof(BookingDetailView), "");
        public string Notes{ get => (string)GetValue(NotesProperty); set => SetValue(NotesProperty, value); }
        public static readonly BindableProperty NotesProperty = BindableProperty.Create(nameof(Notes), typeof(string), typeof(BookingDetailView), "");
        #endregion

        #region Activity Indicator Bindings
        public string ActivityMessage { get=>(string)GetValue(ActivityMessageProperty); set =>SetValue(ActivityMessageProperty,value); }
        public static readonly BindableProperty ActivityMessageProperty = BindableProperty.Create(nameof(ActivityMessage), typeof(string), typeof(BookingDetailView), "");
        public bool PageIsBusy { get=>(bool)GetValue(PageIsBusyProperty); set=>SetValue(PageIsBusyProperty,value); }
        public static readonly BindableProperty PageIsBusyProperty = BindableProperty.Create(nameof(PageIsBusy), typeof(bool), typeof(BookingDetailView), false);
        public bool IndicatorRunning { get => (bool)GetValue(IndicatorRunningProperty); set => SetValue(IndicatorRunningProperty, value); }
        public static readonly BindableProperty IndicatorRunningProperty = BindableProperty.Create(nameof(IndicatorRunning), typeof(bool), typeof(BookingDetailView), false);
        #endregion


        public BookingDetailView()
        {
          
            InitializeComponent();
          
        }
    }
}