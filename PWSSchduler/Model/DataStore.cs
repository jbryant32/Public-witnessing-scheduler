using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PWSSchduler.Model
{
    public class DataStore
    {
        public async static Task<Booking[]> GetBookings()
        {
            return await Task.Run<Booking[]>( ()=> new Booking[] {
                new Booking() { Email="jane.doe@email.com", BookingType = "Cart" , LocationAddress ="77777 El Paseo Dr Palm Desert CA 92211" , LocationName="El Paseo Shopping Plaze", ScheduledDate ="11/28/2018",ScheduledStartTime = "08:00",ScheduledEndTime = "9:00" },
                new Booking() { Email="jane.doe@email.com", BookingType = "Cart" , LocationAddress ="53654 San Pablo  Palm Desert CA 92211" , LocationName="Park Palm Desert", ScheduledDate ="11/28/2018",ScheduledStartTime = "08:00",ScheduledEndTime = "9:00" },
                new Booking() { Email="john.doe@email.com", BookingType = "Table" , LocationAddress ="48956 HWY 111 Palm Desert CA 92211" , LocationName="Palm Desert Shopping Mall", ScheduledDate ="11/29/2018",ScheduledStartTime = "08:00",ScheduledEndTime = "9:00" }


            });
        }
    }
}
