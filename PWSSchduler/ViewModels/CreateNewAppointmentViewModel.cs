using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PWSSchduler.ViewModels
{
    public class CreateNewAppointmentViewModel : ModelBase
    {
        ObservableCollection<string> _Locations = new ObservableCollection<string>();
        public ObservableCollection<string> Locations { get => _Locations; set { _Locations = value; } }

        public CreateNewAppointmentViewModel()
        {
            Locations.Add("IM A LOCATION");
            Locations.Add("IM A LOCATION");
            Locations.Add("IM A LOCATION");
            Locations.Add("IM A LOCATION");
            Locations.Add("IM A LOCATION");
            Locations.Add("IM A LOCATION");
            Locations.Add("IM A LOCATION");

        }
        public  string[] GetLocations(string forLocation)
        {
             
            return new string[] { " " };

        }
    }
}
