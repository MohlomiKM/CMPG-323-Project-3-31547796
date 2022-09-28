using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Interface;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class DevicesClass:IDevicesInterface
    {
        private ConnectedOfficeContext _context;
        
        /*public DevicesClass()
        {
            this._context = new ConnectedOfficeContext();
        }*/

        public DevicesClass(ConnectedOfficeContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Device> GetAll()
        {
            return _context.Device.Include(d => d.Category).Include(d => d.Zone).ToList();
        }

        public Device GetByID(Guid? id)
        {
            return _context.Device.Find(id);
        }

        public void Insert(Device obj)
        {
            _context.Device.Add(obj);
        }

        public void Update(Device obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Guid? id)
        {
            Device existing = _context.Device.Find(id);
            _context.Device.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
