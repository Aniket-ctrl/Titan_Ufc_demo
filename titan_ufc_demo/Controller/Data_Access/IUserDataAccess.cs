using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Data_Access
{
    public interface IUserDataAccess
    {
        Task<bool> CreateUser(Users user);
        Users GetUser(int UserId);

        

        Task<bool> UpdateUser(Users user);

        Task<bool> RemoveUser(Users user);
        
    }
}
