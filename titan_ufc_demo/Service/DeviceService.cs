using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;
using titan_ufc_demo.DataAccess;
using titan_ufc_demo.Data_Access;

namespace titan_ufc_demo.Service
{
    public class DeviceService : IDeviceService
    {
        private IDeviceDataAccess _deviceDataAccess { get; set; }
        public DeviceService(IDeviceDataAccess _deviceDataAccess)
        {
            this._deviceDataAccess = _deviceDataAccess;
        }



        public async Task<bool> CreateDevice(Device device , int UserId)
        {
            return await _deviceDataAccess.CreateDevice(device , UserId);
        }





        public Device GetDevice(int DeviceId , int UserId)
        {
            return _deviceDataAccess.GetDevice(DeviceId, UserId);
        }



        public async Task<bool> UpdateDevice(Device device, int UserId)
        {
            return await _deviceDataAccess.UpdateDevice(device, UserId);
        }



        public async Task<bool> RemoveDevice(Device device, int UserId)
        {
            return await _deviceDataAccess.RemoveDevice(device , UserId);
        }

        public Task<bool> UpdateDeviceLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDevice(Device device)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveDevice(Device device)
        {
            throw new NotImplementedException();
        }
    }
}