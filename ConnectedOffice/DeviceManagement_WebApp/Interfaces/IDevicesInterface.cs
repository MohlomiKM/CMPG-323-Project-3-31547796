using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public interface IDevicesInterface
    {
        IEnumerable<Device> GetAll();
        Device GetByID(Guid? id);
        void Insert(Device deviceobj);
        void Update(Device deviceobj);
        void Delete(Guid? id);
        void SaveChanges();
    }
}
