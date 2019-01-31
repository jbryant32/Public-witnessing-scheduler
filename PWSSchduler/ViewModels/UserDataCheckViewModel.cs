using DataAccessLayer.Context;
using DataAccessLayer.RelationalDBOs;
using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PWSSchduler.ViewModels
{
    public class UserDataCheckViewModel : ModelBase
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserDataCheckViewModel()
        {

        }

        public async Task SetUserLocalStorageData()
        {
            //TODO add switch if no internet get local storage instead of http
            var UsersSecurityInfo = await DataAccessLayer.HTTP.UserHttpContext.Instance.GetUserSecurityInfo(Email);
            var UsersAppInfo = await DataAccessLayer.HTTP.UserHttpContext.Instance.GetUsersAppInfo(Email);
            using (var Context = UserDatabaseHelper<UserDataContext>.Instance.CreateContext())
            {
                var User = new UsersInfoDBO()
                {
                    Kingdomhall = UsersAppInfo.Kingdomhall,
                    Email = UsersAppInfo.Email,
                    FirstName = UsersAppInfo.FirstName,
                    LastName = UsersAppInfo.LastName,
                    Zip = UsersAppInfo.Zip,
                    City = UsersAppInfo.City,
                    Street = UsersAppInfo.Street,
                    State = UsersAppInfo.State

                };
                await Context.AddUser(User);
                await Context.CommitChanges();
            };

        }

        public void SetUserEmailPassword(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}
