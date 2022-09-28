using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Interface
{
    public interface IZonesInterface
    {
        IEnumerable<Zone> GetAll();
        Zone GetByID(Guid? id);
        void Insert(Zone zoneobj);
        void Update(Zone zoneobj);
        void Delete(Guid? id);
        void Save();
    }
}
