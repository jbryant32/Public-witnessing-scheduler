using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PWSSchduler.Model
{
    public class UserLogin
    {
        
        public static string CurrentLoggedInUser { get; set; }
        public async static Task<bool> ValidateUser(User user) {
            var u = await DataStore.FetchUser(user.Email);
            if (user.Password == u.Password)
            {
                return true;
            }
            else
                return false;
        }
        public async static Task LogOutUser() {
            await Task.Run(() => Thread.Sleep(2000));
        }
    }

}
