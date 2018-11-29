using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class SendRequestViewModel
    {
        public string UsersName { get; set; }
         public string Email { get; set; }
        public string KingdomHall { get; set; }

        public TimeSpan RequestedTime { get; set; }
        public DateTime MinimumDate => DateTime.Today;
        DateTime _DayMonth;
        public DateTime DayMonth { get; set; }
        public string Notes { get; set; }
        Command SendRequest ;
        public Command SendRequestCommand { get { return (SendRequest ?? (SendRequest = new Command(ExecuteSend))); } }

        public SendRequestViewModel()
        {
            UsersName = "Jason Bryant";
            KingdomHall = "Panorama Kingdom Hall";
            Email = "Jason.bryant28@gmail.com";
        }

        public void ExecuteSend() {

            var Value = new RequestBookingData(DayMonth, RequestedTime, Notes);

        }
    }
    public struct RequestBookingData {
        public DateTime DayMonth { get; set; }
        public TimeSpan RequestedTime { get; set; }
        public string Notes { get; set; }
        public RequestBookingData(DateTime DayMonth, TimeSpan RquestedTime,string Notes)
        {
            this.DayMonth = DayMonth;
            this.RequestedTime = RquestedTime;
            this.Notes = Notes;
        }
    }
         
}
