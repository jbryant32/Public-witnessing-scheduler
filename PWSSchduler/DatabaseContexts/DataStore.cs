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
        static Booking[] BookingsStore = new Booking[] {
                new Booking() { Status="Unconfirmed", Email="jason.bryant28@gmail.com", BookingType = "Cart" , LocationAddress ="77777 El Paseo Dr Palm Desert CA 92211" , LocationName="El Paseo Shopping Plaze", ScheduledDate =DateTime.Today.ToString(),ScheduledStartTime = "08:00",ScheduledEndTime = "9:00" },
                new Booking() {Status="Confirmed", Email="jason.bryant28@gmail.com", BookingType = "Table" , LocationAddress ="53654 San Pablo  Palm Desert CA 92211" , LocationName="Park Palm Desert", ScheduledDate =DateTime.Parse("11/30/2018").ToString(),ScheduledStartTime = "08:00",ScheduledEndTime = "9:00" },
                new Booking() {Status="Unconfirmed", Email="john.doe@email.com", BookingType = "Table" , LocationAddress ="48956 HWY 111 Palm Desert CA 92211" , LocationName="Palm Desert Shopping Mall", ScheduledDate =DateTime.Parse("11/29/2018").ToString(),ScheduledStartTime = "08:00",ScheduledEndTime = "9:00" }


            };
        static Dictionary<string, User> UserStore = new Dictionary<string, User>() { { "jason.bryant28@gmail.com", new User() { Email = "jason.bryant28@gmail.com", Password = "password123" } } };
        //get stored from local storage
        public async static Task<List<Booking>> GetLocalBookings()
        {
            return await Task.Run(()=>BookingsStore.ToList());
           // return await OpenAsyncDBConnection.QueryAsync<Booking>($"SELECT * FROM [Bookings] WHERE [Email]= ?", UserLogin.CurrentLoggedInUser.ToLower());
        }
        //get stired from backend
        public async static Task<Booking[]> FetchBookings()
        {
            return await Task.Run<Booking[]>(() => BookingsStore);
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
