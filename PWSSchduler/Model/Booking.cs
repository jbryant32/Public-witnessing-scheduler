using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWSSchduler.Model
{
    [Table("Bookings")]
    public class Booking
    {
        [AutoIncrement, PrimaryKey, Column("id")]
        public int ID { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Booking Type")]
        public string BookingType { get; set; }
        [Column("Status")]
        public string Status { get; set; }
        [Column("Location Name")]
        public string LocationName { get; set; }
        [Column("Location Address")]
        public string LocationAddress { get; set; }
        [Column("Scheduled Date")]
        public string ScheduledDate { get; set; }
        [Column("Scheduled Start Time")]
        public string ScheduledStartTime { get; set; }
        [Column("Scheduled End Time")]
        public string ScheduledEndTime { get; set; }
       
    }
}
