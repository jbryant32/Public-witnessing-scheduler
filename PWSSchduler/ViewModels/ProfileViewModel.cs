using DataAccessLayer.Context;
using DataAccessLayer.RelationalDBOs;
using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PWSSchduler.ViewModels
{
    public class ProfileViewModel:ModelBase
    {
        UsersInfoDBO _UsersLocalInfo = new UsersInfoDBO();
        public UsersInfoDBO UsersLocalInfo { get => _UsersLocalInfo; set {_UsersLocalInfo = value; OnPropertyChanged(); } }
        public ProfileViewModel()
        {

        }

        public async Task<UsersInfoDBO> getUserInfo() {

            using (var Context = UserDatabaseHelper<UserDataContext>.Instance.CreateContext()) {
                var Results = await Context.GetUser();
                this.UsersLocalInfo = Results;
                return Results;
            }
        }
        
    }
}
