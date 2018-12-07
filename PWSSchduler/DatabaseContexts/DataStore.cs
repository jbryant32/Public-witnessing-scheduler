using PWSSchduler.FileIO;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWSSchduler.Model
{
    public class DataStore
    {
        static SQLiteAsyncConnection OpenAsyncDBConnection { get; set; }
        static string[] MockNotes = new[] {
            "This is to let you know that if there are any scheduling issues the onsite contacts name is Jeffery Ross in the administration office also the table is stored in the back of the Kingdom Hall in the storage closet",
            "If there are any issues contact me at this number (555)555-5555 , when done please place the cart into the back left storage closet of the kingdom hall"
        };
        static List<Booking>BookingsStore = new List<Booking>() {
                new Booking() { Status="Confirmed", Email="jane.doe@email.com", BookingType = "Cart" , LocationAddress ="77777 El Paseo Dr Palm Desert CA 92211" , LocationName="El Paseo Shopping Plaze", ScheduledDate =DateTime.Today.ToString(),ScheduledStartTime = "08:00am",ScheduledEndTime = "9:00am",Notes= MockNotes[0] },
                new Booking() {Status="Unconfirmed", Email="jane.doe@email.com", BookingType = "Table" , LocationAddress ="53654 San Pablo  Palm Desert CA 92211" , LocationName="Park Palm Desert", ScheduledDate =DateTime.Parse("01/15/2019").ToString(),ScheduledStartTime = "10:00am",ScheduledEndTime = "9:00am",Notes= MockNotes[1] },
                new Booking() {Status="Unconfirmed", Email="jane.doe@email.com", BookingType = "Cart" , LocationAddress ="53654 San Pablo  Palm Desert CA 92211" , LocationName="Park Palm Desert", ScheduledDate =DateTime.Parse("02/14/2019").ToString(),ScheduledStartTime = "08:00am",ScheduledEndTime = "9:00am",Notes= MockNotes[1] },
                new Booking() {Status="Unconfirmed", Email="john.doe@email.com", BookingType = "Table" , LocationAddress ="48956 HWY 111 Palm Desert CA 92211" , LocationName="Palm Desert Shopping Mall", ScheduledDate =DateTime.Parse("11/29/2018").ToString(),ScheduledStartTime = "08:00am",ScheduledEndTime = "9:00am",Notes="" }


            };
        static Dictionary<string, Location> LocationStore = new Dictionary<string, Location>();
        static Dictionary<string, User> UserStore = new Dictionary<string, User>() { { "jason.bryant28@gmail.com", new User() { Email = "jason.bryant28@gmail.com", Password = "password123" } } };
        //get stored from local storage
        public async static Task<List<Booking>> GetLocalBookings()
        {
            return await Task.Run(() => BookingsStore);
            // return await OpenAsyncDBConnection.QueryAsync<Booking>($"SELECT * FROM [Bookings] WHERE [Email]= ?", UserLogin.CurrentLoggedInUser.ToLower());
        }
        public async static Task UpdateLocal(List<Booking> Bookings) {
            await Task.Run(()=>BookingsStore = Bookings);
        }
        //get stired from backend
        public async static Task<List<Booking>> FetchBookings()
        {
            return await Task.Run<List<Booking>>(() => BookingsStore);
        }
        public async static Task<User> FetchUser(string email)
        {
            return await Task.Run<User>(() => UserStore[email]);
        }
        public static void OpenDBConnection()
        {
            OpenAsyncDBConnection = new SQLiteAsyncConnection(FolderPaths.DataBasePath);
        }
        public static bool CheckTablesExist()
        {
            return File.Exists(FolderPaths.DataBasePath);
        }
        //Creates the database if needed
        public async static Task CreateLocalStore()
        {
            try
            {
                var UserTable = await OpenAsyncDBConnection.Table<User>().ToListAsync();
            }
            catch (Exception)
            {

                await OpenAsyncDBConnection.CreateTableAsync<User>();
            }
            try
            {
                var BookingTable = await OpenAsyncDBConnection.Table<Booking>().ToListAsync();
            }
            catch (Exception)
            {
                await OpenAsyncDBConnection.CreateTableAsync<Booking>();
            }

        }
        public async static Task SetUsersData()
        {
            var Bookings = await GetLocalBookings();
            var BookingResults = await OpenAsyncDBConnection.QueryAsync<Booking>("SELECT * FROM [Bookings] WHERE [Email]= ?", UserLogin.CurrentLoggedInUser.ToLower());
            await OpenAsyncDBConnection.DeleteAllAsync(new TableMapping(typeof(Booking)));
            foreach (var booking in Bookings)
            {
                await OpenAsyncDBConnection.ExecuteAsync($"INSERT INTO [Bookings]([Email],[Booking Type],[Status],[Location Name],[Location Address], [Scheduled Date],[Scheduled Start Time],[Scheduled End Time]) VALUES('{booking.Email}','{booking.BookingType}','{booking.Status}','{booking.LocationName}','{booking.LocationAddress}','{booking.ScheduledDate}','{booking.ScheduledStartTime}','{booking.ScheduledEndTime}')");
            }
        }

    }
}
