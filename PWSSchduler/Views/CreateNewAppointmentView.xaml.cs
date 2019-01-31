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
    public partial class CreateNewAppointmentView : ContentPage
    {
        CreateNewAppointmentViewModel _viewModel = new CreateNewAppointmentViewModel();
        public CreateNewAppointmentViewModel ViewModel { get => _viewModel; set => _viewModel = value; }
        public CreateNewAppointmentView()
        {
            InitializeComponent();
        }
    }
}