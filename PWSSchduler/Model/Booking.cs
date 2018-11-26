using System;
using System.Collections.Generic;
using System.Text;

namespace PWSSchduler.Model
{
    public class Booking
    {
        public string Email{ get; set; }
        public string BookingType { get; set; }
        public string Table { get; set; }
        public string Status{ get; set; }
        public string LocationName{ get; set; }
        public string LocationAddress { get; set; }
        public string ScheduledDate { get; set; }
        public string ScheduledStartTime   { get; set; }
        public string ScheduledEndTime { get; set; }
    }
}
