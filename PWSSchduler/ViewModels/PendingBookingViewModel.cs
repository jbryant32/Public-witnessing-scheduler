using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWSSchduler.ViewModels
{
    public class PendingBookingViewModel
    {
        Booking[] _Bookings;
        Booking[] Bookings { get { return (_Bookings ?? new Booking[0]); } set { _Bookings = value; } }
        public PendingBookingViewModel()
        {
                
        }
        public async void GetBookings() {

        }

    }
}
