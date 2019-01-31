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
    public partial class AppoinmentManagerView : ContentPage
    {
        private CreateNewAppointmentView _CachedView = new CreateNewAppointmentView();
        CreateNewAppointmentView CahcedAppointmenmtView { get => _CachedView; set => _CachedView = value; }
        Command _OpenCreateAppointmentView;
        public Command OpenCreateAppointmentView
        {
            get => _OpenCreateAppointmentView ?? (_OpenCreateAppointmentView = new Command(OnCreateNewAppointment));
            set => _OpenCreateAppointmentView = value;
        }
        public AppoinmentManagerView()
        {
            InitializeComponent();
        }
        public void OnCreateNewAppointment()
        {
            Navigation.PushAsync(_CachedView);
        }

    }
}