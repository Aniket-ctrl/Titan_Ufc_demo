using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Data_Access
{
    public class UserDataAccess:IUserDataAccess
    {
        private int _UserId;

        private Applicationdb_context _context { get; set; }
        public UserDataAccess(Applicationdb_context context)
        {

            _context = context;
        }

       

        public async Task<bool> CreateUser(Users user)
        {
            await _context.UserEntity.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public  Users GetUser(int UserId)
        {
            return _context.UserEntity.FirstOrDefault(_ => _.UserId == UserId);
        }


        public async Task<bool> UpdateUser(Users user)
        {
            _context.UserEntity.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveUser(Users user)
        {
            _context.UserEntity.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }




    }
}
