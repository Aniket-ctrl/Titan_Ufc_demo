using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Data_Access;

using titan_ufc_demo.Models;
namespace titan_ufc_demo.Service
{
    public class UserService:IUserService
    {
       

        private IUserDataAccess _userDataAccess { get; set; }

        public UserService(IUserDataAccess _userDataAccess) {
            this._userDataAccess = _userDataAccess;
        }

        public async Task<bool> CreateUser(Users user)
        {

            return await _userDataAccess.CreateUser(user);
        }

        public Users GetUser(int UserId)
        {
            return _userDataAccess.GetUser(UserId);
        }

        public async Task<bool> UpdateUser(Users user)
        {
            return await _userDataAccess.UpdateUser(user);
            
        }

        public async Task<bool> RemoveUser(Users user)
        {
            return await _userDataAccess.RemoveUser(user);
        }


    }

    
}
