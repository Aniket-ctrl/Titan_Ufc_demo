using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Data_Access;
using titan_ufc_demo.Models;



namespace titan_ufc_demo.DataAccess
{
    public class DeviceDataAccess : IDeviceDataAccess
    {
        private Applicationdb_context _context { get; set; }
        public int LocationId { get; private set; }



        public DeviceDataAccess(Applicationdb_context context)
        {
            _context = context;
        }



        public async Task<bool> CreateDevice(Device device, int UserId)
        {
            if (await _context.UserXrefLocationEntity.AnyAsync(x => x.LocationId == LocationId &&
            x.UserId == UserId))
            {
                await _context.DeviceEntity.AddAsync(device);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }



        public Device GetDevice(int DeviceId , int UserId)
        {

            return _context.DeviceEntity.FirstOrDefault(_ => _.DeviceId == DeviceId);


        }



        public Location GetDeviceLocation(int LocationId)
        {
            return _context.LocationEntity.FirstOrDefault(x => x.LocationId == LocationId);
        }



        public async Task<bool> UpdateDevice(Device device, int UserId)
        {
            if (await _context.UserXrefLocationEntity.AnyAsync(x => x.LocationId == LocationId &&
            x.UserId == UserId))
            {
                _context.DeviceEntity.Update(device);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }



        



        public async Task<bool> RemoveDevice(Device device , int UserId)
        {
            if (await _context.UserXrefLocationEntity.AnyAsync(x => x.LocationId == LocationId &&
            x.UserId == UserId))

            {
                _context.DeviceEntity.Remove(device);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        
    }
}