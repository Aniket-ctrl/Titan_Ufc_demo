using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using titan_ufc_demo.Models;

namespace titan_ufc_demo.Data_Access
{
    public interface IDeviceDataAccess
    {
        Task<bool> CreateDevice(Device device, int UserId);
        Device GetDevice(int DeviceId , int UserId);

        Task<bool> UpdateDevice(Device device,  int UserId);

        Task<bool> RemoveDevice(Device device , int UserId);
       //  Task<bool> CreateDevice(Device device);
       
    }
}

