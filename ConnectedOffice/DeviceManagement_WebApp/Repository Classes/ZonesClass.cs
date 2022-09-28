using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Interface;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class ZonesClass:IZonesInterface
    {
        private ConnectedOfficeContext _context;

        /*public ZonesClass()
        {
            this._context = new ConnectedOfficeContext();
        }*/

        public ZonesClass(ConnectedOfficeContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }

        public Zone GetByID(Guid? id)
        {
            return _context.Zone.Find(id);
        }

        public void Insert(Zone obj)
        {
            _context.Zone.Add(obj);
        }
        
        public void Update(Zone obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Guid? id)
        {
            Zone existing = _context.Zone.Find(id);
            _context.Zone.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
