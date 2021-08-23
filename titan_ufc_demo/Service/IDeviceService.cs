using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public interface IDeviceService
    {

        Task<bool> CreateDevice(Device device , int UserId);

        Task<bool> UpdateDeviceLocation(Location location);

        Device GetDevice(int DeviceId , int UserId);

        Task<bool> UpdateDevice(Device device , int UserId);

        Task<bool> RemoveDevice(Device device, int userId);
    }


}